using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class Reservation
    {
        [Key]
        public Guid IdReservation { get; set; }

        public Guid IdClient { get; set; }
        [ForeignKey("IdClient")]
        public Client Client { get; set; }
        public Guid IdRoom { get; set; }
        [ForeignKey("IdRoom")]
        public Room Room { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
    }
}
