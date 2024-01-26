using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.ProductFilterValueDto.Response;
using StartupCase_DataAccess.Abstract;

namespace StartupCase_Business.Concrete
{
    public class ProductFilterValueManager : IProductFilterValueService
    {
        public IProductFilterValueDal productFilterValueDal;

        public ProductFilterValueManager(IProductFilterValueDal productFilterValueDal)
        {
            this.productFilterValueDal = productFilterValueDal;
        }

        public List<ProductFilterValueResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductFilterValueResponse GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
