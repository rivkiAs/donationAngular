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
    public class kerenRepository : IKerenRepository
    {
        private readonly DataContext _DataObject;
        public kerenRepository(DataContext DataObject)
        {
            _DataObject = DataObject;
        }
        public void Delete(int id)
        {
            var toDelete = Get(id);
            _DataObject.KerenDb.Remove(toDelete);
            _DataObject.SaveChanges();

        }

        public List<keren> Get()
        {
            return _DataObject.KerenDb.ToList();

        }

        public keren Get(int id)
        {
            return _DataObject.KerenDb.Find(id);
        }

        public void Post(keren newKeren)
        {
            _DataObject.KerenDb.Add(newKeren);
            _DataObject.SaveChanges();

        }

        public void put(int id, keren newKeren)
        {
            var toUpDate = Get(id);
            if (toUpDate != null)
            {
                toUpDate.CatalogNumber = newKeren.CatalogNumber;
                toUpDate.Percent = newKeren.Percent;
                toUpDate.Description = newKeren.Description;
                toUpDate.Target = newKeren.Target;
            _DataObject.SaveChanges();

            }
        }
        
    }
}
