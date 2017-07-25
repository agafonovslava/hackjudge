using System.Collections.Generic;

namespace Portal.Models
{
    public class HomeViewModel
    {
        public List<Judge> Judges { get; set; }

        public bool ShowActions { get; set; }

        public string SearchTerm { get; set; }
    }
}