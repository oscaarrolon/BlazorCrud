using System;
using BlazorCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorCRUD.Data
{
    public class BookService : IBookService
    {

        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.FindAsync<Book>(id);

            _ = _context.Books.Remove(book);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Book> GetBookDetails(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
        
            return await _context.Books.ToListAsync();
        }

        public async Task<bool> InsertBook(Book book)
        {
            _ = _context.Books.AddAsync(book);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveBook(Book book)
        {
            if (book.Id > 0)
            {
                return await UpdateBook(book);
            }
            else return await InsertBook(book);


        }

        public async Task<bool> UpdateBook(Book book)
        {

            _context.Books.Update(book);
            return await _context.SaveChangesAsync() > 0;

        }

       
    }
}

