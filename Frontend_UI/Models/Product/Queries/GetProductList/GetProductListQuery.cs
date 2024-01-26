using Frontend_UI.Models.Product.Model.Response;
using MediatR;

namespace Frontend_UI.Models.Product.Model.Queries.GetProductList
{
    public class GetProductListQuery : IRequest<List<GetProductListResponse>>
    {
        public GetProductListQuery()
        {
            
        }
    }
}
