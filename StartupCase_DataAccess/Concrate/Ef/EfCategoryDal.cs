using StartupCase_DataAccess.Abstract;
using StartupCase_DataAccess.Concrate.Context;
using StartupCase_Entities.Entities;

namespace StartupCase_DataAccess.Concrate.Ef
{
    public class EfCategoryDal : RepositoryDal<Categories, DataContext>, ICategoryDal
    {
    }
}
