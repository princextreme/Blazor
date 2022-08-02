using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSideSPA.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
       [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Enter Sub Category")]
        [StringLength(250)]
        public string? SubCategoryTitle { get; set; }
        [ForeignKey("Employee")]
        public int EntryBy { get; set; }
        [DefaultValue("true")]
        public DateTime EntryDate { get; set; }
        [DefaultValue("true")]
        public int SStatus { get; set; }
        //[Required]
         public Project Project { get; set; }
        //public Employee Employee { get; set; }
         //public virtual ICollection<Project>? Projects { get; set; }
    }
}
