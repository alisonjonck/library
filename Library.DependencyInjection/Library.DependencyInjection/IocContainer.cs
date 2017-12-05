using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;
using Library.Domain.Interfaces.ViewModels;
using Library.Domain.Services;
using Library.Domain.ViewModels;
using Library.Repository.Repositories;

namespace DryIoc
{
	public partial class Container
	{
		public void RegisterAllModules()
		{
			this.Register<IBookViewModel, BookViewModel>();
			this.Register<IBookRepository, BookRepository>();

			this.Register<ILibraryService, LibraryService>();
		}
	}
}
