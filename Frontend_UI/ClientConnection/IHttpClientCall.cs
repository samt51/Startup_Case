namespace Frontend_UI.ClientConnection
{
    public interface IHttpClientCall
    {
        public Task<string> GetClient(string url);
    }
}
