using Frontend_UI.Models.ProductFilter.Model.Response;
using MediatR;

namespace Frontend_UI.Models.ProductFilter.Model.Queries.GetFilterAndValueByCategoryId
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
