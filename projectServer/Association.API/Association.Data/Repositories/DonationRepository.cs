using Association.Core.Entities;
using Association.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Data.Repositories
{
    public class DonationRepository : IDonationRepository
    {

        private readonly DataContext _DataObject;
        public DonationRepository(DataContext DataObject)
        {
            _DataObject = DataObject;
        }
        public void Delete(int id)
        {
            var toDelete = Get(id);
            _DataObject.DonationDb.Remove(toDelete);
            _DataObject.SaveChanges();
        }

        public List<Donation> Get()
        {
            return _DataObject.DonationDb.Include(less => less.DonationType).Include(d=>d.Keren).Include(d => d.Donor).ToList();
            //chck
        }

        public Donation Get(int id)
        {
            return _DataObject.DonationDb.Find(id);
            //---
        }

        public void Post(Donation newDonation)
        {
            _DataObject.DonationDb.Add(newDonation);
            _DataObject.SaveChanges();
        }

        public void put(int id, Donation newDonation)
        {
            var toUpDate = Get(id);
            if (toUpDate != null)
            {
                toUpDate.KerenId= newDonation.KerenId;
                toUpDate.NumberOfBeats = newDonation.NumberOfBeats;
                toUpDate.DonationTypeId = newDonation.DonationTypeId;
                toUpDate.DonorId = newDonation.DonorId;
                toUpDate.AmountPerBeat = newDonation.NumberOfBeats;
                _DataObject.SaveChanges();
            }
        }
    }
}
