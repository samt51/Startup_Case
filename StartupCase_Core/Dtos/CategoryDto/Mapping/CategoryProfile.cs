using AutoMapper;
using StartupCase_Core.Dtos.CategoryDto.Response;
using StartupCase_Entities.Entities;

namespace StartupCase_Core.Dtos.CategoryDto.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Categories, CategoryResponse>().ForMember(dest => dest.productResponses, opt => opt.MapFrom(src => src.Products)).
                ForMember(dest => dest.productFilterCategoryResponses, opt => opt.MapFrom(src => src.ProductFilterCategories)).ReverseMap();
        }
    }
}
