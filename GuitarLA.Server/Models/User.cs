using System.ComponentModel.DataAnnotations;

namespace GuitarLA.Server.Models
{
    public class User
    {

        public int UserId { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? UserEmail {  get; set; }
        public ICollection<Guitar>? Guitars { get; set; }
    }
}
