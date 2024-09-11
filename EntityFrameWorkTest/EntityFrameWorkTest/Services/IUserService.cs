using EntityFrameWorkTest.DataContracts;

namespace EntityFrameWorkTest.Services
{
    public interface IUserService
    {
        public ICollection<UserDTO> GetUsers();

        public long AddUser(UserDTO user);

        public void DeleteUser(long id);

        public UserDTO? GetUser(long id);

        public UserDTO UpdateUser(UserDTO user);
    }
}
