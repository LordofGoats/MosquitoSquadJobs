using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timeclock.Models
{
    internal class EmployeeView
    {

        public string firstName { get; set;}
        public string lastName { get; set; }
        public int idNumber { get; set; }
        public bool active { get; set; }
    }
}