using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Models
{
    public class CostModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "日期必填")]
        public DateTime Cost_Date { get; set; }
        [Required(ErrorMessage = "名称")]
        public string Cost_Description { get; set; }
        [Required(ErrorMessage = "价格")]
        public decimal Cost_Price { get; set; }
    }
}
