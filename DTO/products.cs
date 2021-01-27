using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class products
    {
        public string id_product { get; set; }
        public string name_product { get; set; }
        public string id_shop { get; set; }
        public decimal price_product { get; set; }
        public string pic_product { get; set; }
        public string id_pictures { get; set; }
        public int quantity { get; set; }
        public string id_category { get; set; }
        public string description { get; set; }
        public Nullable<int> rating { get; set; }


    }
}
