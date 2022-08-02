using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSideSPA.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        [Required(ErrorMessage = "Enter Assignment title")]
        [StringLength(250)]
        public string? AssignmentTitle { get; set; }
        [Required(ErrorMessage = "Enter Assignment details")]
        [StringLength(int.MaxValue)]
        public string? AssignmentDetails { get; set; }

        [ForeignKey("Employee")]
        public int GivenBy { get; set; }
        
        public DateTime AssignedDate { get; set; }
        public DateTime FinishDate { get; set; }
        [DefaultValue("true")]
        public int AStatus { get; set; }
        public Employee? Employee { get; set; }

    }
}
