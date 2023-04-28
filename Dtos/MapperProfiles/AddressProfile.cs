using AutoMapper;
using StandardizeAddress.BLL.Models;

namespace StandardizeAddress.Dtos.MapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressInfoModel, AddressDto>()
                .ForMember(dest => dest.IsCheckRequired, opt => opt.MapFrom(src => (src.Qc == 1 || src.Qc == 3)));
        }
    }
}