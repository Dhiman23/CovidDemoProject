using CovidService.Entities;
using CovidService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidDetailsController : ControllerBase
    {

        private readonly CovidDetailsRepository covidDetailsRepository;
        public CovidDetailsController()
        {
            covidDetailsRepository = new CovidDetailsRepository();
        }

        [HttpGet, Route("GetCovidDetails")]

        public IActionResult GetAll()
        {
            try
            {
                List<CovidDetails> covidDetails = covidDetailsRepository.GetCovidDetails();
                return StatusCode(200, covidDetails);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet, Route("GetCovidDeatilsById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                CovidDetails covidDetails = covidDetailsRepository.GetCovidDetail(id);
                if (covidDetails != null)
                    return StatusCode(200, covidDetails);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }




    }
}
