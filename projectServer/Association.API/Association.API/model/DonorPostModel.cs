using Association.Core.Entities;

namespace Association.API.NewFolder
{
    public class DonorPostModel
    {
        public string? Tz { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CitiesId { get; set; }//city id
        public string? PhoneMumber { get; set; }
        public string? Email { get; set; }
    }
}
