namespace StandardizeAddress.BLL.Models
{
    internal class AddressInfo
    {
        public string source { get; set; }

        public string result { get; set; }

        public string postal_code { get; set; }

        public string country { get; set; }

        public string federal_district { get; set; }

        public string region_with_type { get; set; }

        public string region_type { get; set; }

        public string region_type_full { get; set; }

        public string region { get; set; }

        public object area_fias_id { get; set; }

        public object area_kladr_id { get; set; }

        public object area_with_type { get; set; }

        public object area_type { get; set; }

        public object area_type_full { get; set; }

        public object area { get; set; }

        public object city_fias_id { get; set; }

        public object city_kladr_id { get; set; }

        public object city_with_type { get; set; }

        public object city_type { get; set; }

        public object city_type_full { get; set; }

        public object city { get; set; }

        public string city_area { get; set; }

        public string city_district_with_type { get; set; }

        public string city_district_type { get; set; }

        public string city_district_type_full { get; set; }

        public string city_district { get; set; }

        public object settlement_fias_id { get; set; }

        public object settlement_kladr_id { get; set; }

        public object settlement_with_type { get; set; }

        public object settlement_type { get; set; }

        public object settlement_type_full { get; set; }

        public object settlement { get; set; }

        public string street_fias_id { get; set; }

        public string street_kladr_id { get; set; }

        public string street_with_type { get; set; }

        public string street_type { get; set; }

        public string street_type_full { get; set; }

        public string street { get; set; }

        public string house_type { get; set; }

        public string house_type_full { get; set; }

        public string house { get; set; }

        public object block_type { get; set; }

        public object block_type_full { get; set; }

        public object block { get; set; }

        public object entrance { get; set; }

        public object floor { get; set; }

        public int qc_house { get; set; }

        public int qc { get; set; }
    }
}