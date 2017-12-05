using Library.Domain.Interfaces.ViewModels;
using System.Collections.Generic;

namespace Library.Domain.Interfaces.Services
{
	public interface ILibraryService
	{
		IEnumerable<IBookViewModel> GetAllBooks();
	}
}
