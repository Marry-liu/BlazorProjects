using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    [Table(name: "trans_articles")]
    [Index("TransactionId", "ArticleId", IsUnique = true,Name ="transaction_unique")]
    public class TransArticle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(name: "transaction_id")]
        public int TransactionId { get; set; }
        [Column(name: "article_id")]
        public int ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
        public decimal Qty { get; set; }
        [Column(name: "total_price")]
        public decimal? TotalPrice { get; set; }
        [ForeignKey("TransactionId")]
        public virtual Transation Transaction { get; set; }
    }
}
