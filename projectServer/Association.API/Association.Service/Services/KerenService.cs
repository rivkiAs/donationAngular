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
    public class KerenService : IKerenService
    {
        private readonly IKerenRepository _repository;
        public KerenService(IKerenRepository repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<keren> Get()
        {
            return _repository.Get();
        }

        public keren Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post(keren newKeren)
        {
            _repository.Post(newKeren);
        }

        public void Put(int id, keren newKeren)
        {
            _repository.put(id, newKeren);
        }
    }
}
