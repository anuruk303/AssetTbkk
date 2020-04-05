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

namespace tbkk_AC.Pages.Companys
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }
        public Company CompanyDelete { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            CompanyDelete = await _context.Company.FindAsync(Deletid);
            CompanyDelete.Status = "Unused";
            _context.Attach(CompanyDelete).State = EntityState.Modified;
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
                        _context.Company.AddRange(
                                            new Company
                                            {
                                                CompanyName = values[0],
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
