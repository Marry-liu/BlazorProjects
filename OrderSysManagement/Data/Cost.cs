using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    [Table(name: "costs")]
    public class Cost
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(name: "cost_description")]
        public string Cost_Description { get; set; }
        [Column(name: "cost_date")]
        public DateTime Cost_Date { get; set; }
        [Column(name: "cost_price")]
        public decimal Cost_Price { get; set; }
    }
}
