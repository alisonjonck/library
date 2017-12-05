using Library.Domain.Interfaces.ViewModels;
using Library.Domain.Models;

namespace Library.Domain.ViewModels
{
	public class BookViewModel : IBookViewModel
	{
		private long _id;

		public BookViewModel(BookModel book)
		{
			_id = book.Id;
		}

		public long Id { get { return _id; } }
	}
}
