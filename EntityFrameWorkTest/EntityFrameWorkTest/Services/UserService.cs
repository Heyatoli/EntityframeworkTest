using EntityFrameWorkTest.DataContracts;
using EntityFrameWorkTest.Mappers;
using EntityFrameWorkTest.Models;
using EntityFrameWorkTest.Repositories;

namespace EntityFrameWorkTest.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository) 
        {
            this.userRepository = userRepository;
        }

        public long AddUser(UserDTO user)
        {
            var mappedUser = UserMapper.MapToUser(user);
            var createdUserId = userRepository.Add(mappedUser);

            return createdUserId;
        }

        public UserDTO? GetUser(long id)
        {
            var user = userRepository.GetById(id);

            if (user is null)
            {
                return null;
            }

            var mappedUser = UserMapper.MapToUserDTO(user);
            return mappedUser;
        }

        public ICollection<UserDTO> GetUsers()
        {
            var users = userRepository.GetAll();
            var mappedUsers = MapUsers(users);

            return mappedUsers;
        }

        public void DeleteUser(long id)
        {
            userRepository.Delete(id);
        }

        private ICollection<UserDTO> MapUsers(ICollection<User> users)
        {
            List<UserDTO> usersToReturn = new List<UserDTO>();

            foreach (var user in users)
            {
                var newUser = UserMapper.MapToUserDTO(user);
                usersToReturn.Add(newUser);
            }

            return usersToReturn;
        }

        public UserDTO UpdateUser(UserDTO user)
        {
            //userRepository.Update(user);
            throw new NotImplementedException();
        }
    }
}
