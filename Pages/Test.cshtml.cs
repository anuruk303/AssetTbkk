using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages
{
    public class TestModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public TestModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DeletidLi { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<License> License { get; set; }
        public License LicenseDelete { get; set; }
        public Asset AssetDelete { get; set; }
        public async Task OnGetAsync()
        {
            Asset = await _context.Asset.ToListAsync();
            License = await _context.License.ToListAsync();
           
        }
        public async Task<IActionResult> OnPostDeleteAsAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            AssetDelete = await _context.Asset.FindAsync(Deletid);
            AssetDelete.Status = "Unused";
            _context.Attach(AssetDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostDeleteLiAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            LicenseDelete = await _context.License.FindAsync(Deletid);
            LicenseDelete.Status = "Unused";
            _context.Attach(LicenseDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

}