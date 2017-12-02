using System.Collections.Generic;

namespace Library.Domain.Interfaces
{
	public interface ILibraryService
	{
		IEnumerable<IBookViewModel> GetAllBooks();
	}
}
