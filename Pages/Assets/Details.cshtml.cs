using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Assets
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int Deatailid { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DeletidEmp { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DeletidLi { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DeletidNet { get; set; }


        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Model> Models { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public Asset Asset { get; set; }
        public IList<Join_Asset_Emp> Join_Asset_Emp { get; set; }
        public IList<Join_Asset_Asset> Join_Asset_Asset { get; set; }
        public Join_Asset_Asset Join_Asset_AssetDelete { get; set; }
        public Join_Asset_Emp Join_Asset_EmpDelete { get; set; }
        public Join_License_Asset Join_License_AssetDelete { get; set; }
        public Join_Network_Asset Join_Network_AssetDelete { get; set; }
        public IList<Join_License_Asset> Join_License_Asset { get; set; }
        public IList<Join_Network_Asset> Join_Network_Asset { get; set; }
        public IList<License> License { get; set; }
        public IList<Employee> Employee { get; set; }
        public IList<Network> Network { get; set; }
        public IList<Asset> Asset1 { get; set; }
        public IList<Update_Asset> Update_Asset { get; set; }
        public IList<Category> Category { get; set; }
        public IList<Brand> Brand { get; set; }
        public async Task<IActionResult> OnPostDeleteAsAsync()
        {
            if (Deletid == 0)
            {
                return NotFound();
            }

            Join_Asset_AssetDelete = await _context.Join_Asset_Asset.FindAsync(Deletid);
            Join_Asset_AssetDelete.Status = "Unjoin";

            _context.Attach(Join_Asset_AssetDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var AssetUpdate = await _context.Asset.FindAsync(Join_Asset_AssetDelete.AssetSon);
            AssetUpdate.Status = "InStock";
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostDeleteLiAsync()
        {
            if (DeletidLi == 0)
            {
                return NotFound();
            }

            Join_License_AssetDelete = await _context.Join_License_Asset.FindAsync(DeletidLi);
            Join_License_AssetDelete.Status = "Unjoin";

            _context.Attach(Join_Asset_AssetDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var LicenseUpdate = await _context.License.FindAsync(Join_License_AssetDelete.License_LicenseID);
            LicenseUpdate.Status = "InStock";
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostDeleteEmpAsync()
        {
            if (DeletidEmp == 0)
            {
                return NotFound();
            }

            Join_Asset_EmpDelete = await _context.Join_Asset_Emp.FindAsync(DeletidEmp);
            Join_Asset_EmpDelete.Status = "Unjoin";

            _context.Attach(Join_Asset_EmpDelete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var AssetUpdate = await _context.Asset.FindAsync(Join_Asset_EmpDelete.Asset_AssetID);
            AssetUpdate.Status = "InStock";
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
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
            Brand = await _context.Brand.ToListAsync();
            Category = await _context.Category.ToListAsync();
            Update_Asset = await _context.Update_Asset.ToListAsync();
            License = await _context.License.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Network = await _context.Network.ToListAsync();
            Asset1 = await _context.Asset.ToListAsync();
            Join_Asset_Emp = await _context.Join_Asset_Emp.ToListAsync();
            Join_Asset_Asset = await _context.Join_Asset_Asset.ToListAsync();
            Join_License_Asset = await _context.Join_License_Asset.ToListAsync();
            Join_Network_Asset = await _context.Join_Network_Asset.ToListAsync();
            Supplier = await _context.Supplier.ToListAsync();
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Models = await _context.Model.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();



            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Asset.FirstOrDefaultAsync(m => m.AssetID == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
