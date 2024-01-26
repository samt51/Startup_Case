using AutoMapper;
using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.CategoryDto.Request;
using StartupCase_Core.Dtos.CategoryDto.Response;
using StartupCase_Core.Dtos.ProductsDto.Response;
using StartupCase_DataAccess.Abstract;
using StartupCase_DataAccess.Concrate.Ef;

namespace StartupCase_Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal categoryDal;
        public IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            this.categoryDal = categoryDal;
            this._mapper = mapper;
        }

        public CategoryResponse Create(CategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public CategoryResponse Delete(CategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public List<CategoryResponse> GetAll()
        {
            return _mapper.Map<List<CategoryResponse>>(categoryDal.GetAll());
        }

        public CategoryResponse GetById(int id)
        {
            return _mapper.Map<CategoryResponse>(categoryDal.GetById(id));
        }

        public CategoryResponse Update(CategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
