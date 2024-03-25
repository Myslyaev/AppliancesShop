namespace AppliancesShop.DAL
{
	public class Options
	{
		public static string connectionString
		{
			get
			{
				var a = Environment.GetEnvironmentVariable("AppliancesShopDB");

				return a;
			}
		}
	}
}
