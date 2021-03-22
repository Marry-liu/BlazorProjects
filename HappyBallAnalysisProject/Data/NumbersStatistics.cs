using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Data
{
    [Table(name: "double_chrom_red_numbers_statistics")]
    [Index("TypeId", "Number", IsUnique = true, Name = "uniq_number_statistics")]
    public class NumbersStatistics
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Number { get; set; }

        public int Times { get; set; }
        [Column(name: "type_id")]
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual NumberType NumberType { get; set; }
    }
}
