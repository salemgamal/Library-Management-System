using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;

namespace Library.DataAccess.Repositories
{
    public class LogActionRepositry
    {
        LibraryDbContext _context;
        public LogActionRepositry(LibraryDbContext context)
        {
            _context = context;
        }

        //Add User Action
        public void AddUserAction(LogAction action)
        {
            _context.LogActions.Add(action);
            _context.SaveChanges();
        }
    }
}
