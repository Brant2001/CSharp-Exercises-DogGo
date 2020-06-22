using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Doggo.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Owner")]
        public int OwnerId { get; set; }

        [Required]
        [DisplayName("Breed")]
        public string Breed { get; set; }

        [Required]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [Required]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
    }
}
