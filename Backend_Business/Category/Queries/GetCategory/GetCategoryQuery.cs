using Backend_Business.Category.Model.Response;
using MediatR;

namespace Backend_Business.Category.Queries.GetCategory
{
    public class GetCategoryQuery: IRequest<List<GetCategoriaResponse>>
    {
        public GetCategoryQuery()
        {
            
        }
    }
}
