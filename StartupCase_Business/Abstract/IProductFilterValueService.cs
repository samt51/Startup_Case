using StartupCase_Core.Dtos.CategoryDto.Response;
using StartupCase_Core.Dtos.ProductFilterValueDto.Response;

namespace StartupCase_Business.Abstract
{
    public interface IProductFilterValueService
    {
        public List<ProductFilterValueResponse> GetAll();
        public ProductFilterValueResponse GetById(int id);
    }
}
