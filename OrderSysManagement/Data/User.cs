using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    [Table(name: "users")]
    [Index("Code", IsUnique = true)]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [MaxLength(50)]
        public string Pwd { get; set; }
        public string Name { get; set; }
        [Column(name: "create_time")]
        public DateTime? CreateTime { get; set; }
        [Column(name: "last_update_time")]
        public DateTime? LastUpdateTime { get; set; }
        [Column(name: "user_type_id")]
        public int UserTypeId { get; set; }
        [ForeignKey(name: "UserTypeId")]
        public virtual UserType UserType { get; set; }
    }
}
