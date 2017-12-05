using Library.Domain.Models;
using System.Collections.Generic;

namespace Library.Domain.Interfaces.Repositories
{
	public interface IBookRepository
	{
		IList<BookModel> GetAllBooks();
	}
}
