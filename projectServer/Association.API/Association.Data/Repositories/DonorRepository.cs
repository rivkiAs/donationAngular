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
    public class DonorRepository : IDonorRepository
    {

        private readonly DataContext _DataObject;
        public DonorRepository(DataContext DataObject)
        {
            _DataObject = DataObject;
        }

        public void Delete(int id)
        {
            var toDelete = Get(id);
            _DataObject.DonorDb.Remove(toDelete);
            _DataObject.SaveChanges();

        }

        public List<Donor> Get()
        {
            return _DataObject.DonorDb.Include(less => less.Cities).ToList();

        }

        public Donor Get(int id)
        {
            return _DataObject.DonorDb.Include(less => less.Cities).First(don=>don.Id==id);
        }

        public void Post(Donor newDonor)
        {
            _DataObject.DonorDb.Add(newDonor);
            _DataObject.SaveChanges();
        }


        public void Put(int id, Donor newDonor)
        {
            var toUpDate = Get(id);
            if (toUpDate != null)
            {
                toUpDate.CitiesId = newDonor.CitiesId;
                toUpDate.Email = newDonor.Email;
                toUpDate.FirstName = newDonor.FirstName;
                toUpDate.LastName = newDonor.LastName;
                toUpDate.Tz = newDonor.Tz;
                toUpDate.PhoneMumber = newDonor.PhoneMumber;
            _DataObject.SaveChanges();

            }
        }


       



        public int checkWhoAreYou(string Tz)
        {
          if(_DataObject.DonorDb.Count(a => a.Tz.Equals(Tz))==0)
                return -1;//לא קיים
            if (Tz.Equals("000000000"))
                return 0;//מנהל
            return 1;//לקוח קיים
                
            
        }
       
    }
}
