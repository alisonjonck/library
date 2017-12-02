using Library.Domain.Models;
using NUnit.Framework;

namespace Library.Domain.Test.Models
{
	public class BookModelTest
	{
		[Test]
		public void TestBookModelInstance()
		{
			var model = new BookModel();

			Assert.IsNotNull(model);
			Assert.IsInstanceOf<BookModel>(model);
		}
	}
}
