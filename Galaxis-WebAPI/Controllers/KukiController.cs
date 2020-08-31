using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Galaxis_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KukiController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "kuki1", "kukiiii2654zgt6ghtghthg5h5ht" };
        }
    }
}