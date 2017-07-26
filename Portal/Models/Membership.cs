using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
    public class Membership
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Membership")]
        [Key]
        public int MembershipId { get; set; }

        public string Title { get; set; }

        public int JudgeId { get; set; }

        public virtual Judge Judge { get; set; }
    }
}