using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;

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
        public void ReturnBook(int BookId , int UserId)
        {
            var book = _context.BorrowRecords.FirstOrDefault( b=> b.BookId == BookId && b.MemberId == UserId && b.ReturnDate == null);
            if (book != null)
            {
                book.ReturnDate = DateTime.Now;
                var originalbook = _context.Books.Find(BookId);
                if (originalbook != null) {
                    originalbook.Quantity++;
                }
                _context.SaveChanges();
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
            return _context.BorrowRecords.Where(b => b.DueDate < DateTime.Now && b.ReturnDate == null).ToList();
        }
    }
}
