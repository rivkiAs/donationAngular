using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.Entities
{
    public class keren
    {
        public int Id { get; set; }
        public int CatalogNumber { get; set; }
        public string? Description { get; set; }
        public int Target { get; set; }
        public int Percent { get; set; }
        public List <Donation> Donations { get; set; }
    }
}
