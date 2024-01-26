using StartupCase_Entities.Common;

namespace StartupCase_Entities.Entities
{
    public class Products : CommondClass
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Categories categories { get; set; }
    }
}
