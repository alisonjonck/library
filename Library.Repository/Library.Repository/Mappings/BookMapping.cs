using FluentNHibernate.Mapping;
using Library.Domain.Models;

namespace Library.Repository
{
	public class BookMapping : ClassMap<BookModel>
	{
		public BookMapping()
		{
			Table("books");
			Id(x => x.Id);
		}
	}
}
