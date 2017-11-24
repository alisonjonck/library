using Library.WebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace Library.WebApp.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			HomeController controller = new HomeController();
			Assert.IsNotNull(controller.Index() as ViewResult);
		}
	}
}
