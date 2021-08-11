namespace Softplan.Web.Controllers.v1
{
    using Microsoft.AspNetCore.Mvc;
    using Softplan.Business.Interfaces;

    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : Controller
    {
        private readonly ITaxaJurosAppService taxaJurosAppService;

        public TaxaJurosController(ITaxaJurosAppService taxaJurosAppService)
        {
            this.taxaJurosAppService = taxaJurosAppService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Get()
        {
            decimal taxaJuros = taxaJurosAppService.GetTaxaJuros();

            if (taxaJuros == 0)
            {
                return BadRequest(this.ModelState);
            }

            return Ok(taxaJuros);
        }
    }
}
