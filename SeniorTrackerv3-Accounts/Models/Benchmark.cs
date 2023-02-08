using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeniorTrackerv3_Accounts.Models
{
    public class Benchmark
    {
        public int BenchmarkID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        [StringLength(3000)]
        public string Description { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
