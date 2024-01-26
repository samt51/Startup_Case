using StartupCase_Entities.Common;

namespace StartupCase_Entities.Entities
{
    public class ProductFilterValues:CommondClass
    {
        public string Value { get; set; }
        public int ProductFilterId { get; set; }
        public ProductFilter ProductFilter { get; set; }
    }
}
