using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSideSPA.Models
{
    public class DailyWork
    {
        [Key]
        public int WorkId { get; set; }
        [Required(ErrorMessage = "Enter Work details")]
        [StringLength(int.MaxValue)]
        public string WorkDetails { get; set; }
        //public List<string>? ProjectCategory { get; set; }
        //[ForeignKey("Project")]
        //public int ProjectId { get; set; }
        //public List<string>? SubCategory { get; set; }
        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }
        [ForeignKey("Employee")]
        public int GivenBy { get; set; }
         [ForeignKey("Assignment")]
        public int? AssignmentId { get; set; }
        // [ForeignKey("AssignmentId")]
        //[ForeignKey("Employee")]
        public int EntryBy { get; set; }
        [DefaultValue("true")]
        public DateTime EntryDate { get; set; }
        [DefaultValue("true")]
        public int WStatus { get; set; }
        public ICollection<Collaborator> Collaborators { get; set; }

        //public DailyWork()
        //{
        //    ProjectCategory = new List<string>();
        //    SubCategory = new List<string>();

        //}
        public Assignment? Assignment { get; set; }
        //public Project? Project { get; set; }
        public SubCategory? SubCategory { get; set; }
        //[ForeignKey("GivenBy,EntryBy")]
        //public virtual Employee  Employee { get; set; }
        public virtual Employee Employee { get; set; }



    }
}
