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
    public class DonationTypeService : IDonationTypeService
    {
        private readonly IDonationTypeRepository _repository;
        public DonationTypeService(IDonationTypeRepository repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<DonationType> Get()
        {
            return _repository.Get();
        }

        public DonationType Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post(DonationType newDonationType)
        {
            _repository.Post(newDonationType);
        }

        public void Put(int id, DonationType newDonationType)
        {
            _repository.put(id, newDonationType);
        }
    }
}
