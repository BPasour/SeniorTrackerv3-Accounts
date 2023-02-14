using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeniorTrackerv3_Accounts.Models
{
    public enum Faculty
    {
        [Display(Name = "--None Yet--")] na,
        Alan, Alexis, Austin, Billy, Carolina,
        Chethan, Clara, Claudia, Diana, Eden,
        Gabbi, Henry, Janis, Jenny, Joan, Jonathan, Josh,
        Kara, Maddy, Noelle, Rachel, Savi,
        Shannan, Steve, Taryn
    }
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        public Faculty Name { get; set; }


        // TEMP. Use account email for email
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        // Count through Exhibitions pointing to this Teacher as Advisor
        [Display(Name = "Advising Count")]
        [DisplayFormat()]
        public int AdvCount { get; set; }

        // Clickable link to exhibition pages
        [NotMapped]
        public ICollection<string> Advisees { get; set; } = new Collection<string>();

        // Count through Exhibitions pointing to this Teacher as Board1 or Board2
        [Display(Name = "Board Count")]
        public int BoardCount { get; set; }

        // Clickable links to exhibition pages
        [Display(Name = "Board Students")]
        [NotMapped]
        public ICollection<string> BoardStudents { get; set; } = new Collection<string>();
    }
}
