using SeniorTrackerv3_Accounts.Models;
using System.Xml.Linq;

namespace SeniorTrackerv3_Accounts.Data
{
    public class DbInitializer
    {
        public static void Initialize(STContext context)
        { 
            if (context.Students.Any()) 
            {
                return;
            }

            var students = new Student[]
            {
                new Student
                {
                    Name="Adler",
                    Email="adrobinson@newschoolva.org",
                    GAdvisor=(Faculty)Enum.Parse(typeof(Faculty), "Shannan"),
                    Topic = "Electric Motorcycles",
                    Credit = (CreditType)Enum.Parse(typeof(CreditType), "Physics"),
                    Advisor = (Faculty)Enum.Parse(typeof(Faculty), "Billy"),
                    Board1 = (Faculty)Enum.Parse(typeof(Faculty), "Chethan"),
                    Board2 = (Faculty)Enum.Parse(typeof(Faculty), "Jonathan"),
                    CoverLetter = "I want to design an electric motorcycle",
                    Honors = false
                }
            };
            
            context.Students.AddRange(students);
            context.SaveChanges();

            var teachers = new Teacher[]
            {
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Alan"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Alan"),
                    Email = "avillarreal@newschoolva.org",
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Alexis"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Alexis"),
                    Email = "anolasco@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Austin"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Austin"),
                    Email = "abartenstein@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Billy"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Billy"),
                    Email = "wpasour@newschoolva.org",
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Carolina"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Carolina"),
                    Email = "cmclean@newshcoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Chethan"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Chethan"),
                    Email = "ckenkermath@newschoolva.org",
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Clara"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Clara"),
                    Email = "csaa@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Claudia"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Claudia"),
                    Email = "crohaly@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Diana"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Diana"),
                    Email = "dgibson@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Eden"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Eden"),
                    Email = "ecostagliola@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Gabbi"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Gabbi"),
                    Email = "gchwae@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Henry"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Henry"),
                    Email = "hedwards@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Janis"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Janis"),
                    Email = "jtrizna@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Jenny"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Jenny"),
                    Email = "jfey@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Joan"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Joan"),
                    Email = "jgoodman@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Jonathan"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Jonathan"),
                    Email = "jrushbrook@newschoolva.org",
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Josh"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Josh"),
                    Email = "jstlouis@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Kara"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Kara"),
                    Email = "kjonach@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Maddy"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Maddy"),
                    Email = "mboyle@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Noelle"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Noelle"),
                    Email = "nandreano@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Rachel"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Rachel"),
                    Email = "rlewis@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Savi"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Savi"),
                    Email = "sravichandran@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Shannan"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Shannan"),
                    Email = "sdanish@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Steve"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Steve"),
                    Email = "sroushakes@newschoolva.org"
                },
                new Teacher
                {
                    ID = (int)Enum.Parse(typeof(Faculty), "Taryn"),
                    Name = (Faculty)Enum.Parse(typeof(Faculty), "Taryn"),
                    Email = "tlonergan@newschoolva.org"
                }
            };

            context.Teachers.AddRange(teachers);
            context.SaveChanges();

            var benchmarks = new Benchmark[]
            {
                new Benchmark
                {
                    DueDate = DateTime.Parse("01/30/2023"),
                    Description = "Proposal",
                    StudentID = students[0].ID
                },
                new Benchmark
                {
                    DueDate = DateTime.Parse("05/01/2023"),
                    Description = "Presentation",
                    StudentID = students[0].ID
                }
            };

            context.Benchmarks.AddRange(benchmarks);
            context.SaveChanges();
        }
    }
}
