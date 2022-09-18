using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VTrack.Track.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDms()
        {
            return Ok(new { response = "dms ok" });
        }

        [HttpGet("{id}")]
        public ActionResult GetArchiveById(int id)
        {
            return Ok(new { response = "dms by id ok" });
        }
        [HttpPost]
        public ActionResult PostArchives()
        {
            return Ok(new { response = "dms post ok" });
        }
    }
}
