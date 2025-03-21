using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Room
    {

        [Key]
        public Guid IdRoom { get; set; }

        public string ImgUrl { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<Reservation> Client { get; set; }

    }
}
