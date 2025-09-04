using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IServices
{
    public interface ICitiesService
    {
        List<Cities> Get();
        void Post(Cities newCities);
        void Delete(int id);
        void Put(int id, Cities newCities);
        public Cities Get(int id);
    }
}
