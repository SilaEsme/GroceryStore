namespace GroceryStoreApp
{
    public class LoginedCustomer
    {
        private static LoginedCustomer _loginedCustomer;

        private CustomerUser customerUser;

        public CustomerUser CustomerUser
        {
            get { return customerUser; }
            set { customerUser = value; }
        }

        protected LoginedCustomer()
        {
        }

        public static LoginedCustomer Instance()
        {
            if (_loginedCustomer == null) _loginedCustomer = new LoginedCustomer();
            return _loginedCustomer;
        }
    }
}