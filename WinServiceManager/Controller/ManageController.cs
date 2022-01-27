using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinServiceManager.BLL;

namespace WinServiceManager.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageController : ControllerBase
    {
        private readonly IWindowServiceMgr serviceMgr;

        public ManageController(IWindowServiceMgr serviceMgr)
        {
            this.serviceMgr = serviceMgr;
        }
        [HttpGet(nameof(StartService))]
        public IActionResult StartService()
        {
            try
            {
                serviceMgr.StartOrRestart();
                return Ok("service started successfully!");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{e.InnerException}");
            }
        }
        [HttpGet(nameof(StopService))]
        public IActionResult StopService()
        {
            try
            {
               // serviceMgr.StopServiceIfRunning();
                return BadRequest("stop service operation not allow!");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{e.InnerException}");
            }
        }

    }
}
