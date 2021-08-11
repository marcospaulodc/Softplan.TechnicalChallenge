namespace Softplan.Business.Services
{
    using System;
    using Softplan.Business.Interfaces;

    public class CalculaJurosAppService : ICalculaJurosAppService
    {
        private readonly ITaxaJurosAppService taxaJurosAppService;

        public CalculaJurosAppService(ITaxaJurosAppService taxaJurosAppService)
        {
            this.taxaJurosAppService = taxaJurosAppService;
        }

        public decimal CalculaJuros(decimal valorInicial, int tempo)
        {
            decimal taxaJuros = taxaJurosAppService.GetTaxaJuros();
            decimal valorFinal = (decimal)Math.Pow((double)(1 + taxaJuros), tempo);

            valorFinal = 100 * valorFinal;

            return decimal.Round(valorFinal, 2);
        }
    }
}
