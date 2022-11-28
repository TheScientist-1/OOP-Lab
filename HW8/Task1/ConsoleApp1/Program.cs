using System;
using System.Collections.Generic;
//В програмі було порушено принцип єдиного обов'язку
//Виправимо:
namespace Task1
{
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

    }
    class OrderViewer
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }
    class ItemStorage
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
   

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}