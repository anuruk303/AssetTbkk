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

namespace tbkk_AC.Pages.Licenses
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int Deletid { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SoftewareName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PONumber { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SupplierID { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DepartmentID { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CompanyID { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Status { get; set; }



        public IList<License> License { get; set; }
        public License LicenseDelete { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public async Task OnGetAsync()
        {
            Supplier = await _context.Supplier.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            var Licenses = from m in _context.License
                           select m;
            if (!string.IsNullOrEmpty(SoftewareName))
            {
                Licenses = Licenses.Where(s => s.SoftewareName.Contains(SoftewareName));
            }
            if (!string.IsNullOrEmpty(PONumber))
            {
                Licenses = Licenses.Where(s => s.PONumber.Contains(PONumber));
            }
            if (!string.IsNullOrEmpty(SupplierID))
            {
                Licenses = Licenses.Where(s => s.Supplier_SupplierID == Int64.Parse(SupplierID));
            }
            if (!string.IsNullOrEmpty(DepartmentID))
            {
                Licenses = Licenses.Where(s => s.Department_DepartmentID == Int64.Parse(DepartmentID));
            }
            if (!string.IsNullOrEmpty(CompanyID))
            {
                Licenses = Licenses.Where(s => s.Company_CompanyID == Int64.Parse(CompanyID));
            }
            if (!string.IsNullOrEmpty(Status))
            {
                Licenses = Licenses.Where(s => s.Status.Contains(Status));
            }

            License = await Licenses.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
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
                        _context.License.AddRange(
                                            new License
                                            {
                                                LicenseName = values[0],
                                                SoftewareName = values[1],
                                                PurchaseDate = DateTime.Parse(values[2]),
                                                InstallDate = DateTime.Parse(values[3]),
                                                ExpireDate = DateTime.Parse(values[4]),
                                                PONumber = values[5],
                                                Attachfiles = values[6],
                                                Note = values[7],
                                                Status = "InStock",
                                                Supplier_SupplierID = Int32.Parse(values[8]),
                                                Department_DepartmentID = Int32.Parse(values[9]),
                                                Company_CompanyID = Int32.Parse(values[10])

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

        private int Parse(string v)
        {
            throw new NotImplementedException();
        }
    }
}