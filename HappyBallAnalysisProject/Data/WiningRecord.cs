using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Data
{
    [Table(name: "winning_records")]
    [Index("Date", "TypeId", IsUnique = true, Name = "uniq_date")]
    public class WiningRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Period { get; set; }
        public DateTime Date { get; set; }
        [Column(name: "red_number1")]
        public int RedNumber1 { get; set; }
        [Column(name: "red_number2")]
        public int RedNumber2 { get; set; }
        [Column(name: "red_number3")]
        public int RedNumber3 { get; set; }
        [Column(name: "red_number4")]
        public int RedNumber4 { get; set; }
        [Column(name: "red_number5")]
        public int RedNumber5 { get; set; }
        [Column(name: "red_number6")]
        public int RedNumber6 { get; set; }
        [Column(name: "blue_number")]
        public int BlueNumber { get; set; }
        [Column(name: "blue_number1")]
        public int BlueNumber1 { get; set; }
        public string Remark { get; set; }
        [Column(name: "type_id")]
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual NumberType NumberType { get; set; }
    }
}
