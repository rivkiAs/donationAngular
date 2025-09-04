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
    public class DonationService : IDonationService
    {
        private readonly IDonationRepository _repository;
        public DonationService(IDonationRepository repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Donation> Get()
        {
            return _repository.Get();
        }

        public Donation Get(int id)
        {
            return _repository.Get(id);
        }

        public void Post(Donation newDonation)
        {
            _repository.Post(newDonation);
        }

        public void Put(int id, Donation newDonation)
        {
            _repository.put(id, newDonation);
        }
    }
}
