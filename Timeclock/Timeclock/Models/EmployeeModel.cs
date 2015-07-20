using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class EmployeeModel
    {
        [Key]
        public string firstName { get; set;}
        public string lastName { get; set; }
        public int idNumber { get; set; }
        public bool active { get; set; }
    }
}