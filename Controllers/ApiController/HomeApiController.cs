using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding1.Models;

namespace ModelBinding1.Controllers.ApiController
{
    [Route("api/homeapi")]
    [ApiController]
    public class HomeApiController : ControllerBase
    {
        public HomeApiController()
        {

        }

        //Bind Data Using Header
        [HttpPost]
        [Route("getDataFromHeader")]
        public IActionResult getDataFromHeader([FromHeader] StudentHeaderModel student)
        {

            return Ok(student);
        }

        //Bind Data Using Query
        [HttpPost]
        [Route("getDataFromQuery")]
        public IActionResult getDataFromQuery([FromQuery] StudentQueryModel student)
        {

            return Ok(student);
        }

        //Bind Data Using Body
        [HttpPost]
        [Route("getDataFromBody")]
        public IActionResult getDataFromBody([FromBody] StudentBodyModel student)
        {

            return Ok(student);
        }

        //Bind Data Using Form
        [HttpPost]
        [Route("getDataFromForm")]
        public IActionResult getDataFromForm([FromForm] StudentFormModel student)
        {

            return Ok(student);
        }

        //Bind Data Using Route
        [HttpPost]
        [Route("getDataFromRoute/{Id}/{Name}/{Address}")]
        public IActionResult getDataFromRoute([FromRoute] StudentRouteModel student)
        {

            return Ok(student);
        }
    }
}
