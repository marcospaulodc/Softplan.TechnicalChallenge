namespace Softplan.Business.Interfaces
{
    public interface ICalculaJurosAppService
    {
        public decimal CalculaJuros(decimal valorInicial, int tempo);
    }
}
