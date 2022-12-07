using LoginRegistrationDemo.Contracts;
using LoginRegistrationDemo.Entities;
using LoginRegistrationDemo.Models;

namespace LoginRegistrationDemo.Repositories
{
    public class RegistrationRepository : IRegistrationContract
    {
        private readonly LoginRegisterDBContext loginRegisterDBContext;

        public RegistrationRepository()
        {
            loginRegisterDBContext = new LoginRegisterDBContext();
        }

        //To Register user
        public void Register(Users user)
        {
            try
            {
                loginRegisterDBContext.Users.Add(user);
                loginRegisterDBContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //to login user
        public Users Validate(ValidateUser user)
        {
            try
            {
                Users ur = loginRegisterDBContext.Users.SingleOrDefault(p => p.UserName == user.UserName && p.Password == user.Password);
                return ur;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        
    }
}
