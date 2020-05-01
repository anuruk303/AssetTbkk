using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Licenses
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int DeletidLi { get; set; }
        
        public License License { get; set; }
      
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Join_License_Asset> Join_License_Asset { get; set; }
        public Join_License_Asset Join_License_AssetDelete { get; set; }
        public IList<Asset> Asset { get; set; }
        
        public IList<Update_License> Update_License { get; set; }
        public async Task<IActionResult> OnPostDeleteLiAsync()
        {
            if (DeletidLi == 0)
            {
                return NotFound();
            }

            Join_License_AssetDelete = await _context.Join_License_Asset.FindAsync(DeletidLi);
            Join_License_AssetDelete.Status = "Unjoin";
            _context.Attach(Join_License_AssetDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var LicenseUpdate = await _context.License.FindAsync(Join_License_AssetDelete.License_LicenseID);
            LicenseUpdate.Status = "InStock";
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_License = await _context.Update_License.ToListAsync();
            
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Join_License_Asset = await _context.Join_License_Asset.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            License = await _context.License.FirstOrDefaultAsync(m => m.LicenseID == id);

            if (License == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
