using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Super_Advanced_Super_Cool.Services
{
    public class AnimalService
    {
        public IAnimalClient _animalClient;
        public AnimalService(IAnimalClient animalClient)
        {
            _animalClient = animalClient;
        }
        public List<AnimalImage> GetAnimalImage(string animalType)
        {

            var result = _animalClient.GetImage(animalType).Content;
            var data = result.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<AnimalImage>>(data);
        }
    }
}
