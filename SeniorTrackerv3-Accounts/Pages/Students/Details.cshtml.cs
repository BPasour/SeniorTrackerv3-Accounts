﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SeniorTrackerv3_Accounts.Data;
using SeniorTrackerv3_Accounts.Models;

namespace SeniorTrackerv3_Accounts.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly SeniorTrackerv3_Accounts.Data.STContext _context;

        public DetailsModel(SeniorTrackerv3_Accounts.Data.STContext context)
        {
            _context = context;
        }

      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }
    }
}
