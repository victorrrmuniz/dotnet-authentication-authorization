using Shop.Models;

namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "batman", Password = "123", Role = "manager" });
            users.Add(new User { Id = 2, UserName = "robin", Password = "321", Role = "employee" });
            return users.Where(x => x.UserName.ToLower() == userName.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
