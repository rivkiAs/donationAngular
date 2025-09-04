using Association.API.NewFolder;
using Association.Core.Entities;
using Association.Core.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Association.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonationService _IdonationServiceObject;

        public DonationController(IDonationService IdonationServiceObject)
        {
            this._IdonationServiceObject = IdonationServiceObject;
        }


        [HttpGet]
        public IEnumerable<Donation> Get()
        {
            return _IdonationServiceObject.Get();
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public Donation Get(int id)
        {
            return _IdonationServiceObject.Get(id);
        }

        // POST api/<DonationController>
        [HttpPost]
        public void Post([FromBody] DonationPostModel value)
        {
            Donation nDonation = new Donation
            {
                DonationTypeId = value.DonationTypeId,
                DonorId = value.DonorId,
                AmountPerBeat = value.AmountPerBeat,
                NumberOfBeats = value.NumberOfBeats,
                KerenId = value.KerenId
            };
        _IdonationServiceObject.Post(nDonation);
        }







        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DonationPostModel value)
        {
            Donation nDonation = new Donation
            {
                DonationTypeId = value.DonationTypeId,
                DonorId = value.DonorId,
                AmountPerBeat = value.AmountPerBeat,
                NumberOfBeats = value.NumberOfBeats,
                KerenId = value.KerenId
            };

            _IdonationServiceObject.Put(id,nDonation);
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IdonationServiceObject.Delete(id);
        }
    }
}
