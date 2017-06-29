using System;
using System.Collections.Generic;

namespace FloridaRecycling_Db_API.Models
{
    public partial class Metals
    {
        public int CommodityId { get; set; }
        public string CommodityName { get; set; }
        public double CommodityPrice { get; set; }
        public double? CustomerWeight { get; set; }
        public double? Total { get; set; }
    }
}
