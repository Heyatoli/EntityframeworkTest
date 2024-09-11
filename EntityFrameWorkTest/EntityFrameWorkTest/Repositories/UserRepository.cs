using EntityFrameWorkTest.Models;

namespace EntityFrameWorkTest.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context) 
        {
            this.context = context;
        }

        public long Add(User user)
        {
            var newUser = context.Users.Add(user);
            context.SaveChanges();

            return newUser.Entity.Id;
        }

        public void Delete(long id)
        {
            var user = context.Users.SingleOrDefault(x => x.Id == id);

            if (user == null) 
            {
                throw new KeyNotFoundException($"User with id {id} doesnt exist");
            }

            context.Users.Remove(user);
            context.SaveChanges();
        }

        public ICollection<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User? GetById(long id)
        {
            var user = context.Users.SingleOrDefault(x => x.Id == id);
            return user;
        }

        public User Update(User user)
        {
            var existingUser = context.Users.SingleOrDefault(x => x.Id == user.Id);

            if (existingUser == null)
            {
                throw new KeyNotFoundException($"User with id {1} doesnt exist");
            };

            existingUser.Name = user.Name;
            context.SaveChanges();

            return existingUser;
        }
    }
}
