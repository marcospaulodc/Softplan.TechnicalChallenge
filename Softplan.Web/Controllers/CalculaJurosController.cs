namespace Softplan.Web.Controllers.v1
{
    using Microsoft.AspNetCore.Mvc;
    using Softplan.Business.Interfaces;

    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private readonly ICalculaJurosAppService calculaJurosAppService;

        public CalculaJurosController(ICalculaJurosAppService calculaJurosAppService)
        {
            this.calculaJurosAppService = calculaJurosAppService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Get([FromHeader] decimal valorInicial, [FromHeader] int tempo)
        {
            decimal result = calculaJurosAppService.CalculaJuros(valorInicial, tempo);

            return Ok(result);
        }
    }
}
