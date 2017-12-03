using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.IO;

namespace Library.Repository
{
	public static class FluentConfiguration
	{
		private static string _dataBaseName = "library.db";

		public static ISessionFactory CreateSessionFactory()
		{
			return Fluently.Configure()
			  .Database(SQLiteConfiguration.Standard.UsingFile(_dataBaseName))
			  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<BookMapping>())
			  .ExposeConfiguration(BuildSchema)
			  .BuildSessionFactory();
		}

		private static void BuildSchema(Configuration config)
		{
			// delete the existing db on each run
			if (File.Exists(_dataBaseName))
				File.Delete(_dataBaseName);

			// this NHibernate tool takes a configuration (with mapping info in)
			// and exports a database schema from it
			new SchemaExport(config)
			  .Create(false, true);
		}
	}
}
