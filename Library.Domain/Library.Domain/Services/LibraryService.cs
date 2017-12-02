using Library.Domain.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library.Domain
{
	public class LibraryService : ILibraryService
	{
		public IEnumerable<IBookViewModel> GetAllBooks()
		{
			return new Collection<IBookViewModel>();
		}
	}
}
