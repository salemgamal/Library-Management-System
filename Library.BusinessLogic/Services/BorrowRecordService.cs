using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Library.DataAccess.Repositories;
using Library.DataAccess.Repositry;

namespace Library.BusinessLogic.Services
{
    public class BorrowRecordService
    {
        public BorrowRecordRepository _borrowRecordRepo;
        public BookRepository _bookRepo;
        public LogActionRepositry _logActionRepo;
        public BorrowRecordService(BorrowRecordRepository borrowRecordRepo, BookRepository bookRepo , LogActionRepositry logActionRepo)
        {
            _borrowRecordRepo = borrowRecordRepo;
            _bookRepo = bookRepo;
            _logActionRepo = logActionRepo;
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
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7)
            };
            var borrowLog = new LogAction
            {
                Action = LogActionType.Borrow,
                BookId = BookId,
                MemberId = MemberId,
                Date = DateTime.Now
            };
            _logActionRepo.AddUserAction(borrowLog);
            _borrowRecordRepo.Borrowbook(borrowRecord);
        }

        //return
        public void ReturnBook(int MemberId, int BookId)
        {
            var record = _borrowRecordRepo.GetAllBorrowedBooks()
            .FirstOrDefault(b => b.MemberId == MemberId && b.BookId == BookId && b.ReturnDate == null);
            if (record == null)
            {
                throw new Exception("Borrowed book not found");
            }
            var returnLog = new LogAction
            {
                Action = LogActionType.Return,
                BookId = record.BookId,
                MemberId = record.MemberId,
                Date = DateTime.Now
            };
            _logActionRepo.AddUserAction(returnLog);
            _borrowRecordRepo.ReturnBook(MemberId , BookId);
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

        public List<BorrowRecord> SearchBorrowedBook(string searchKey ,DateTime? date)
        {
            
                return _borrowRecordRepo.SearchBorrowedBooks(searchKey ,date);
            
        }

        public List<BorrowRecord> SearchOverDueBook(string searchKey ,DateTime? date)
        {
                return _borrowRecordRepo.SearchOverDueBooks(searchKey, date);
            
        }

        public List<LogAction> GetLogActions() { 
        
            return _logActionRepo.GetLogActions();
        }

        public List<LogAction> searchLogActions(string searchKey, DateTime? date) { 
            return _logActionRepo.SearchLogActions(searchKey ,date);
        }

        
    }
}
