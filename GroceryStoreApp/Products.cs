using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace GroceryStoreApp
{
    public class Products
    {
        private static Products _object;
        private GroceryItems groceryItems;
        private List<GroceryItems> ProductList = new List<GroceryItems>();

        protected Products()
        {
            /// Constructor
        }

        public static Products Instance()
        {
            if (_object == null)
            {
                _object = new Products();
            }
            return _object;
        }

        public void AddGroceryItem(GroceryItems _Product)
        {
            ProductList.Add(_Product);
        }

        public void DeleteGroceryItem(GroceryItems _Product)
        {
            ProductList.Remove(_Product);
        }

        public List<GroceryItems> GetList()
        {
            return ProductList;
        }

        public bool IsInGroceryItemList(GroceryItems _Product)
        {
            return ProductList.Contains(_Product);
        }

    }
}