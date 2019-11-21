using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nine.Shows.DTOs
{
    public class ShowsList
    {
        [Required]
        public List<Payload> payload { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }
    }
}
