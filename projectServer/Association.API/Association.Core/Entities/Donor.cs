using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.Entities
{
    public class Donor
    {
        public int Id { get; set; }
        public string? Tz { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CitiesId { get; set; }//city id
        public Cities Cities { get; set; }
        public string? PhoneMumber { get; set; }
        public string? Email { get; set; }

        public List<Donation> Donations { get; set; }
    }
}
