using Backend_Business.Category.Model.Response;
using Backend_Business.ClientConnection;
using MediatR;

namespace Backend_Business.Category.Queries.GetCategory
{
    public class GetCategoriaQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoriaResponse>>
    {
        private readonly IHttpClientCall httpClientCall;

        public GetCategoriaQueryHandler(IHttpClientCall httpClientCall)
        {
            this.httpClientCall = httpClientCall;
        }

        public async Task<List<GetCategoriaResponse>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            string url = "";

            var response = await httpClientCall.GetClient(url);

            return null;
        }
    }
}
