using CovidService.Contracts;
using CovidService.Entities;
using CovidService.Models;

namespace CovidService.Repositories
{
    public class CovidDetailsRepository : ICovidDetailsContract
    {


        private ApplicationDbContext appdbContext;

        public CovidDetailsRepository()
        {
            appdbContext = new ApplicationDbContext();
        }

        public CovidDetails GetCovidDetail(int id)
        {
            try
            {

                CovidDetails details = appdbContext.Covid.SingleOrDefault(x => x.Id == id);
                return details;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CovidDetails> GetCovidDetails()
        {
            try
            {
                return appdbContext.Covid.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}

