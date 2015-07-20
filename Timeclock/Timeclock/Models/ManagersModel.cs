using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class ManagersModel
    {
        [Key]
        [Display(Name = "Manager Name")]
        public string managerName { get; set; }
        [Display(Name = "Title")]
        public string managerTitle { get; set; }
    }
}