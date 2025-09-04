using Association.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.IServices
{
    public interface IDonationService
    {
        List<Donation> Get();
        void Post(Donation newDonation);
        void Delete(int id);
        void Put(int id, Donation newDonation);
        public Donation Get(int id);
    }
}
