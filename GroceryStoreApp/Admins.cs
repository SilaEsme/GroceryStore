using System.Collections.Generic;
namespace GroceryStoreApp
{
	public class Admins
	{
		private List<AdminUser> AdminList = new();
		public void AddAdmin(AdminUser _User)
		{
			AdminList.Add(_User);
		}
		public void DeleteAdmin(AdminUser _User)
		{
			AdminList.Remove(_User);
		}
		public List<AdminUser> GetList()
		{
			return AdminList;
		}
		public bool IsInAdminList(AdminUser _User)
		{
			return AdminList.Contains(_User);
		}
	}
}