using Microsoft.AspNetCore.Mvc;
using Super_Advanced_Super_Cool.Models;
using Newtonsoft.Json;
using Super_Advanced_Super_Cool.Repository.Contracts;

namespace Super_Advanced_Super_Cool.Services
{
    public class AnimalService
    {
        public IAnimalClient _animalClient;
        public ITodoRepo _todoRepo;
        public AnimalService(IAnimalClient animalClient, ITodoRepo todoRepo)
        {
            _animalClient = animalClient;
            _todoRepo = todoRepo;
        }
        public List<AnimalImage> GetAnimalImage(string animalType)
        {

            var result = _animalClient.GetImage(animalType).Content;
            var data = result.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<AnimalImage>>(data);
        }
    }
}
