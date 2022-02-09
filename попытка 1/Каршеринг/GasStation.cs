using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita
{
    [Table("GasStation")]
    public class GasStation
    {
        public GasStation()
        {

        }
        public GasStation(int petrol, int carId)
        {
            Petrol = petrol;
            CarId = carId;
        }
        public GasStation(int id, int petrol, int carId) : this(petrol, carId)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Petrol { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }
    }
}
