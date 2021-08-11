namespace Softplan.Web.Controllers.v1
{
    using Microsoft.AspNetCore.Mvc;
    using Softplan.Business.Interfaces;

    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : Controller
    {
        private readonly IShowMeTheCodeAppService showMeTheCodeAppService;

        public ShowMeTheCodeController(IShowMeTheCodeAppService showMeTheCodeAppService)
        {
            this.showMeTheCodeAppService = showMeTheCodeAppService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Get()
        {
            string result = showMeTheCodeAppService.GetUrlGit();

            if (string.IsNullOrWhiteSpace(result))
            {
                return BadRequest(this.ModelState);
            }

            return Ok(result);
        }
    }
}
