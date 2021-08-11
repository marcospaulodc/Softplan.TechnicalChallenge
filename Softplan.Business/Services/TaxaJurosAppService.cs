namespace Softplan.Service.Services
{
    using Softplan.Business.Interfaces;

    public class TaxaJurosAppService : ITaxaJurosAppService
    {

        public TaxaJurosAppService()
        {
        }

        public decimal GetTaxaJuros()
        {
            decimal taxaJuros = 0.01M;
            return taxaJuros;
        }
    }
}
