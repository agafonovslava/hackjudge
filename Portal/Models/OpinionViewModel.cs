using System.Collections.Generic;

namespace Portal.Models
{
    public class OpinionViewModel
    {
        public List<Opinion> Opinions { get; set; }

        public bool ShowActions { get; set; }

        public string SearchTerm { get; set; }
    }
}