using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IRepositories
{
    public interface IDonorRepository
    {
        List<Donor> Get();
        void Post(Donor newDonor);
        void Delete(int id);
        void Put(int id, Donor newDonor);
        public Donor Get(int id);
        public int checkWhoAreYou(string Tz);
    }
}
