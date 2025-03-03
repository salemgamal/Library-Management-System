using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Models;

namespace Library.DataAccess.Repositry
{
    public class BookRepository
    {
        public LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        //handle adding new book
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        //get all books
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        //get book by book id
        public Book GetBookById(int bookId)
        {
            return _context.Books.Find(bookId);
        }

        //update book
        public void UpdateBook(Book book)
        { 
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        //delete book
        public void DeleteBook(int bookId) { 
            var book = _context.Books.Find(bookId);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        //search
        public List<Book> SearchBook(string searchKey) { 
            return _context.Books.Where(b => b.Title.Contains(searchKey) 
            || b.Author.Contains(searchKey) || b.Category.Contains(searchKey)).ToList();
        }

        //get availabe books
        public List<Book> GetAvailableBooks()
        {
            return _context.Books.Where(b => b.Quantity > 0).ToList();
        }
    }
}
