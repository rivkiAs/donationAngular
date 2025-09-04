using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Core.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonationTypeId { get; set; }//donation type id
        public DonationType DonationType { get; set; }
        public int DonorId { get; set; }//donor id
        public Donor Donor { get; set; }
        public double AmountPerBeat { get; set; }
        public int NumberOfBeats { get; set; }
        public int KerenId { get; set; }//keren id
        public keren Keren { get; set; }
    }

}
