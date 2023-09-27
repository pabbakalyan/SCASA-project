﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCASA.Models.ModelClasses
{
    public class CompanyDisplayModel
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string WarehouseAddress { get; set; }
        public string ShowroomAddress { get; set; }
        public string CEOName { get; set; }
        public string CEOEmail { get; set; }
        public string CEOContactNumber { get; set; }
        public string WarehousePhoneNumbers { get; set; }
        public string ShowroomPhoneNumbers { get; set; }
        public string WarehouseEmail { get; set; }
        public string ShowroomEmail { get; set; }
        public bool? IsDeleted { get; set; }
        public string GSTIN { get; set; }
        public string Code { get; set; }
    }
}
