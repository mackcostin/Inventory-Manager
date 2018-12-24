using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    class InventoryItem
    {

        public int inventoryID { set; get; }
        public string itemName { set; get; }
        public int itemNumber { set; get; }
        public double itemPrice { set; get; }

        public InventoryItem(string itemName,int itemNumber , double itemPrice)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemNumber = itemNumber;
        }

        public override string ToString()
        {
            return string.Format(itemName + "\t" + itemNumber);
        }
    }
}
