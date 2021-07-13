using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace GroceryStoreApp
{
    public class ShoppingCart : INotifyCollectionChanged
    {
        private readonly ObservableCollection<CartItem> shoppingCartList;

        public ObservableCollection<CartItem> ShoppingCartList
        {
            get => shoppingCartList;
        }

        public ShoppingCart()
        {
            shoppingCartList = new ObservableCollection<CartItem>();
            shoppingCartList.CollectionChanged += ShoppingCartList_CollectionChanged;
        }

        private void ShoppingCartList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            UserControlShoppingCart.Instance().ListShoppingCart();
        }


        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }

    public struct CartItem
    {
        private GroceryItems grocery_item;
        private static int amount;

        public CartItem(GroceryItems item, int _amount)
        {
            grocery_item = item; amount = _amount;
        }

        public GroceryItems Grocery_item
        {
            get
            {
                return grocery_item;
            }
            set
            {
                grocery_item = value;
            }
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public void UpdateAmount(int amount)
        {
            this.Amount = amount;
        }

        public void IncreaseAmount()
        {
            amount++;
        }
    }
}