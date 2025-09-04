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
    public class DonorService : IDonorService
    {
        private readonly IDonorRepository _repository;
        public DonorService(IDonorRepository repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Donor> Get()
        {
            return _repository.Get();
        }

        public Donor Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post(Donor newDonor)
        {
            _repository.Post(newDonor);
        }

        public void Put(int id, Donor newDonor)
        {
            _repository.Put(id, newDonor);
        }

        public int checkWhoAreYou(string Tz)
        {
           return  _repository.checkWhoAreYou(Tz);
        }
    }
}
