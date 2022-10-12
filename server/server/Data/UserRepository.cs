using server.Model;

namespace server.Data
{
    public class UserRepository: IUserRepository
    {

        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            user.UserId = _context.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(User => User.UserEmail == email);
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(User => User.UserId == id);
        }
    }
}
