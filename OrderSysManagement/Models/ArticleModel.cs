using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Models
{
    public class ArticleModel
    {
        [Required(ErrorMessage = "商品代码必填")]
        [RegularExpression(@"^[1-9]+(\.\d+)?$", ErrorMessage = "代码不能小于0")]
        [Key]
        public int Code { get; set; }

        [Required(ErrorMessage = "名称必填")]
        [MaxLength(40, ErrorMessage = "字符串长度不能大于40")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required(ErrorMessage = "类型必填")]
        public string ArticleCategoryId { get; set; }
        public string ArticleCategoryName { get; set; }
        //public ArticleCategory ArticleCategory { get; set; }
        public int Number { get; set; }
        public decimal? TotalPrice { get; set; }

        public decimal? AmountMet { get; set; }
    }
}
