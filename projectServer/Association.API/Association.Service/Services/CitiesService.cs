using Association.Core.Entities;
using Association.Core.IRepositories;
using Association.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Service.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly ICitiesRepository _repository;
        public CitiesService(ICitiesRepository repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Cities> Get()
        {
           return  _repository.Get();
        }

        public Cities Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post(Cities newCities)
        {
            _repository.Post(newCities);
        }

        public void Put(int id, Cities newCities)
        {
            _repository.Put(id, newCities);
        }
    }
}
