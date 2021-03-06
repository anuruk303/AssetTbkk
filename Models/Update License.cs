﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Update_License
    {
        [Key]
        public int UpdateLicenseID { get; set; }
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "LicenseName")]
        public string LicenseName { get; set; }
        [Required]
        [Display(Name = "SoftewareName")]
        public string SoftewareName { get; set; }
        [Required]
        [Display(Name = "PurchaseDate")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        [Required]
        [Display(Name = "InstallDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime InstallDate { get; set; }
        [Required]
        [Display(Name = "ExpireDate")]
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        [Required]
        [Display(Name = "PONumber")]
        public string PONumber { get; set; }
        [Required]
        [Display(Name = "Attachfiles")]
        public string Attachfiles { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Required]
        [Display(Name = "Employee")]
        public int Employee { get; set; }
        public int Model_ModelID { get; set; }

        public int Supplier_SupplierID { get; set; }

        public int Department_DepartmentID { get; set; }

        public int Company_CompanyID { get; set; }

        public int License_LicenseID { get; set; }
    }
}
