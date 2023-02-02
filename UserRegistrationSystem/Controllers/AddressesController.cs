using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationSystem.Entities;
using UserRegistrationSystem.Interfaces;

namespace UserRegistrationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;
        public AddressesController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpGet]
        public List<Address> GetAll()
        {
            return _addressRepository.GetAll();
        }
        [HttpGet("Get_by_id")]
        public Address Get(int id)
        {
            return _addressRepository.Get(id);
        }
        [HttpPost]
        public Address Add([FromBody] AddressDTO address)
        {
            return _addressRepository.Add(address);
        }
        [HttpPut]
        public Address Update([FromQuery] int id, [FromBody] AddressDTO address)
        {
            return _addressRepository.Update(id, address);
        }
        [HttpDelete]
        public Address Delete([FromQuery] int id)
        {
            return _addressRepository.Delete(id);
        }
    }
}
