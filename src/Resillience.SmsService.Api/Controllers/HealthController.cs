﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Resillience.SmsService.Api.Controllers
{
    /// <summary>
    /// 健康检查
    /// </summary>
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// 健康检查
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var res = "Healthy";
            return Ok(res);
        }
    }
}