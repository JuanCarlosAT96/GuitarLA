using System.ComponentModel.DataAnnotations;

namespace GuitarLA.Server.Models
{
    public class Guitar
    {
        [Key]
        public int GuitarId { get; set; }
        [Required]
        public string ? Name { get; set; }
        public byte[]? Image { get; set; }
        public string ? Description { get; set; }
        [Required]
        public double ? Price { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
