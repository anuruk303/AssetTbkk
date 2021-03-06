﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Brands
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;
        private IHostingEnvironment environment;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Brand Brand { get; set; }
        public async Task<IActionResult> OnPostAsync(IFormFile photo)
        {
            try
            {
                var file = Path.Combine(environment.ContentRootPath, "wwwroot/uploads", photo.FileName);
                var fileStream = new FileStream(file, FileMode.Create);
                Brand.Image = photo.FileName;
                if (!ModelState.IsValid)
                {

                }
                _context.Brand.Add(Brand);
                await _context.SaveChangesAsync();
                await photo.CopyToAsync(fileStream);
                return RedirectToPage("./Index");

            }
            catch (InvalidCastException e)
            {
            }

            return RedirectToPage("./Index");
        }
       
    }
}