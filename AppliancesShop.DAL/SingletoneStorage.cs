namespace AppliancesShop.DAL
{
	public class SingletoneStorage
	{
		private static SingletoneStorage _object = null;

		public Context Context { get; private set; }

		private SingletoneStorage()
		{
			Context = new Context();
		}

		public static SingletoneStorage GetStorage()
		{
			if (_object is null)
			{
				_object = new SingletoneStorage();
			}
			return _object;
		}
	}
}
