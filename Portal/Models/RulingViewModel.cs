using System.Collections.Generic;

namespace Portal.Models
{
    public class RulingViewModel
    {
        public List<Ruling> Rulings { get; set; }

        public bool ShowActions { get; set; }

        public string SearchTerm { get; set; }
    }
}