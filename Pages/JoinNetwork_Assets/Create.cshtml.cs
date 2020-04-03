using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.JoinNetwork_Assets
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id, String num)
        {
            Company = await _context.Company.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Category = await _context.Category.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Num = num;
            ID = id;
            Asset = await _context.Asset.ToListAsync();
            Network = await _context.Network.ToListAsync();
            return Page();
        }
        public IList<Company> Company { get; set; }
        public IList<Category> Category { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Supplier> Supplier { get; set; }
        [BindProperty]
        public Join_Network_Asset Join_Network_Asset { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Network> Network { get; set; }
        public string Num { get;set; }
        public int ID { get;set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Join_Network_Asset.Add(Join_Network_Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}