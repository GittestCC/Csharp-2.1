using Microsoft.AspNetCore.Mvc;

namespace sample.Controllers
{
    [Route("sample")]
    public class SampleController : Controller
    {
        /**
         * @api {GET} /sample/{message} Gets message to be returned
         * 
         * @apiName sample
         * 
         * @apiParam (Url) {String} message Message you want to be returned
         * 
         * @apiSuccess (200) {String} message Message returned to user
         */
        [Produces("application/json")]
        [HttpGet("{message}")]
        public IActionResult Get(string message)
        {
            return Ok(message);
        }
    }
}