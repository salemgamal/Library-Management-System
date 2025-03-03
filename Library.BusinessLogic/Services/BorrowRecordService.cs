using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.BusinessLogic.Services
{
    public class BorrowRecordService
    {
        public BorrowRecordRepository _borrowRecordRepo;
        public BookRepository _bookRepo;
        public BorrowRecordService(BorrowRecordRepository borrowRecordRepo, BookRepository bookRepo)
        {
            _borrowRecordRepo = borrowRecordRepo;
            _bookRepo = bookRepo;
        }

        //borrow
        public void AddBorrowRecord( int BookId , int MemberId)
        {
            var book = _bookRepo.GetBookById(BookId);

            if (book == null) {
                throw new Exception("Book not found");
            }
            if (book.Quantity <= 0)
            {
                throw new Exception("Book is not available");
            }
            var borrowRecord = new BorrowRecord
            {
                BookId = BookId,
                MemberId = MemberId,
                BorrowDate = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(7)
            };
            _borrowRecordRepo.Borrowbook(borrowBook);
        }

        //return
        public void ReturnBook(int BorrowId)
        {
            var record = _borrowRecordRepo.GetAllBorrowedBooks()
            .FirstOrDefault(b => b.BorrowId == BorrowId && b.ReturnDate == null);
            if (record == null)
            {
                throw new Exception("Borrowed book not found");
            }
            _borrowRecordRepo.ReturnBook(BorrowId);
        }

        //get all borrowed books
        public List<BorrowRecord> GetAllBorrowedBooks()
        {
            return _borrowRecordRepo.GetAllBorrowedBooks();
        }

        //get member borrowed books
        public List<BorrowRecord> GetMemberBorrowedBooks(int UserId)
        {
            return _borrowRecordRepo.GetMemberBorrowedBooks(UserId);
        }

        //get returned books
        public List<BorrowRecord> GetReturnedBooks()
        {
            return _borrowRecordRepo.GetReturnedBooks();
        }

        //get overdue books
        public List<BorrowRecord> GetOverdueBooks()
        {
            return _borrowRecordRepo.GetOverdueBooks();
        }
    }
}
