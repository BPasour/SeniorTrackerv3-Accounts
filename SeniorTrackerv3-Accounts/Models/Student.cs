using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeniorTrackerv3_Accounts.Models
{
    public enum CreditType
    {
        [Display(Name = "--None Yet--")] na,
        English, Math,
        [Display(Name = "Applied Math")] AppMath,
        Biology, Chemistry, Physics,
        [Display(Name = "General Science")] GenSci,
        Government,
        [Display(Name = "American History")] AmHist,
        [Display(Name = "World Studies/Geography")] WSG,
        Arts,
        [Display(Name = "Social Studies")] SS,
        [Display(Name = "Foreign Language")] FL,
        [Display(Name = "Physical Education and Health")] PE,
        Computers
    }

    public class Student
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        
        // TEMP. Use account email for email.
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Display(Name= "Grade Level Advisor")]
        public Faculty GAdvisor { get; set; }

        [Required]
        [StringLength(50)]
        public string Topic { get; set; }

        public CreditType Credit { get; set; }
        public Faculty Advisor { get; set; }

        [Display(Name = "Board 1")]
        public Faculty Board1 { get; set; }

        [Display(Name = "Board 2")]
        public Faculty Board2 { get; set; }

        [Display(Name = "Outside Board", Prompt = "Required for Honors")]
        public string Board3 { get; set; }
        [StringLength(6000)]
        public string CoverLetter { get; set; }
        public bool Honors { get; set; } = false;
        [Display(Name = "Timeline")]
        public ICollection<Benchmark> Benchmarks { get; set; }
    }
}
