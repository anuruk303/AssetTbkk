using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }
        public Department DepartmentDelete { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            DepartmentDelete = await _context.Department.FindAsync(Deletid);
            DepartmentDelete.Status = "Unused";
            _context.Attach(DepartmentDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostAsync(IFormFile Excel)
        {
            using (var reader = new StreamReader(Excel.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0] != null)
                    {
                        _context.Department.AddRange(
                                            new Department
                                            {
                                                DepartmentName = values[0],
                                                Image = values[1],
                                                Status = "Using"
                                            }
                                            );
                    }
                    else
                    {
                        break;
                    }
                }
            }

            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
