using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nikita
{
    [Table("Fine")]
    public class Fine
    {
        public Fine()
        {

        }

        public Fine(string description, int cost, DateTime dateOfAppointment, int clientId, int carId)
        {
            Description = description;
            Cost = cost;
            DateOfAppointment = dateOfAppointment;
            ClientId = clientId;
            CarId = carId;
        }

        public Fine(int id, string description, int cost, DateTime dateOfAppointment, int clientId, int carId)
            : this(description, cost, dateOfAppointment, clientId, carId)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public DateTime DateOfAppointment { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

    }
}
