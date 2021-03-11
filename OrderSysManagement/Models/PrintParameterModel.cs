using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Models
{
    public class PrintParameterModel
    {
        [MaxLength(45)]
        public string PrinterName { get; set; }
    }
}
