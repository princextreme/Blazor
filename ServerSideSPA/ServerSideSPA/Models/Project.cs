using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSideSPA.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Enter Project title")]
        [StringLength(250)]
        public string? ProjectTitle { get; set; }

        //[ForeignKey("Employee")]
        public int EntryBy { get; set; }
        [DefaultValue("true")]
        public DateTime EntryDate { get; set; }
        [DefaultValue("true")]
        public int PStatus { get; set; }
        //public virtual ICollection<SubCategory> SubCategories { get; set; }
       // public Employee Employee { get; set; }
    }
}
