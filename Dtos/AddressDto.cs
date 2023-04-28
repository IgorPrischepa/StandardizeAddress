namespace StandardizeAddress.Dtos
{
    internal sealed class AddressDto
    {
        public string? Source { get; set; }

        public string? Result { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

        public string? FederalDistrict { get; set; }

        public string? RegionWithType { get; set; }

        public string? RegionType { get; set; }

        public string? RegionTypeFull { get; set; }

        public string? Region { get; set; }

        public object? AreaWithType { get; set; }

        public object? AreaType { get; set; }

        public object? AreaTypeFull { get; set; }

        public object? Area { get; set; }

        public object? CityWithType { get; set; }

        public object? CityType { get; set; }

        public object? CityTypeFull { get; set; }

        public object? City { get; set; }

        public string? CityArea { get; set; }

        public string? CityDistrictWithType { get; set; }

        public string? CityDistrictType { get; set; }

        public string? CityDistrictTypeFull { get; set; }

        public string? CityDistrict { get; set; }

        public object? SettlementWithType { get; set; }

        public object? SettlementType { get; set; }

        public object? SettlementTypeFull { get; set; }

        public object? Settlement { get; set; }

        public string? StreetWithType { get; set; }

        public string? StreetType { get; set; }

        public string? StreetTypeFull { get; set; }

        public string? Street { get; set; }

        public string? HouseType { get; set; }

        public string? HouseTypeFull { get; set; }

        public string? House { get; set; }

        public object? BlockType { get; set; }

        public object? BlockTypeFull { get; set; }

        public object? Block { get; set; }

        public object? Entrance { get; set; }

        public object? Floor { get; set; }

        public bool IsCheckRequired { get; set; }
    }
}