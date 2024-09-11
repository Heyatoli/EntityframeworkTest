using EntityFrameWorkTest.DataContracts;
using EntityFrameWorkTest.Models;

namespace EntityFrameWorkTest.Mappers
{
    public class UserMapper
    {
        public static UserDTO MapToUserDTO(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name
            };
        }

        public static User MapToUser(UserDTO userDTO)
        {
            return new User
            {
                Name = userDTO.Name
            };
        }
    }
}
