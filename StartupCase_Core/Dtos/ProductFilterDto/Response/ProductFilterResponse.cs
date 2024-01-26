using StartupCase_Core.Dtos.ProductFilterValueDto.Response;

namespace StartupCase_Core.Dtos.ProductFilterDto.Response
{
    public class ProductFilterResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductFilterValueResponse> productFilterValueResponses { get; set; }
    }
}
