using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
	public class FluentConfiguration
	{
		private static ISessionFactory CreateSessionFactory()
		{
			return Fluently.Configure()
			  .Database(
				SQLiteConfiguration.Standard
				  .UsingFile("firstProject.db")
			  )
			  .Mappings(m =>
				m.FluentMappings.AddFromAssemblyOf<BookMapping>())
			  .ExposeConfiguration(BuildSchema)
			  .BuildSessionFactory();
		}

		private static void BuildSchema(Configuration config)
		{
			// delete the existing db on each run
			if (File.Exists(DbFile))
				File.Delete(DbFile);

			// this NHibernate tool takes a configuration (with mapping info in)
			// and exports a database schema from it
			new SchemaExport(config)
			  .Create(false, true);
		}
	}
}
