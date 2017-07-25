namespace Portal.Models
{
    using Portal.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Judge
    {
        [ValidSatoriId]
        public string SatoriId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int JudgeId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime LastUpdated { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string CaseHolding { get; set; }

        public string AttorneyNames { get; set; }

        public string CommonlySitedSources { get; set; }

        public string JudicalSystem { get; set; }

        public string Jurisdiction { get; set; }

        public int NumberOfCases { get; set; }

        public string Education { get; set; }

        public string Religion { get; set; }

        public string Memberships { get; set; }

        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}