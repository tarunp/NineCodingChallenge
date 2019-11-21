using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nine.Shows.DTOs
{
    public class Payload
    {
        public string country { get; set; }
        public string description { get; set; }
        [Required]
        public bool drm { get; set; }
        [Required]
        public int episodeCount { get; set; }
        public string genre { get; set; }
        public Image image { get; set; }
        public string language { get; set; }
        public NextEpisode nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public List<Season> seasons { get; set; }
        [Required]
        public string slug { get; set; }
        [Required]
        public string title { get; set; }
        public string tvChannel { get; set; }
    }
}
