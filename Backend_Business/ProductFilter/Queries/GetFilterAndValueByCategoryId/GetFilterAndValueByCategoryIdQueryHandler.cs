using Backend_Business.ClientConnection;
using Backend_Business.ProductFilter.Model.Response;
using MediatR;
using Newtonsoft.Json;
namespace Backend_Business.ProductFilter.Queries.GetFilterAndValueByCategoryId
{
    public class GetFilterAndValueByCategoryIdQueryHandler : IRequestHandler<GetFilterAndValueByCategoryIdQuery, List<GetFilterAndValueByCategoryIdResponse>>
    {
        private readonly IHttpClientCall _httpClientCall;
        public GetFilterAndValueByCategoryIdQueryHandler(IHttpClientCall httpClientCall)
        {
            _httpClientCall = httpClientCall;
        }
        public async Task<List<GetFilterAndValueByCategoryIdResponse>> Handle(GetFilterAndValueByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            //The link addresses here are taken from appsettings, but I get it like this to finish
            var json = await _httpClientCall.GetClient("http://localhost:5133/ProductFilter/GetFilterAndValueByCategoryId/" + request.CategoryId);

            var data = JsonConvert.DeserializeObject<List<GetFilterAndValueByCategoryIdResponse>>(json);
            return data;
        }
    }
}
