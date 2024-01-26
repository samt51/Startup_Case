using StartupCase_Core.Dtos.ProductFilterDto.Response;
using StartupCase_Entities.Entities;

namespace StartupCase_DataAccess.Abstract
{
    public interface IProductFilterDal : IRepository<ProductFilter>
    {
        public List<ProductFilterResponse> GetFilterAndValueByCategoryId(int categoryid);
    }
}
