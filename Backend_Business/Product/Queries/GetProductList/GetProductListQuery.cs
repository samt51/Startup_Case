using Backend_Business.Product.Model.Response;
using MediatR;

namespace Backend_Business.Product.Queries.GetProductList
{
    public class GetProductListQuery : IRequest<List<GetProductListResponse>>
    {
        public GetProductListQuery()
        {
            
        }
    }
}
