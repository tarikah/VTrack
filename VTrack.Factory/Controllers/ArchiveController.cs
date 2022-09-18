using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VTrack.Factory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetArchives()
        {
            return Ok(new { response = "archive ok" });
        }

        [HttpGet("{id}")]
        public ActionResult GetArchiveById(int id)
        {
            return Ok(new { response = "archive by id ok" });
        }
        [HttpPost]
        public ActionResult PostArchives()
        {
            return Ok(new { response = "archive post ok" });
        }

    }
}
