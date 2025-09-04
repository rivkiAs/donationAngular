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
    public class DonationTypeRepository : IDonationTypeRepository
    {
        private readonly DataContext _DataObject;
        public DonationTypeRepository(DataContext DataObject)
        {
            _DataObject = DataObject;
        }
        public void Delete(int id)
        {
            var toDelete = Get(id);
            _DataObject.DonationTypeDb.Remove(toDelete);
            _DataObject.SaveChanges();

        }

        public List<DonationType> Get()
        {
            return _DataObject.DonationTypeDb.ToList();
        }

        public DonationType Get(int id)
        {
            return _DataObject.DonationTypeDb.Find(id);
        }

        public void Post(DonationType newDonationType)
        {
            _DataObject.DonationTypeDb.Add(newDonationType);
            _DataObject.SaveChanges();

        }

        public void put(int id, DonationType newDonationType)
        {
            var toUpDate = Get(id);
            if (toUpDate != null)
            {
                toUpDate.NameType = newDonationType.NameType;
                _DataObject.SaveChanges();

            }
        }
    }
}
