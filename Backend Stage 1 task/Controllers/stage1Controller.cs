using Backend_Stage_1_task.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Stage_1_task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class stage1Controller : Controller
    {
        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var res = new Response() { 
            slackUsername = "DevOyinda",
            backend = true,
            age = 25,
            bio = "Woman in Tech"};

            return Ok(res);
        }
    }
}
