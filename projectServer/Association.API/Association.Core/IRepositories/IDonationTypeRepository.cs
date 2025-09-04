using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IRepositories
{
    public interface IDonationTypeRepository
    {
        List<DonationType> Get();
        void Post(DonationType newDonationType);
        void Delete(int id);
        void put(int id, DonationType newDonationType);
        public DonationType Get(int id);
    }
}
