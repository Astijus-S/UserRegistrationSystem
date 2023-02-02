using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationSystem.Entities;
using UserRegistrationSystem.Interfaces;

namespace UserRegistrationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginsController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpGet]
        public List<Login> GetAll()
        {
            return _loginRepository.GetAll();
        }
        [HttpGet("Get_by_id")]
        public Login Get(int id)
        {
            return _loginRepository.Get(id);
        }
        [HttpPost]
        public Login Add([FromBody] LoginDTO login)
        {
            return _loginRepository.Add(login);
        }
        [HttpPut]
        public Login Update([FromQuery] int id, [FromBody] LoginDTO login)
        {
            return _loginRepository.Update(id, login);
        }
        [HttpDelete]
        public Login Delete([FromQuery] int id)
        {
            return _loginRepository.Delete(id);
        }
    }
}
