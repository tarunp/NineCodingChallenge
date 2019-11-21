using System.ComponentModel.DataAnnotations;

namespace Nine.Shows.DTOs
{
    public class Image
    {
        [Required]
        public string showImage { get; set; }
    }
}
