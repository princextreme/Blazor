using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSideSPA.Models
{
    public class Collaborator
    {
        [Key]
        public int CollaborationId { get; set; }
        //[ForeignKey("DailyWork")]
        //Foreign key for Standard
        [ForeignKey("DailyWork")]

        public int WorkId { get; set; }
        //public DailyWork DailyWork { get; set; }


        //[ForeignKey("Employee")]
        public int EmpId { get; set; }

        //public Employee Employee { get; set; }
        public int EntryBy { get; set; }
        [DefaultValue("true")] 
        public DateTime EntryDate { get; set; }
        [DefaultValue("true")]
        public int CStatus { get; set; }
        public DailyWork  DailyWork { get; set; } 
        //public DailyWork? DailyWorks { get; set; }
         //public Employee  Employee { get; set; }

    }
}
