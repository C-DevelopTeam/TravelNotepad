using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class TravelController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public TravelController(TravelContext context)
        {
            this.travelDb = context;
        }

        //todo: 编写相关路由操作
    }
}