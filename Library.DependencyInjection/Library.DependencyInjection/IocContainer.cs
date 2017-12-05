using DryIoc;
using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;
using Library.Domain.Interfaces.ViewModels;
using Library.Domain.Services;
using Library.Domain.ViewModels;
using Library.Repository.Repositories;

namespace Library.DependencyInjection
{
	public sealed class IocContainer
	{
		private readonly Container _container;
		public IocContainer()
		{
			_container = new Container(Rules.Default.With(FactoryMethod.ConstructorWithResolvableArguments));
			Register();
		}

		private void Register()
		{
			_container.Register<IBookViewModel, BookViewModel>();
			_container.Register<IBookRepository, BookRepository>();

			_container.Register<ILibraryService, LibraryService>();
		}

		public I Resolve<I>()
		{
			return _container.Resolve<I>();
		}
	}
}
