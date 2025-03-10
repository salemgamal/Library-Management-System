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
        public List<Book> SearchBook(string searchKey)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;
            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return _context.Books.Where(b =>
                string.IsNullOrEmpty(searchKey) ||
                b.Category.ToLower().Contains(searchKey) ||
                words.Any(w =>
                    b.Title.ToLower().Contains(w) ||
                    b.Author.ToLower().Contains(w)))
            .ToList();
        }

        //get availabe books
        public List<Book> GetAvailableBooks()
        {
            return _context.Books.Where(b => b.Quantity > 0).ToList();
        }
        //search available books
        public List<Book> SearchAvailableBook(string searchKey)
        {
            searchKey = searchKey?.Trim().ToLower() ?? string.Empty;

            // Get all available books if no search key is provided
            if (string.IsNullOrEmpty(searchKey))
            {
                return GetAvailableBooks();
            }

            var words = searchKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Check if the search key contains a year
            bool isYearSearch = words.Any(w => int.TryParse(w, out _));
            int searchYear = isYearSearch ? words.Where(w => int.TryParse(w, out _)).Select(int.Parse).FirstOrDefault() : 0;

            return _context.Books
                .Where(b => b.Quantity > 0 && words.Any(w =>
                    b.Title.ToLower().Contains(w) ||
                    b.Author.ToLower().Contains(w) ||
                    b.Category.ToLower().Contains(w) ||
                    (isYearSearch && b.PublishedYear == searchYear)))
                .ToList();
        }
    }
}
