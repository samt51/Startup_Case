using StartupCase_Core.Dtos.ProductFilterDto.Response;

namespace StartupCase_Business.Abstract
{
    public interface IProductFilterService
    {
        public List<ProductFilterResponse> GetAll();
        public ProductFilterResponse GetById(int id);
        public List<ProductFilterResponse> GetFilterAndValueByCategoryId(int categoryid);


    }
}
