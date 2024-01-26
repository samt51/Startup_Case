using StartupCase_Core.Dtos.CategoryDto.Response;

namespace StartupCase_Core.Dtos.ProductsDto.Response
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public CategoryResponse CategoryResponse{ get; set; }

    }
}
