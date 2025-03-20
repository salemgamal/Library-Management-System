using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess.Repositry
{
    public class BorrowRecordRepository
    {
        LibraryDbContext _context;
        public BorrowRecordRepository(LibraryDbContext context)
        {
            _context = context;
        }

        //handle adding new borrow record and decrement book quantity
        // Modifiy
        public void Borrowbook(BorrowRecord borrowRecord)
        {
            var book = _context.Books.Find(borrowRecord.BookId);
            if (book != null || book.Quantity > 0) {
                book.Quantity--;
                _context.BorrowRecords.Add(borrowRecord);
                _context.SaveChanges();
            }
        }

        //handle returning book and increment book quantity
        public void ReturnBook(int MemberId, int BookId)
        {
            var returnedBook = _context.BorrowRecords.FirstOrDefault(b => b.MemberId == MemberId && b.BookId == BookId && b.ReturnDate == null);
            if (returnedBook != null)
            {
                returnedBook.ReturnDate = DateTime.Now.Date;
                var originalbook = _context.Books.Find(returnedBook.BookId);
                if (originalbook != null) {
                    originalbook.Quantity++;
                }
                _context.SaveChanges();
            }
            else{
                throw new Exception("Borrowed book not found or already returned.");
            }
        }

        //get all borrowed books (for Librarian)
        public List<BorrowRecord> GetAllBorrowedBooks()
        {
            return _context.BorrowRecords.ToList();
        }

        //get member borrowed books
        public List<BorrowRecord> GetMemberBorrowedBooks(int UserId)
        {
            return _context.BorrowRecords.Where(b => b.MemberId == UserId).ToList();
        }

        //get returned books
        public List<BorrowRecord> GetReturnedBooks()
        {
            return _context.BorrowRecords.Where(b => b.ReturnDate != null).ToList();
        }

        //get not returned books
        public List<BorrowRecord> GetNotReturnedBooks()
        {
            return _context.BorrowRecords.Where(b => b.ReturnDate == null).ToList();
        }
        //get overdue books
        public List<BorrowRecord> GetOverdueBooks()
        {
            return _context.BorrowRecords.Where(b => b.DueDate < DateTime.UtcNow.Date && b.ReturnDate == null).ToList();
        }

         
        // Search borrowed books (not yet returned)
        public List<BorrowRecord> SearchBorrowedBooks(string searchKey)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;
            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            bool isYearSearch = words.Any(w => int.TryParse(w, out _));
            int searchYear = isYearSearch ? words.Where(w => int.TryParse(w, out _)).Select(int.Parse).FirstOrDefault() : 0;

            return _context.BorrowRecords
                .Include(r => r.Book)
                .Include(r => r.Member)
                .Where(r => r.ReturnDate == null &&
                    (string.IsNullOrEmpty(searchKey) || words.Any(w =>
                        r.Book.Title.ToLower().Contains(w) ||
                        r.Book.Author.ToLower().Contains(w) ||
                        r.Book.Category.ToLower().Contains(w) ||
                        r.Member.Name.ToLower().Contains(w)) ||
                    (isYearSearch && r.BorrowDate.Year == searchYear || r.DueDate.Year == searchYear)))
                .ToList();
        }

        // Search overdue books (past due date and not returned)
        public List<BorrowRecord> SearchOverDueBooks(string searchKey)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;
            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            bool isYearSearch = words.Any(w => int.TryParse(w, out _));
            int searchYear = isYearSearch ? words.Where(w => int.TryParse(w, out _)).Select(int.Parse).FirstOrDefault() : 0;

            var query = _context.BorrowRecords
        .Include(r => r.Book)
        .Include(r => r.Member)
        .Where(r => r.ReturnDate == null && r.DueDate < DateTime.Now);

            // Only apply search filters if a search key is provided
            if (words.Length > 0)
            {
                query = query.Where(r =>
                    words.Any(w =>
                        r.Book.Title.ToLower().Contains(w) ||
                        r.Book.Author.ToLower().Contains(w) ||
                        r.Book.Category.ToLower().Contains(w) ||
                        r.Member.Name.ToLower().Contains(w)) ||
                    (isYearSearch && (r.BorrowDate.Year == searchYear || r.DueDate.Year == searchYear))
                );
            }

            return query.ToList();
        }
    }
}
