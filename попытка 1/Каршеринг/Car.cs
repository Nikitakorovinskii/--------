using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nikita
{
    [Table("Car")]
    public class Car
    {
        public Car()
        {

        }

        public Car(string carName, string vin, int numberOfSeats,int coast)
        {
            СarName = carName;
            VIN = vin;
            NumberOfSeats = numberOfSeats;
            Coast = coast;
            IsDeleted = false;
            IsRented = false;
        }

        public Car(int id, string carName, string vin, int numberOfSeats,int coast) : this(carName, vin, numberOfSeats,coast)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string СarName { get; set; }

        [Required]
        [MaxLength(17)]
        public string VIN { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }
        [Required]
        public int Coast { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsRented { get; set; } = false;
        public override string ToString()
        {
            return $"Название авто: {СarName}  Кол-во мест: {NumberOfSeats} Цена: {Coast} ";
        }

        public virtual ICollection<Trip> Trip { get; set; }
        public virtual ICollection<Fine> Fine { get; set; }
        public virtual ICollection<GasStation> GasStation { get; set; }
        

    }
}
