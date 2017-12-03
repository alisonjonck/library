using NHibernate;

namespace Library.Repository.Repositories
{
	public static class FluentAPI
	{
		private static ISessionFactory _sessionFactory = FluentConfiguration.CreateSessionFactory();

		public static ISession GetCurrentSession()
		{
			return _getSession();
		}

		private static ISession _session = null;
		private static ISession _getSession()
		{
			if (_session == null)
			{
				if (_sessionFactory.IsClosed)
					_session = _sessionFactory.OpenSession();
				else
					_session = _sessionFactory.GetCurrentSession();
			}

			return _session;
		}
	}
}
