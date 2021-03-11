using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Models
{
    public class TransationModel
    {
        public List<ArticleModel> ArticleModels { get; set; }
        public string TableNum { get; set; }
        public int TransNum { get; set; }
    }
}
