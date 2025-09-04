using Association.API.NewFolder;
using Association.Core.Entities;
using Association.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Association.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private readonly IDonorService _IdonorServiceObject;

        public DonorController(IDonorService IDonorServiceObject)
        {
            this._IdonorServiceObject = IDonorServiceObject;
        }
        // GET: api/<DonationTypeController>
        [HttpGet]
        public IEnumerable<Donor> Get()
        {
            return _IdonorServiceObject.Get();
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public Donor Get(int id)
        {
            return _IdonorServiceObject.Get(id);
        }

        // POST api/<DonationController>
        [HttpPost]
        public void Post([FromBody] DonorPostModel value)
        {
            
            Donor nDonor = new Donor
            {
                CitiesId = value.CitiesId,
                Email = value.Email,
                LastName = value.LastName,
                FirstName = value.FirstName,
                Tz = value.Tz,
                PhoneMumber = value.PhoneMumber
            };
            _IdonorServiceObject.Post(nDonor);
        }
       

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public Donor Put(int id, [FromBody] DonorPostModel value)
        {
            Donor nDonor = new Donor
            {
                CitiesId = value.CitiesId,
                Email = value.Email,
                LastName = value.LastName,
                FirstName = value.FirstName,
                Tz = value.Tz,
                PhoneMumber = value.PhoneMumber
            };
            _IdonorServiceObject.Put(id, nDonor);
            return nDonor;
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IdonorServiceObject.Delete(id);
        }


        [HttpGet("check/{tz}")]
        public int checkWhoAreYou(string tz)
        {
            return _IdonorServiceObject.checkWhoAreYou(tz);
        }
    }
}
