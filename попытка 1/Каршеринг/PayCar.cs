using Nikita;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Каршеринг
{
    [Table("PayOfCar")]


    public class PayCar
    {
        public PayCar()
        {

        }

        public PayCar(bool status, int tripId, DateTime chek)
        {
            Status = status;
            TripId = tripId;
            Chek = chek;
        }

        public PayCar(int id, bool status, int tripId, DateTime chek) : this(status, tripId, chek)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Chek { get; set; }

        public bool Status { get; set; } = false;

        [Required]
        public int TripId { get; set; }

        [ForeignKey("TripId")]
        public Trip Trip { get; set; }




    }
}

