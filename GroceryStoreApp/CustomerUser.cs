namespace GroceryStoreApp
{
    public class CustomerUser
    {
        private string name;
        private string address;
        private string telephone;
        private string username;
        private string password;
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address=value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone=value; }
        }
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

        public CustomerUser()
        {
        }

        public CustomerUser(string _name, string _address, string _telephone, string _username, string _password)
        {
            name = _name;
            address = _address;
            telephone = _telephone;
            username = _username;
            password = _password;
        }
    }
}