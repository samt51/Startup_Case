using StartupCase_Entities.Common;

namespace StartupCase_Entities.Entities
{
    public class ProductFilter : CommondClass
    {
        public string Name { get; set; }
        public ICollection<ProductFilterValues> ProductFilterValues { get; set; }
        public ICollection<ProductFilterCategory> productFilterCategories { get; set; }

    }
}
