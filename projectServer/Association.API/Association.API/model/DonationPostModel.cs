using Association.Core.Entities;

namespace Association.API.NewFolder
{
    public class DonationPostModel
    {
        public int DonationTypeId { get; set; }//donation type id
        public int DonorId { get; set; }//donor id
        public double AmountPerBeat { get; set; }
        public int NumberOfBeats { get; set; }
        public int KerenId { get; set; }//keren id
        
    }
}
