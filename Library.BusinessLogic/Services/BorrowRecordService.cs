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
            //check if Memner alraedy borrowed this book and did not returned yet
            var notReturnedBooks = GetNotReturnedBooks(MemberId);
            if (notReturnedBooks.Any(b => b.BookId == BookId))
            {
                throw new Exception("You already borrowed this book and did not return it yet");
            }
            else
            {
                //check if member borrowed more than 3 books
                if (notReturnedBooks.Count >= 5)
                {
                    throw new Exception("You can't borrow more than 3 books");
                }
                else
                {
                    var book = _bookRepo.GetBookById(BookId);

                    if (book == null)
                    {
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
                        BorrowDate = DateTime.Now.Date,
                        DueDate = DateTime.Now.Date.AddDays(5)
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
            }
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
                Date = DateTime.Now.Date
            };
            _logActionRepo.AddUserAction(returnLog);
            _borrowRecordRepo.ReturnBook(MemberId , BookId);
        }

        //get all borrowed books
        public List<BorrowRecord> GetAllBorrowedBooks()
        {
            return _borrowRecordRepo.GetAllBorrowedBooks();
        }

        //get all member borrowed books
        public List<BorrowRecord> GetMemberBorrowedBooks(int UserId)
        {
            return _borrowRecordRepo.GetMemberBorrowedBooks(UserId);
        }

        //get member borrowed books which he didn't return yet
        public List<BorrowRecord> GetNotReturnedBooks(int MemberID)
        {
            return _borrowRecordRepo.GetNotReturnedBooks().Where( b => b.MemberId == MemberID ).ToList();
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
