﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }
        public Category CategoryDelete { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            CategoryDelete = await _context.Category.FindAsync(Deletid);
            CategoryDelete.Status = "Unused";
            _context.Attach(CategoryDelete).State = EntityState.Modified;
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
                        _context.Category.AddRange(
                                            new Category
                                            {
                                                CategoryName = values[0],
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
