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
        public List<LogAction> SearchLogActions(string searchKey)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;
            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Extract the year from the search key if present
            bool isYearSearch = words.Any(w => int.TryParse(w, out _));
            int searchYear = isYearSearch ? words.Where(w => int.TryParse(w, out _)).Select(int.Parse).FirstOrDefault() : 0;

            return _context.LogActions
                .Include(a => a.Book)
                .Include(a => a.Member)
                .Where(a =>
                    string.IsNullOrEmpty(searchKey) ||
                    words.Any(w => a.Action.ToString().ToLower().Contains(w)
                                || a.Member.Name.ToLower().Contains(w)
                                || a.Book.Title.ToLower().Contains(w))
                    || (isYearSearch && a.Date.Year == searchYear) 
                )
                .ToList();
        }

    }
}
