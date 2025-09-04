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
    public class CitiesRepository : ICitiesRepository

    {
        private readonly DataContext _DataObject;

        public CitiesRepository(DataContext DataObject)
        {
            _DataObject = DataObject;
        }
        public void Delete(int id)
        {
            var toDelete = Get(id);
            _DataObject.CitiesDb.Remove(toDelete);
            _DataObject.SaveChanges();
        }

        public List<Cities> Get()
        {
            return _DataObject.CitiesDb.ToList();
        }

        public Cities Get(int id)
        {
            return _DataObject.CitiesDb.Find(id);
        }

        public void Post(Cities newCity)
        {
            _DataObject.CitiesDb.Add(newCity);
            _DataObject.SaveChanges();
        }

        public void Put(int id, Cities newCity)
        {
            var toUpDate = Get(id);
            if (toUpDate != null)
            {
                toUpDate.CityName = newCity.CityName;
                _DataObject.SaveChanges();
            }
        }

       
    }
}
