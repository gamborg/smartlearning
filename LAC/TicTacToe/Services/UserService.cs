using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public class UserService : IUserService
    {
        private static ConcurrentBag<UserModel> _userStore;

        static UserService()
        {
            _userStore = new ConcurrentBag<UserModel>();
        }

        public Task<bool> RegisterUser(UserModel model)
        {
            _userStore.Add(model);
            return Task.FromResult(true);
        }

        public Task<bool> IsOnline(string name)
        {
            return Task.FromResult(true);
        }

        public Task<UserModel> GetUserByEmail(string email)
        {
            return Task.FromResult(_userStore.FirstOrDefault(x => x.Email == email));
        }

        public Task UpdateUser(UserModel user)
        {
            _userStore = new ConcurrentBag<UserModel>(_userStore.Where(u => u.Email != user.Email)) { user };
            return Task.CompletedTask;
        }
    }
}
