namespace StartupCase_Entities.Entities
{
    public class ProductFilterCategory
    {
        public int ProductFilterId { get; set; }
        public ProductFilter ProductFilter { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}
