using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Models
{
    public class WiningRecordModel
    {
        [Required]
        [MaxLength(50)]
        public string Period { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int RedNumber1 { get; set; }
        [Required]
        public int RedNumber2 { get; set; }
        [Required]
        public int RedNumber3 { get; set; }
        [Required]
        public int RedNumber4 { get; set; }
        [Required]
        public int RedNumber5 { get; set; }
        [Required]
        public int RedNumber6 { get; set; }
        [Required]
        public int BlueNumber { get; set; }
        public int BlueNumber1 { get; set; }
        public int? TypeId { get; set; }
    }
}
