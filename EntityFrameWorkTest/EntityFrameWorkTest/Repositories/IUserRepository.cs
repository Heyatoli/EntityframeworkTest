using EntityFrameWorkTest.Models;

namespace EntityFrameWorkTest.Repositories
{
    public interface IUserRepository
    {
        public ICollection<User> GetAll();

        public long Add(User user);

        public User? GetById(long id);

        public void Delete(long id);

        public User Update(User user);
    }
}
