﻿using TestApp.Models;
using TestApp.Repository;

namespace TestApp.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

    }
}
