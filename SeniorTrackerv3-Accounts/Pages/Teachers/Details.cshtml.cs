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
    public class DetailsModel : PageModel
    {
        private readonly SeniorTrackerv3_Accounts.Data.STContext _context;

        public DetailsModel(SeniorTrackerv3_Accounts.Data.STContext context)
        {
            _context = context;
        }

      public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers.FirstOrDefaultAsync(m => m.ID == id);
            if (teacher == null)
            {
                return NotFound();
            }
            else 
            {
                Teacher = teacher;
            }
            return Page();
        }
    }
}
