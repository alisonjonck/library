using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;
using Library.Domain.Interfaces.ViewModels;
using Library.Domain.ViewModels;
using System.Collections.Generic;

namespace Library.Domain.Services
{
	public class LibraryService : ILibraryService
	{
		private readonly IBookRepository _bookRepository;
		public LibraryService(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public IEnumerable<IBookViewModel> GetAllBooks()
		{
			var booksViewModel = new List<IBookViewModel>();

			foreach (var book in _bookRepository.GetAllBooks())
			{
				booksViewModel.Add(new BookViewModel(book));
			}

			return booksViewModel;
		}
	}
}
