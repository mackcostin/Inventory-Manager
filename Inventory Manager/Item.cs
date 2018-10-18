using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    class Item
    {
        private string itemName;
        private int itemNumber;
        private double itemPrice;

        public Item(string itemName,int itemNumber , double itemPrice)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemNumber = itemNumber;
        }

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public string getItemName()
        {
            return itemName;
        }

        /**
         * TO DO:
         * MUST QUERY SQL TO SEE IF ITEM EXISTS
         * */
        public void setItemNumber(int itemNumber)
        {
            this.itemNumber = itemNumber;
        }

        public int getItemNumber()
        {
            return itemNumber;
        }

        public void setItemPrice(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }

        public double getItemPrice()
        {
            return itemPrice;
        }

        public override string ToString()
        {
            return string.Format(itemName + "\t" + itemNumber);
        }
    }
}
