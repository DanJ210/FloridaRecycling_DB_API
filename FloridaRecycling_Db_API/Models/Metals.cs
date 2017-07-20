using System;
using System.Collections.Generic;

namespace FloridaRecycling_Db_API.Models
{
    public partial class Metals
    {
        public int CommodityId { get; set; }
        public string CommodityName { get; set; }
        public string CommodityPrice { get; set; }
        public decimal? CustomerWeight { get; set; }
        public decimal? Total { get; set; }
        public string CommodityImageUrl { get; set; }
        public string CommodityDescription { get; set; }
        public string Header { get; set; }
    }
}
