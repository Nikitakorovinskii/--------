using System.ComponentModel.DataAnnotations;

namespace Nikita
{
    public abstract class Human
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }
    }
}
