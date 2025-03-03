using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;

namespace Library.DataAccess.Repositry
{
    public class UserRepository
    {
        public LibraryDbContext _context;
        public UserRepository(LibraryDbContext context)
        {
            _context = context;
        }

        //handle adding new user
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //handle get all users
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        //by id
        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        //update user
        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        //delete user
        public void DeleteUser(int userId) { 
            var user = _context.Users.Find(userId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        //get user by role
        public List<User> GetUserByRole(UserRole role)
        {
            return _context.Users.Where(u => u.Role == role).ToList();
        }

    }
}
