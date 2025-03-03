using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.BusinessLogic.Services
{
    public class UserService
    {
        public UserRepository _userRepo;
        public UserService(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public void AddUser(User user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) ||
               string.IsNullOrEmpty(user.Email))
            {
                throw new Exception("Username, Password and Email are required");
            }
            else
            {
                _userRepo.AddUser(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepo.GetUserById(id);
        }

        public void UpdateUser(User user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                throw new Exception("Username is required");
            }
            else
            {
                _userRepo.UpdateUser(user);
            }
        }

        public void DeleteUser(int userId)
        {
            _userRepo.DeleteUser(userId);
        }

        public List<User> GetUserByRole(UserRole role)
        {
            return _userRepo.GetUserByRole(role);
        }

        public User AuthenticateUser(string userName, string password)
        {
            var user = _userRepo.GetAllUsers().FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Invalid Username or Password");
            }
        }
    }
}
