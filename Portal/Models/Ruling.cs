using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
    public class Ruling
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Ruling")]
        [Key]
        public int RulingId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public int NumberOfCitations { get; set; }

        public int JudgeId { get; set; }

        public virtual Judge Judge { get; set; }
    }
}