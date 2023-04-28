using System.Text.Json.Serialization;

namespace StandardizeAddress.BLL.Models
{
    public sealed class AddressInfoModel
    {
        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonPropertyName("result")]
        public string? Result { get; set; }

        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("federal_district")]
        public string? FederalDistrict { get; set; }

        [JsonPropertyName("region_with_type")]
        public string? RegionWithType { get; set; }

        [JsonPropertyName("region_type")]
        public string? RegionType { get; set; }

        [JsonPropertyName("region_type_full")]
        public string? RegionTypeFull { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("area_with_type")]
        public object? AreaWithType { get; set; }

        [JsonPropertyName("area_type")]
        public object? AreaType { get; set; }

        [JsonPropertyName("area_type_full")]
        public object? AreaTypeFull { get; set; }

        [JsonPropertyName("area")]
        public object? Area { get; set; }

        [JsonPropertyName("city_with_type")]
        public object? CityWithType { get; set; }

        [JsonPropertyName("city_type")]
        public object? CityType { get; set; }

        [JsonPropertyName("city_type_full")]
        public object? CityTypeFull { get; set; }

        [JsonPropertyName("city")]
        public object? City { get; set; }

        [JsonPropertyName("city_area")]
        public string? CityArea { get; set; }

        [JsonPropertyName("city_district_with_type")]
        public string? CityDistrictWithType { get; set; }

        [JsonPropertyName("city_district_type")]
        public string? CityDistrictType { get; set; }

        [JsonPropertyName("city_district_type_full")]
        public string? CityDistrictTypeFull { get; set; }

        [JsonPropertyName("city_district")]
        public string? CityDistrict { get; set; }

        [JsonPropertyName("settlement_with_type")]
        public object? SettlementWithType { get; set; }

        [JsonPropertyName("settlement_type")]
        public object? SettlementType { get; set; }

        [JsonPropertyName("settlement_type_full")]
        public object? SettlementTypeFull { get; set; }

        [JsonPropertyName("settlement")]
        public object? Settlement { get; set; }

        [JsonPropertyName("street_with_type")]
        public string? StreetWithType { get; set; }

        [JsonPropertyName("street_type")]
        public string? StreetType { get; set; }

        [JsonPropertyName("street_type_full")]
        public string? StreetTypeFull { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("house_type")]
        public string? HouseType { get; set; }

        [JsonPropertyName("house_type_full")]
        public string? HouseTypeFull { get; set; }

        [JsonPropertyName("house")]
        public string? House { get; set; }

        [JsonPropertyName("block_type")]
        public object? BlockType { get; set; }

        [JsonPropertyName("block_type_full")]
        public object? BlockTypeFull { get; set; }

        [JsonPropertyName("block")]
        public object? Block { get; set; }

        [JsonPropertyName("entrance")]
        public object? Entrance { get; set; }

        [JsonPropertyName("floor")]
        public object? Floor { get; set; }

        [JsonPropertyName("qc")]
        public int Qc { get; set; }
    }
}