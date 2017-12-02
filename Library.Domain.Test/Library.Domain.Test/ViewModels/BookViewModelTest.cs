using Library.Domain.Interfaces;
using Library.Domain.ViewModels;
using NUnit.Framework;

namespace Library.Domain.Test.ViewModels
{
	[TestFixture]
	public class BookViewModelTest
	{
		[Test]
		public void TestBookViewModelIsInstanceOfIBookViewModel()
		{
			var viewModel = new BookViewModel();

			Assert.IsNotNull(viewModel);
			Assert.IsInstanceOf<IBookViewModel>(viewModel);
		}
	}
}
