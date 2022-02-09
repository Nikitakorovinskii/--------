using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Каршеринг;

namespace Nikita
{
    [Table("Trip")]
    public class Trip
    {
        private int minutes;
        private long cost;
        private DateTime endDate;

        public Trip()
        {
            IsPaid = false;
        }

        public Trip(DateTime startDate, DateTime endDate, int minutes, long cost, bool isPaid, int carId, int clientId)
        {
            StartDate = startDate;
            EndDate = endDate;
            Minutes = minutes;
            Cost = cost;
            IsPaid = isPaid;
            CarId = carId;
            ClientId = clientId;
        }

        // isPaid удалить
        public Trip(DateTime startDate, int carId, int clientId)
        {
            StartDate = startDate;
            IsPaid = false;
            CarId = carId;
            ClientId = clientId;
        }



        public Trip(int id, DateTime startDate, DateTime endDate, int minutes, long cost, bool isPaid, int carId, int clientId)
            : this(startDate, endDate, minutes, cost, isPaid, carId, clientId)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                getCostTrip();
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
        }

        public long Cost
        {
            get
            {
                return cost;
            }
            private set
            {
                cost = value;
            }
        }

        [Required]
        public bool IsPaid { get; set; } = false;


        [Required]
        public int CarId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public virtual ICollection<PayCar> PayCars { get; set; }


        private void getMinutesTrip()
        {
            if (StartDate != null && EndDate != null)
                Minutes = (int)(EndDate - StartDate).Duration().TotalMinutes;
        }

        private void getCostTrip()
        {
            getMinutesTrip();
            if (Car != null && CarId > 0 && Minutes >= 1)
                Cost = Minutes * Car.Coast;
            else if (Minutes < 1)
                Cost = 100;
        }
    }
}
