using StartupCase_Core.Dtos.ProductsDto.Request;
using StartupCase_Core.Dtos.ProductsDto.Response;

namespace StartupCase_Business.Abstract
{
    public interface IProductService
    {
        public List<ProductResponse> GetAll();
        public ProductResponse GetById(int id);
        public ProductResponse Create(ProductRequest request);
        public ProductResponse Update(ProductRequest request);
        public ProductResponse Delete(ProductRequest request);
    }
}
