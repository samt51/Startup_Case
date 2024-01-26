using StartupCase_Entities.Common;

namespace StartupCase_Entities.Entities
{
    public class Categories : CommondClass
    {
        public string Name { get; set; }
        public List<Products> Products { get; set; }

        public IList<ProductFilterCategory> ProductFilterCategories { get; set; }
    }
}
