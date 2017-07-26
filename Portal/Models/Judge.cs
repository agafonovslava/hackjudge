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

        public string StudiedInWest { get; set; }

        public string WasCitationUsed { get; set; }

        public string ArrestedForCorruption { get; set; }

        public string Country { get; set; }

        public DateTime LastUpdated { get; set; }

        public string ImageUrl { get; set; }

        public string Born { get; set; }

        public string Description { get; set; }

        public string AttorneyNames { get; set; }

        public string CommonlyCitedSources { get; set; }

        public string JudicalSystem { get; set; }

        public string Jurisdiction { get; set; }

        public int NumberOfCases { get; set; }

        public string Education { get; set; }

        public string Language { get; set; }

        public virtual ICollection<Ruling> Rulings { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}