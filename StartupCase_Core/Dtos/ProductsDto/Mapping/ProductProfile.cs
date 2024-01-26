using AutoMapper;
using StartupCase_Core.Dtos.ProductsDto.Request;
using StartupCase_Core.Dtos.ProductsDto.Response;
using StartupCase_Entities.Entities;

namespace StartupCase_Core.Dtos.ProductsDto.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Products, ProductResponse>().ReverseMap();
            CreateMap<Products, ProductRequest>().ReverseMap();
        }
    }
}
