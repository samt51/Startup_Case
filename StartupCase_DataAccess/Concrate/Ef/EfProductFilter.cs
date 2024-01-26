using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StartupCase_Core.Dtos.ProductFilterCategoryDto.Response;
using StartupCase_Core.Dtos.ProductFilterDto.Response;
using StartupCase_DataAccess.Abstract;
using StartupCase_DataAccess.Concrate.Context;
using StartupCase_Entities.Entities;

namespace StartupCase_DataAccess.Concrate.Ef
{
    public class EfProductFilter : RepositoryDal<ProductFilter, DataContext>, IProductFilterDal
    {
        private readonly IMapper mapper;

        public EfProductFilter(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<ProductFilterResponse> GetFilterAndValueByCategoryId(int categoryid)
        {
            var response = new List<ProductFilterResponse>();
            using (var context = new DataContext())
            {
                var filter = context.ProductFilterCategories.Include(x => x.ProductFilter)
                     .ThenInclude(x => x.productFilterCategories)
                     .ThenInclude(x => x.Categories)
                     .Where(x => x.CategoryId == categoryid).ToList();

                foreach (var category in filter)
                {
                    //If we expand here, we can bring the values ​​of these values
                    response.Add(new ProductFilterResponse { Id = category.ProductFilter.Id, Name = category.ProductFilter.Name });
                }




                return response;
            }
        }
    }
}
