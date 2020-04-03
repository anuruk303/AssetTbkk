﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public DetailsModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        public IList<Company> Company { get; set; }
        public IList<Department> Department { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DeletidEmp { get; set; }
        public IList<EmployeeType> EmployeeType { get; set; }
        public IList<Location> Location { get; set; }
        public IList<Position> Position { get; set; }
        public IList<Join_Asset_Emp> Join_Asset_Emp { get; set; }
        public Join_Asset_Emp Join_Asset_EmpDelete { get; set; }
        public IList<Asset> Asset { get; set; }
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
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Company = await _context.Company.ToListAsync();
            Department = await _context.Department.ToListAsync();
            EmployeeType = await _context.EmployeeType.ToListAsync();
            Location = await _context.Location.ToListAsync();
            Position = await _context.Position.ToListAsync();
            Join_Asset_Emp = await _context.Join_Asset_Emp.ToListAsync();
            Asset = await _context.Asset.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);


            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
