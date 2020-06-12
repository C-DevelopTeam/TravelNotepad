using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Service;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            this._userService = userService;
        }

        //注册
        [HttpPost("/register")]
        public ActionResult<User> AddUser(User user)
        {
            try{
                IQueryable<User> query = _userService.SelectAll();
                if(query!=null)
                {
                    user.Uid = query.ToList().First().Uid+1;
                }
                else
                {
                    user.Uid = 000000;
                }
                _userService.Add(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return user;
        }

        //获取个人信息
        [HttpGet("/get")]
        public ActionResult<User> GetUserInfo(int uid)
        {
            var user = _userService.GetById(uid);
            if(user==null)
            {
                return NotFound();
            }
            return user;
        }

        //更新个人信息
        [HttpPut("/update")]
        public ActionResult<User> UpdateRoute(int uid, User user)
        {
            if (uid != user.Uid)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _userService.Update(user);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //登录
        [HttpPut("/login")]
        public ActionResult<User> userLogin(int uid, string password)
        {
            try
            {
                var user = _userService.GetById(uid);
                if (user == null)
                {
                    return NotFound();
                }
                if(user.Password != password)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }        
    }
}