using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using STUDENT_MANAGEMENT.Data;
using STUDENT_MANAGEMENT.Model;

namespace STUDENT_MANAGEMENT.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly STUDENT_MANAGEMENT.Data.STUDENT_MANAGEMENTContext _context;

        public IndexModel(STUDENT_MANAGEMENT.Data.STUDENT_MANAGEMENTContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
