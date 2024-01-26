using Frontend_UI.ClientConnection;
using MediatR;
using Newtonsoft.Json;
using Frontend_UI.Models.ProductFilter.Model.Response;
namespace Frontend_UI.Models.ProductFilter.Model.Queries.GetFilterAndValueByCategoryId
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
            var json = await _httpClientCall.GetClient("http://localhost:5099/ProductFilter/getFilterAndValueByCategoryIdResponses/" + request.CategoryId);

            var data = JsonConvert.DeserializeObject<List<GetFilterAndValueByCategoryIdResponse>>(json);
            return data;
        }
    }
}
