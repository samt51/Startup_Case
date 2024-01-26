namespace Backend_Business.ClientConnection
{
    public class HttpClientCall : IHttpClientCall
    {
        public async Task<string> GetClient(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // GET isteği yap
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Başarılı yanıtı kontrol et
                    if (response.IsSuccessStatusCode)
                    {
                        // Yanıt içeriğini oku
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {
                        return response.StatusCode.ToString();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
