using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.ProductsDto.Request;
using StartupCase_Core.Dtos.ProductsDto.Response;
using StartupCase_DataAccess.Abstract;

namespace StartupCase_Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public ProductResponse Create(ProductRequest request)
        {
            throw new NotImplementedException();
        }

        public ProductResponse Delete(ProductRequest request)
        {
            throw new NotImplementedException();
        }

        public List<ProductResponse> GetAll()
        {
            var data = this.productDal.GetAll(x => x.IsDeleted == false);

            //Normally, mapper is installed in the project, but since I got an error, I tried to do it myself.
            var rsp = data.Select(x => new ProductResponse
            {
                Description = x.Description,
                Name = x.Name,
                Price = x.Price,
            }).ToList();
            return rsp;
        }

        public ProductResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductResponse Update(ProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
