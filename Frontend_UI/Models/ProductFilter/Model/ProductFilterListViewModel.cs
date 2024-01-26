using Frontend_UI.Models.Product.Model.Response;

namespace Frontend_UI.Models.ProductFilter.Model
{
    public class ProductFilterListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<GetProductListResponse> getProductListResponses{ get; set; }
    }
}
