using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthDemo.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("get-list")]
        [AuthAttribute()]
        public async Task<IActionResult> GetDataList()
        {
            var _res = new { status = 200, Message = "Sucesss", Data = "Succesfully Authorize.!" };
            return Ok(_res);
        }
    }
}
