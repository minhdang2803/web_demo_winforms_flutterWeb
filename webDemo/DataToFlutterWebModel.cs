using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webDemo
{
    internal class Data
    {
        [JsonProperty("TotalRecord")]
        public int? TotalRecord { get; set; }

        [JsonProperty("OSCSID")]
        public int? OSCSID { get; set; }

        [JsonProperty("ClearStockID")]
        public object ClearStockID { get; set; }

        [JsonProperty("StoreID")]
        public int? StoreID { get; set; }

        [JsonProperty("PID")]
        public int? PID { get; set; }

        [JsonProperty("ReferenceID")]
        public object ReferenceID { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("ProductID")]
        public string ProductID { get; set; }

        [JsonProperty("MaxQuantity")]
        public int? MaxQuantity { get; set; }

        [JsonProperty("OutputQuantity")]
        public object OutputQuantity { get; set; }

        [JsonProperty("VAT")]
        public int? VAT { get; set; }

        [JsonProperty("PriceAfterVAT")]
        public int? PriceAfterVAT { get; set; }

        [JsonProperty("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("CreatedUserName")]
        public object CreatedUserName { get; set; }

        [JsonProperty("CreatedFullName")]
        public object CreatedFullName { get; set; }

        [JsonProperty("DefectID")]
        public string DefectID { get; set; }

        [JsonProperty("MaxQuantityOrder")]
        public object MaxQuantityOrder { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryID { get; set; }

        [JsonProperty("CustomerMemberTypeID")]
        public int? CustomerMemberTypeID { get; set; }

        [JsonProperty("FixedQuantity")]
        public int? FixedQuantity { get; set; }

        [JsonProperty("StockQuantity")]
        public int? StockQuantity { get; set; }

        [JsonProperty("IsOnlineGift")]
        public bool? IsOnlineGift { get; set; }

        [JsonProperty("Version")]
        public int? Version { get; set; }

        [JsonProperty("BackgroundMobileFirst")]
        public string BackgroundMobileFirst { get; set; }

        [JsonProperty("BackgroundMobileSecond")]
        public object BackgroundMobileSecond { get; set; }
    }

    internal class BDLT1
    {

        [JsonProperty("PageName")]
        public string pageName { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }
    
    }
}
