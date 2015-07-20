using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class CompanyModel
    {
        [Key]
        public string companyName { get; set; }
        public int companyNumber { get; set; }
        public string companyDescription { get; set; }
    }
}