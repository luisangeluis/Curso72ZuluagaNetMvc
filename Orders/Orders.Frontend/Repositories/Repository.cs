using NPOI.SS.Formula.Functions;
using System.Text.Json;

namespace Orders.Frontend.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient _httpClient;

        //Esto para que sea capaz de Serializa o desserializar el objeto
        private JsonSerializerOptions _jsonDefaultOptions =>new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            var responseHttp = await _httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {

                var response = await UnserializeAnswer<T>(responseHttp);
            }
        }

        private Task<Task> UnserializeAnswer<T>(HttpResponseMessage responseHttp)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url)
        {
            throw new NotImplementedException();
        }
    }
}
