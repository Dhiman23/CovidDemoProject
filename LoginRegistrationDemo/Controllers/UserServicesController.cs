using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoginRegistrationDemo.Entities;
using LoginRegistrationDemo.Repositories;
using LoginRegistrationDemo.Models;
namespace LoginRegistrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserServicesController : ControllerBase
    {
        private readonly RegistrationRepository registrationRepository;

        public UserServicesController()
        {
            registrationRepository = new RegistrationRepository();  
        }

        [HttpPost, Route("Register")]
        public IActionResult RegisterUser(Users user) 
        {
            try
            {
                registrationRepository.Register(user);
                return StatusCode(200, "Registered");
            }
            catch (Exception e)
            {

                return StatusCode(404, e.Message);
            }
        }


        [HttpPost, Route("Login")]
        public IActionResult LoginUser(ValidateUser user)
        {
            try
            {
                Users ur =  registrationRepository.Validate(user);
                if (ur != null)
                    return StatusCode(200, ur);
                else
                    return StatusCode(500, "Wrong credentials or user does not exist");
            }
            catch (Exception e)
            {

                return StatusCode(404, e.Message);
            }
        }
    }
}
