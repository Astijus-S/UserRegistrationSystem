using UserRegistrationSystem.Entities;

namespace UserRegistrationSystem.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Get(int id);
        User Add(UserDTO user);
        User Update(int id, UserDTO user);
        User UpdateFirstName(int id, UserFirstNameDTO user);
        User UpdateLastName(int id, UserLastNameDTO user);
        //User UpdateIdNumber(int id, UserIdNumberDTO user);
        User UpdatePhone(int id, UserPhoneDTO user);
        User UpdateEmail(int id, UserEmailDTO user);
        User Delete(int id);
    }
}
