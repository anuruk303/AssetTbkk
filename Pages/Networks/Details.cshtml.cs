using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Networks
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int DeletidNet { get; set; }
        public Network Network { get; set; }
        public IList<Asset> Asset { get; set; }
        public IList<Join_Network_Asset> Join_Network_Asset { get; set; }
        public Join_Network_Asset Join_Network_AssetDelete { get; set; }
        public IList<Update_Network> Update_Network { get; set; }
        public async Task<IActionResult> OnPostDeleteNetAsync()
        {
            if (DeletidNet == 0)
            {
                return NotFound();
            }

            Join_Network_AssetDelete = await _context.Join_Network_Asset.FindAsync(DeletidNet);
            Join_Network_AssetDelete.Status = "Unjoin";

            _context.Attach(Join_Network_AssetDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Update_Network = await _context.Update_Network.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
            Join_Network_Asset = await _context.Join_Network_Asset.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Network = await _context.Network.FirstOrDefaultAsync(m => m.NetworkID == id);

            if (Network == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
