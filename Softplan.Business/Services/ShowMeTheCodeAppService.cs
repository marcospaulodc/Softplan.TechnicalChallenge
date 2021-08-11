namespace Softplan.Business.Services
{
    using Softplan.Business.Interfaces;

    public class ShowMeTheCodeAppService : IShowMeTheCodeAppService
    {
        public string GetUrlGit()
        {
            string urlGit= "https://github.com/marcospaulodc/Softplan.TechnicalChallenge";
            return urlGit;
        }
    }
}
