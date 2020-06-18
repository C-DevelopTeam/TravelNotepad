using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using TravelApi.Service;
using TravelApi.Models;
using TravelApi.Utils;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IDiaryService _diaryService;
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = {".jpg", ".gif", ".jpeg", ".png"};
        private readonly string _rootPath;
        private static readonly FormOptions _defaultFormOptions = new FormOptions();

        public FileController(IDiaryService diaryService, IConfiguration config)
        {
            this._diaryService = diaryService;
            this._rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, config.GetValue<string>("StoredFileFolder"));
            this._fileSizeLimit = config.GetValue<long>("fileSizeLimit");
        }

        [HttpPost("/upload")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(long diaryId)
        {
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("File", 
                    $"The request couldn't be processed (Error 1).");
                return BadRequest(ModelState);
            }
            var fileName = "";
            var diary = _diaryService.GetById(diaryId);
            if(diary == null)
            {
                return BadRequest("The diary is not existed.");
            }
            var boundary = MultipartRequestHelper.GetBoundary(
                    MediaTypeHeaderValue.Parse(Request.ContentType),
                    _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader = 
                    ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {
                    if (!MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        ModelState.AddModelError("File", 
                            $"The request couldn't be processed (Error 2).");
                        return BadRequest(ModelState);
                    }
                    else
                    {
                        fileName = Path.GetRandomFileName();
                        var streamedFileContent = await FileHelpers.ProcessStreamedFile(
                            section, contentDisposition, ModelState, 
                            _permittedExtensions, _fileSizeLimit);

                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        using (var targetStream = System.IO.File.Create(Path.Combine(_rootPath, fileName)))
                        {
                            await targetStream.WriteAsync(streamedFileContent);
                        }
                    }
                }
                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                diary.Photo = String.Join(" ", new string[]{diary.Photo, fileName});
                _diaryService.Update(diary);
                section = await reader.ReadNextSectionAsync();
            }

            return Created(nameof(FileController), null);
        }


        [HttpGet("/download")]
        public async Task<IActionResult> Download(string fileName)
        {
            if(! Directory.Exists(_rootPath))
            {
                Directory.CreateDirectory("static");
            }

            var filePath = Path.Combine(_rootPath, fileName);
            try
            {
                if(! System.IO.File.Exists(filePath))
                {
                    return NotFound();
                }
                var fileStream = new FileStream(filePath, FileMode.Open);
                var header = new MediaTypeHeaderValue("application/octet-stream");
                //var content = new StreamContent(fileStream);
                // 修改Header
                //content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                //content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                //{
                //    FileName = fileName
                //};
                //var response = new HttpRequestMessage(){Content = content};
                return new FileStreamResult(fileStream, header);
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
    }
}