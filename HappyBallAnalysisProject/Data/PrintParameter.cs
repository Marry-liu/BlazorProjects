using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Data
{
    [Table(name: "printParameters")]
    public class PrintParameter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(name: "printer_name")]
        [MaxLength(45)]
        public string PrinterName { get; set; }
    }
}
