using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nikita
{
    [Table("Contract")]
    public class Contract
    {
        public Contract()
        {

        }

        public Contract(int clientId)
        {
            ClientId = clientId;
        }

        public Contract(int id, int clientId) : this(clientId)
        {
            Id = id;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DateContract { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

    }
}
