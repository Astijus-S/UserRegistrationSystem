using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationSystem.Entities;
using UserRegistrationSystem.Interfaces;

namespace UserRegistrationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
        [HttpGet("Get_by_id")]
        public User Get(int id)
        {
            return _userRepository.Get(id);
        }
        [HttpPost]
        public User Add([FromBody] UserDTO user)
        {
            return _userRepository.Add(user);
        }
        [HttpPut("Update_all")]
        public User Update([FromQuery] int id, [FromBody] UserDTO user)
        {
            return _userRepository.Update(id, user);
        }
        [HttpPut("Update_name")]
        public User UpdateName([FromQuery] int id, [FromBody] UserFirstNameDTO user)
        {
            return _userRepository.UpdateFirstName(id, user);
        }
        [HttpPut("Update_Surname")]
        public User UpdateSurName([FromQuery] int id, [FromBody] UserLastNameDTO user)
        {
            return _userRepository.UpdateLastName(id, user);
        }
        //[HttpPut("Update_IdNumber")]
        //public User UpdateIdNumber([FromQuery] int id, [FromBody] UserIdNumberDTO user)
        //{
        //    return _userRepository.UpdateIdNumber(id, user);
        //}
        [HttpPut("Update_Phone")]
        public User UpdatePhone([FromQuery] int id, [FromBody] UserPhoneDTO user)
        {
            return _userRepository.UpdatePhone(id, user);
        }
        [HttpPut("Update_Mail")]
        public User UpdateMail([FromQuery] int id, [FromBody] UserEmailDTO user)
        {
            return _userRepository.UpdateEmail(id, user);
        }
        [HttpDelete]
        public User Delete([FromQuery] int id)
        {
            return _userRepository.Delete(id);
        }
    }
}
