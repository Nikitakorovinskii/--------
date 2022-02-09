using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nikita
{
    [Table("Client")]
    public class Client : Human
    {
        public Client()
        {

        }
        public Client(string login, string password, string driversLicense)
        {
            Login = login;
            Password = password;
            DriversLicense = driversLicense;
        }
        public Client(int id, string login, string password, string driversLicense) : this(login, password, driversLicense)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Login { get; set; }

        [Required]
        [MaxLength(40)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string DriversLicense { get; set; }

        public virtual ICollection<Trip> Trip { get; set; }

        public virtual ICollection<Fine> Fine { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
    }
}
