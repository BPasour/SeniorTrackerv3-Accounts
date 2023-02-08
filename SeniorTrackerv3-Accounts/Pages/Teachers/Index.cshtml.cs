using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SeniorTrackerv3_Accounts.Data;
using SeniorTrackerv3_Accounts.Models;

namespace SeniorTrackerv3_Accounts.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly SeniorTrackerv3_Accounts.Data.STContext _context;

        public IndexModel(SeniorTrackerv3_Accounts.Data.STContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teachers { get; set; } = default!;
        public IList<Student> Students { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Teachers != null)
            {
                Teachers = await _context.Teachers.ToListAsync();
            }
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }

            foreach (var teacher in Teachers)
            {
                foreach (var student in Students)
                {
                    if (student.Advisor == teacher.Name)
                    {
                        teacher.AdvCount += 1;
                        teacher.Advisees.Add(student.Name);
                    }
                    
                    if (student.Board1 == teacher.Name || student.Board2 == teacher.Name)
                    {
                        teacher.BoardCount += 1;
                        teacher.BoardStudents.Add(student.Name);
                    }
                }
            }
        }
    }
}
