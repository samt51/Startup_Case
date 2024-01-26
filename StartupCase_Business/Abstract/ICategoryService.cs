using StartupCase_Core.Dtos.CategoryDto.Request;
using StartupCase_Core.Dtos.CategoryDto.Response;

namespace StartupCase_Business.Abstract
{
    public interface ICategoryService
    {
        public List<CategoryResponse> GetAll();
        public CategoryResponse GetById(int id);
        public CategoryResponse Create(CategoryRequest request);
        public CategoryResponse Update(CategoryRequest request);
        public CategoryResponse Delete(CategoryRequest request);
    }
}
