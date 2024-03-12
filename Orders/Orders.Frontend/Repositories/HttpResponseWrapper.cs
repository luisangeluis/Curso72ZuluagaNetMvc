namespace Orders.Frontend.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpActionResponseMessage)
        {
            Response = response;
            Error = error;
            HttpActionResponseMessage = httpActionResponseMessage;
        }

        public T? Response { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpActionResponseMessage { get; }

        public async Task<string?> 
    }
}