using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    [Table(name: "articles")]
    [Index("Code",IsUnique =true,Name ="article_unique")]
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [MaxLength(40)]
        public string Description { get; set; }
        [Column(name: "amount_met")]
        public decimal? AmountMet { get; set; }
        public decimal Price { get; set; }
        [Column(name: "article_category_id")]
        public int ArticleCategoryId { get; set; }
        [ForeignKey("ArticleCategoryId")]
        public virtual ArticleCategory ArticleCategory { get; set; }
    }
}
