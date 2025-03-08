using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

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

        //get log actions
        public List<LogAction> GetLogActions() { 
        return _context.LogActions.ToList();
        }

        public List<LogAction> SearchLogActions(string searchKey, DateTime? date)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;
            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return _context.LogActions
                .Include(a => a.Book)
                .Include(a => a.Member)
                .Where(a => words.Any(w => a.Action.ToString().ToLower().Contains(w)
                                         || a.Member.Name.ToLower().Contains(w)
                                         || a.Book.Title.ToLower().Contains(w))
                           || (date.HasValue && a.Date == date))
                .ToList();
        }

    }
}
