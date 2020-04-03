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

namespace tbkk_AC.Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Model> Model { get;set; }
        public Model ModelDelete { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        public async Task OnGetAsync()
        {
            Model = await _context.Model
                .Include(m => m.Brand)
                .ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            ModelDelete = await _context.Model.FindAsync(Deletid);
            ModelDelete.Status = "Unused";
            _context.Attach(ModelDelete).State = EntityState.Modified;
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
                        _context.Model.AddRange(
                                            new Model
                                            {
                                                ModelName = values[0],
                                                Note = values[1],
                                                Status = "Using",
                                                Brand_BrandID = Int32.Parse(values[2])
                                                
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
