using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    /**
     * Class to create item object including all setters and getters.
     * */
    class Item
    {
        private string itemName;
        private int itemNumber;
        private double itemPrice;

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public string getItemName()
        {
            return itemName;
        }

        public void setItemNumber(int itemNumber)
        {
            this.itemNumber = itemNumber;
        }

        public int getItemNumber()
        {
            return itemNumber;
        }

        public void setItemPrice (double itemPrice)
        {
            this.itemPrice = itemPrice;
        }

        public double getItemPrice()
        {
            return itemPrice;
        }
    }
}
