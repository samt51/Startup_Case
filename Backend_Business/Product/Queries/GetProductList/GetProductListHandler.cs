using Backend_Business.ClientConnection;
using Backend_Business.Product.Model.Response;
using MediatR;
using Newtonsoft.Json;

namespace Backend_Business.Product.Queries.GetProductList
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<GetProductListResponse>>
    {
        private readonly IHttpClientCall _httpClientCall;

        public GetProductListHandler(IHttpClientCall httpClientCall)
        {
            _httpClientCall = httpClientCall;
        }

        public async Task<List<GetProductListResponse>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var json = await _httpClientCall.GetClient("http://localhost:5133/Product/GetAll");

            var data = JsonConvert.DeserializeObject<List<GetProductListResponse>>(json);
            return data;
        }
    }
}