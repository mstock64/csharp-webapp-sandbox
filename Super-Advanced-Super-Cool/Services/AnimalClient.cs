using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Super_Advanced_Super_Cool.Services
{
    public class AnimalClient: IAnimalClient
    {
        private readonly HttpClient _httpClient;
        public AnimalClient()
        {
            _httpClient = new HttpClient();

        }
        public HttpResponseMessage? GetImage(string type) { return  _httpClient.GetAsync($"https://api.the{type}api.com/v1/images/search").Result; }

    }
}
