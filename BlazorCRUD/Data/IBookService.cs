using System;
using System.Threading.Tasks;
using BlazorCRUD.Models;
namespace BlazorCRUD.Data
{
	public interface IBookService
	{
		Task<IEnumerable<Book>> GetBooks();
		Task<Book> GetBookDetails(int id);
		Task<bool> InsertBook(Book book);
		Task<bool> UpdateBook(Book book );
		Task<bool> DeleteBook(int id);
		Task<bool> SaveBook(Book book);

	}
}

