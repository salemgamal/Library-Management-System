using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.BusinessLogic.Services
{
    public class BookService
    {
        public BookRepository _bookRepo;
        public BookService(BookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }
        public void AddBook(Book book)
        {
            if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author) ||
               string.IsNullOrEmpty(book.ISBN))
            {
                throw new Exception("Title, Author and ISBN are required");
            }
            else if (book.Quantity < 0)
            {
                throw new Exception("Quantity must be greater than or equal to 0");
            }
            else
            {
                _bookRepo.AddBook(book);
            }
        }

        //get All books
        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }
        public Book GetBookById(int id)
        {
            return _bookRepo.GetBookById(id);
        }
        public void UpdateBook(Book book)
        {

            if (string.IsNullOrEmpty(book.Title)) // what about other props?
            {
                throw new Exception("Title is required");
            }
            else
            {
                _bookRepo.UpdateBook(book);
            }
        }
        public void DeleteBook(int bookId)
        {
            _bookRepo.DeleteBook(bookId);
        }
        public List<Book> SearchBook(string searchKey)
        {
            if (string.IsNullOrEmpty(searchKey))
            {
                throw new Exception("Search key is required");
            }
            else
            {
                return _bookRepo.SearchBook(searchKey);
            }
        }
        public List<Book> GetAvailableBooks()
        {
            return _bookRepo.GetAvailableBooks().ToList();
        }
    }
}
