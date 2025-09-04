using Association.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.Entities
{
    public class DonationType
    {
        public int Id { get; set; }
        public string NameType { get; set; }

        public List<Donation> Donations { get; set; }

    }
}
