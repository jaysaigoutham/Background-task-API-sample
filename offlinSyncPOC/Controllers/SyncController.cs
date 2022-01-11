using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace offlinSyncPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyncController : ControllerBase
    {
        private readonly ILogger<SyncController> _logger;

        public SyncController(ILogger<SyncController> logger)
        {
            _logger = logger;
        }

        // GET api/<SyncController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SyncController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SyncController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SyncController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("uploadData")]
        public async Task<IActionResult> UploadDataAsync(string data, int duration = 1)
        {
            await Task.Delay(duration * 1000);
            return new JsonResult("Success - Uploading data complete");
        }

        [HttpGet("downloadData")]
        public async Task<IActionResult> DownloadDataAsync(string data, int duration = 1)
        {
            await Task.Delay(duration * 1000);
            return new JsonResult("Success - Downloading data complete");
        }
    }
}
