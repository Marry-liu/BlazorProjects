using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using OrderSysManagement.Service;

namespace OrderSysManagement.Models
{
    public class ArticleCategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "类名必填")]
        public string Description { get; set; }
    }
    public enum DiscountCategoryDescription
    {
        金额折扣,
        百分比折扣,
    }
}
