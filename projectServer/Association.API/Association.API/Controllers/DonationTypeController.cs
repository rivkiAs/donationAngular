using Association.API.NewFolder;
using Association.Core.Entities;
using Association.Core.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Association.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationTypeController : ControllerBase
    {
        private readonly IDonationTypeService _IdonationTypeServiceObject;

        public DonationTypeController(IDonationTypeService IdonationTypeServiceObject)
        {
            this._IdonationTypeServiceObject = IdonationTypeServiceObject;
        }
        // GET: api/<DonationTypeController>
        [HttpGet]
        public IEnumerable<DonationType> Get()
        {
            return _IdonationTypeServiceObject.Get();
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public DonationType Get(int id)
        {
            return _IdonationTypeServiceObject.Get(id);
        }

        // POST api/<DonationController>
        [HttpPost]
        public void Post([FromBody] DonationTypePostModel value)
        {
            DonationType nDonationType = new DonationType
            {
                NameType = value.NameType
            };
                 
        _IdonationTypeServiceObject.Post(nDonationType);
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DonationTypePostModel value)
        {
            DonationType nDonationType = new DonationType
            {
                NameType = value.NameType
            };
            _IdonationTypeServiceObject.Put(id, nDonationType);
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IdonationTypeServiceObject.Delete(id);
        }
    }
}
