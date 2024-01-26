using Backend_Business.ProductFilter.Model.Response;
using MediatR;

namespace Backend_Business.ProductFilter.Queries.GetFilterAndValueByCategoryId
{
    public class GetFilterAndValueByCategoryIdQuery : IRequest<List<GetFilterAndValueByCategoryIdResponse>>
    {
        public GetFilterAndValueByCategoryIdQuery(int categoryid)
        {
            this.CategoryId = categoryid;
        }
        public int CategoryId { get; }
    }
}
