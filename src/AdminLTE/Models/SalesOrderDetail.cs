using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTE.Models
{
    public class SalesOrderDetail
    {
        public int sr { get; set; }
        public string ordertracknumber { get; set; }
        public int quantity { get; set; }
        public string productname { get; set; }
        public string specialoffer { get; set; }
        public double unitprice { get; set; }
        public double unitpricediscount { get; set; }
    }
}
