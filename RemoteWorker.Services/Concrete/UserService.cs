using RemoteWorker.Services.Abstract;
using RemoteWorker.DTOs;
using RemoteWorker.Repositories.Abstract;
using Microsoft.Extensions.Logging;
using RemoteWorker.Models;
using AutoMapper;

namespace RemoteWorker.Services.Concrete
{
    public class UserService(IGenericRemoteWorkerRepository<UserModel> repository, IMapper mapper, ILogger<UserService> logger) : IUserService
    {
        private readonly IGenericRemoteWorkerRepository<UserModel> _repository = repository;
        private readonly ILogger<UserService> _logger = logger;
        private readonly IMapper _mapper = mapper;

        public async Task<UserDto?> GetUserByIdAsync(Guid id)
        {
            var user = await _repository.GetByIdAsync(id);
            return user == null ? null : _mapper.Map<UserDto>(user);          
        }

       

    }
}
