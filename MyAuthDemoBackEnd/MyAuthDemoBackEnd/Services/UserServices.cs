using MyAuthDemoBackEnd.Data;

namespace MyAuthDemoBackEnd.Services
{
    public class UserServices : IUserServices
    {
        private readonly UserDbContext _context;
        public UserServices(UserDbContext context)
        {
            _context = context;
        }
        public bool check(string username, string password)
        {
            var validation =  _context.Users.Find(username);
            if (validation == null)
            {
                return false;
            }
            if (validation.Password != password)
            {
                return false;
            }
            return true;            
        }
    }
}
