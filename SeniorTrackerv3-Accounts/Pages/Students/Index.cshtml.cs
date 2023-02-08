using System;
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
    public class IndexModel : PageModel
    {
        private readonly SeniorTrackerv3_Accounts.Data.STContext _context;

        public IndexModel(SeniorTrackerv3_Accounts.Data.STContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
