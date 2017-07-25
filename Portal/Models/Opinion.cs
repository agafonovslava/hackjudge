using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
    public class Opinion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Opinion")]
        [Key]
        public int OpinionId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public int JudgeId { get; set; }

        public virtual Judge Judge { get; set; }
    }
}