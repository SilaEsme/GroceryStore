using System.ComponentModel;
using System.Drawing;

namespace GroceryStoreApp
{
    public class GroceryItems : INotifyPropertyChanged
    {
        private string name;
        private double price;
        private string description;
        private Image picture;

        public GroceryItems()
        {
        }

        public GroceryItems(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Image Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
                OnChanged("Picture");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnChanged("Name");
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnChanged("Price");
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnChanged("Description");
            }
        }

        protected void OnChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}