using System.Collections.Generic;
namespace GroceryStoreApp
{
	public class Customers
	{
		private static Customers _customers;
		private List<CustomerUser> CustomerList = new();

		protected Customers()
        {
            // Constructor
        }
		public static Customers CreateObject()
		{
			if (_customers == null) _customers = new Customers();
			return _customers;
		}
		public void AddCustomer(CustomerUser _User)
		{
			CustomerList.Add(_User);
		}
		public void DeleteCustomer(CustomerUser _User)
		{
			CustomerList.Remove(_User);
		}
		public List<CustomerUser> GetList()
		{
			return CustomerList;
		}
		public bool IsInCustomerList(CustomerUser _User)
		{
            foreach (var item in CustomerList)
            {
                if (_User.Username == item.Username && _User.Password == item.Password)
                {
					return true;
                }
            }
			return false;
		}
	}
}