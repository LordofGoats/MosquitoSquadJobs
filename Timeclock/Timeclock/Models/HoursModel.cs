using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class HoursModel
    {
        [Key]
        public int hours { get; set; }
    }
}