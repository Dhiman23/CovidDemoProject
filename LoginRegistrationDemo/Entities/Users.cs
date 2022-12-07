using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegistrationDemo.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName ="varchar")]
        [Required]
        public string UserName { get; set; }

        [StringLength(64)] // because we will store secure password
        [Column(TypeName = "varchar")]
        [Required]
        public string Password { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Required]
        public string Email { get; set; }
        public int? IsActive  { get; set; }
       
    }
}
