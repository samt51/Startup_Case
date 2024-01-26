using StartupCase_Core.Dtos.ProductFilterCategoryDto.Response;
using StartupCase_Core.Dtos.ProductsDto.Response;

namespace StartupCase_Core.Dtos.CategoryDto.Response
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductResponse> productResponses { get; set; }
        public List<ProductFilterCategoryResponse> productFilterCategoryResponses { get; set; }
    }
}
