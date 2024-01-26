namespace Backend_Business.ClientConnection
{
    public interface IHttpClientCall
    {
        public Task<string> GetClient(string url);
    }
}
