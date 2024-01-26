using AutoMapper;
using StartupCase_Core.Dtos.ProductFilterCategoryDto.Response;
using StartupCase_Entities.Entities;

namespace StartupCase_Core.Dtos.ProductFilterCategoryDto.Mapping
{
    public class ProductFilterCategoryProfile : Profile
    {
        public ProductFilterCategoryProfile()
        {
            CreateMap<ProductFilterCategory, ProductFilterCategoryResponse>().ForMember(dest => dest.ProductFilterResponse, opt => opt.MapFrom(src => src.ProductFilter)).
                ForMember(dest => dest.CategoryResponse, opt => opt.MapFrom(src => src.Categories)).ReverseMap();

            CreateMap<List<ProductFilterCategory>, List<ProductFilterCategoryResponse>>();
        }
    }
}
