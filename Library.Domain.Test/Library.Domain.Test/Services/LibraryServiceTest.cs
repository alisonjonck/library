using Library.Domain.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace Library.Domain.Test
{
	[TestFixture]
	public class LibraryServiceTest
	{
		private ILibraryService _libraryService;
		
		[SetUp]
		public void SetUp()
		{
			_libraryService = new LibraryService();
		}

		[Test]
		public void TestGetAllBooksReturnsIEnumerableIBookViewModel()
		{
			var books = _libraryService.GetAllBooks();

			Assert.IsNotNull(books);
			Assert.IsInstanceOf<IEnumerable<IBookViewModel>>(books);
		}
	}
}