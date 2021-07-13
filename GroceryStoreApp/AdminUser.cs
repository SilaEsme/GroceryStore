namespace GroceryStoreApp
{
	public class AdminUser
	{
		private static AdminUser _AdminUser;//
		private string username;
		private string password;
		public string Username
		{
			get { return username; } 
			set { username = value; }
		}
		public string Password
		{
			get { return password; } 
			set { password = value; }
		}
		protected AdminUser()
		{
			/// Constructor
		}
		public static AdminUser CreateObject()
		{
			if(_AdminUser == null) _AdminUser = new AdminUser();
			return _AdminUser;
		}
	}
}