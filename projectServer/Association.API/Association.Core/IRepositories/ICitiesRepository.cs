using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IRepositories
{
    public interface ICitiesRepository
    {
        List<Cities> Get();
        void Post(Cities newCity);
        void Delete(int id);
        void Put(int id, Cities newCity);
        public Cities Get(int id);

    }
}
