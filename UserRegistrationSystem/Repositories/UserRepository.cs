using UserRegistrationSystem.DB;
using UserRegistrationSystem.Entities;
using UserRegistrationSystem.Interfaces;

namespace UserRegistrationSystem.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public UserRepository()
        {
        }

        public User Add(UserDTO user)
        {
            var newUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                IdNo = user.IdNo,
                Phone = user.Phone,
                Email = user.Email,
                Photo = user.Photo
            };
            _context.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User Delete(int id)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
            _context.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public User Get(int id)
        {
            return _context.Users.SingleOrDefault(x => x.Id == id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(int id, UserDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.FirstName = user.FirstName;
            upUser.LastName = user.LastName;
            //upUser.IdNo = user.IdNo;
            upUser.Phone = user.Phone;
            upUser.Email = user.Email;
            upUser.Photo = user.Photo;
            _context.SaveChanges();
            return upUser;
        }
        public User UpdateFirstName(int id, UserFirstNameDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.FirstName = user.FirstName;
            _context.SaveChanges();
            return upUser;
        }
        public User UpdateLastName(int id, UserLastNameDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.LastName = user.LastName;
            _context.SaveChanges();
            return upUser;
        }
        public User UpdateIdNumber(int id, UserIdNumberDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.IdNo = user.IdNo;
            _context.SaveChanges();
            return upUser;
        }
        public User UpdatePhone(int id, UserPhoneDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.Phone = user.Phone;
            _context.SaveChanges();
            return upUser;
        }
        public User UpdateEmail(int id, UserEmailDTO user)
        {
            var upUser = _context.Users.SingleOrDefault(x => x.Id == id);
            upUser.Email = user.Email;
            _context.SaveChanges();
            return upUser;
        }
    }
}
