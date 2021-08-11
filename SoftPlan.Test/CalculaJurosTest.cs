namespace Softplan.Tests
{
    using Moq;
    using Softplan.Business.Interfaces;
    using Xunit;

    public class CalculaJurosTest
    {
        private readonly Mock<ICalculaJurosAppService> calculaJurosAppService;
        private readonly Mock<ITaxaJurosAppService> taxaJurosAppService;
        private readonly Mock<IShowMeTheCodeAppService> showMeTheCodeAppService;

        public CalculaJurosTest()
        {
            this.calculaJurosAppService = new Mock<ICalculaJurosAppService>();
            this.taxaJurosAppService = new Mock<ITaxaJurosAppService>();
            this.showMeTheCodeAppService = new Mock<IShowMeTheCodeAppService>();
        }

        [Fact]
        public void CalculaJuros()
        {
            calculaJurosAppService.Setup(m => m.CalculaJuros(100, 5));
            calculaJurosAppService.Setup(m => m.CalculaJuros(0, 0));
            calculaJurosAppService.Setup(m => m.CalculaJuros(565656.555M, 12));
        }

        [Fact]
        public void GetTaxaJuros()
        {
            taxaJurosAppService.Setup(m => m.GetTaxaJuros());
        }

        [Fact]
        public void GetUrlGit()
        {
            showMeTheCodeAppService.Setup(m => m.GetUrlGit());
        }
    }
}
