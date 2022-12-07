using Microsoft.EntityFrameworkCore;
namespace LoginRegistrationDemo.Entities
{
    public class LoginRegisterDBContext : DbContext
    {
        public LoginRegisterDBContext()
        {

        }

        //entities 
        public DbSet<Users> Users { get; set; }
        public DbSet<>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DotNetFSD\\SQLEXPRESS;Initial Catalog=CaseStudyDB;Persist Security Info=True;User ID=sa;Password=pass@123");
        }

        //configuration string


    }
}
