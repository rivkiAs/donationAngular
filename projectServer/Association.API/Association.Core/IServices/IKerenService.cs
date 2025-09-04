using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IServices
{
    public interface IKerenService
    {
        List<keren> Get();
        void Post(keren newKeren);
        void Delete(int id);
        void Put(int id, keren newKeren);
        public keren Get(int id);
    }
}
