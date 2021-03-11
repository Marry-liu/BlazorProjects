using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    [Table(name: "transactions")]
    public class Transation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(name: "table_num")]
        public int? TableNum { get; set; }
        [Column(name: "trans_num")]
        public int TransNum { get; set; }
        [Column(name: "total_amount")]
        public decimal? TotalAmount { get; set; }
        [Column(name: "trans_date")]
        public DateTime TransDate { get; set; }
    }
}
