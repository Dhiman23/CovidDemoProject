using LoginRegistrationDemo.Models;
using LoginRegistrationDemo.Entities;
namespace LoginRegistrationDemo.Contracts
{
    public interface IRegistrationContract
    {
        //add users
        public void Register(Users user);

        //edit user
        public Users Validate(ValidateUser user);

        //delete user

    }
}
