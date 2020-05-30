using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TravelApi.Dao;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class UserController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public UserController(TravelContext context)
        {
            this.travelDb = context;
        }

        //注册
        [HttpPost("/register")]
        public ActionResult<User> AddUser(User user)
        {
            try{
                IQueryable<User> query = travelDb.Users.OrderByDescending(c=>c.Uid);
                if(query!=null)
                {
                    user.Uid = query.ToList().First().Uid+1;
                }
                else
                {
                    user.Uid = 000000;
                }
                travelDb.Users.Add(user);
                travelDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return user;
        }

        //获取个人信息
        [HttpGet("/get")]
        public ActionResult<User> GetUserInfo(int Uid)
        {
            var user = travelDb.Users.FirstOrDefault(t=>t.Uid ==Uid);
            if(user==null)
            {
                return NotFound();
            }
            return user;
        }

        //更新个人信息
        [HttpPut("/update")]
        public ActionResult<User> UpdateRoute(int Uid, User user)
        {
            if (Uid != user.Uid)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                travelDb.Entry(user).State = EntityState.Modified;
                travelDb.SaveChanges();
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
        public ActionResult<User> userLogin(int Uid, string password)
        {
            try
            {
                var user = travelDb.Users.FirstOrDefault(t => t.Uid == Uid);
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