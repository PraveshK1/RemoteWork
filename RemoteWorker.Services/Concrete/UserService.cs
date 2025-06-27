using RemoteWorker.Services.Abstract;
using RemoteWorker.DTOs;
using RemoteWorker.Repositories.Abstract;

namespace RemoteWorker.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDTO?> GetUserByIdAsync(string id)
        {
            var user = await _repository.GetByIdAsync(id);
            return user != null ? new UserDTO 
            { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName, DateOfBirth = user.DateOfBirth } : null;
        }
    }
}
