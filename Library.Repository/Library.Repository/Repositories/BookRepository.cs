using Library.Domain.Models;
using NHibernate;
using System.Collections.Generic;

namespace Library.Repository.Repositories
{
	public class BookRepository
	{
		private readonly ISession _session = FluentAPI.GetCurrentSession();
		public BookRepository()
		{
		}

		public IList<BookModel> GetAllBooks()
		{
			var bookCriteria = _session.CreateCriteria<BookModel>();
			return bookCriteria.List<BookModel>();
		}
	}
}
