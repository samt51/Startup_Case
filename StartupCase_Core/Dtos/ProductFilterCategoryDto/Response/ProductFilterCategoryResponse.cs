using StartupCase_Core.Dtos.CategoryDto.Response;
using StartupCase_Core.Dtos.ProductFilterDto.Response;

namespace StartupCase_Core.Dtos.ProductFilterCategoryDto.Response
{
    public class ProductFilterCategoryResponse
    {
        public ProductFilterResponse ProductFilterResponse { get; set; }

        public CategoryResponse CategoryResponse { get; set; }
    }
}
