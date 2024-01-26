using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.ProductFilterDto.Response;
using StartupCase_DataAccess.Abstract;

namespace StartupCase_Business.Concrete
{
    public class ProductFilterManager : IProductFilterService
    {
        public IProductFilterDal productFilterDal;

        public ProductFilterManager(IProductFilterDal productFilterDal)
        {
            this.productFilterDal = productFilterDal;
        }

        public List<ProductFilterResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductFilterResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductFilterResponse> GetFilterAndValueByCategoryId(int categoryid)
        {
            return this.productFilterDal.GetFilterAndValueByCategoryId(categoryid);
        }
    }
}
