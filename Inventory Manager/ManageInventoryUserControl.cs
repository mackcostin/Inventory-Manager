using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class ManageInventoryUserControl : UserControl
    {
        private string itemNameEntry;
        private double itemPriceEntry;
        private List<Item> itemList = new List<Item>();
        private List<Item> itemToBeRemoved = new List<Item>();
        
        public ManageInventoryUserControl()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //               checkedListBox1.Items.Add(item.getItemName().PadRight(30) + item.getItemPrice());
            checkedListBox1.DataSource = null;
            itemList.Add(new Item(itemNameEntry));
            checkedListBox1.DataSource = itemList;
            checkedListBox1.DisplayMember = "Item Name";  
               

                

            }catch(NullReferenceException nre)
            {
                if(nre != null)
                {
                    Console.WriteLine("NullReferenceException when adding item: \n" + nre);
                }
            }           
            
        }

        private void tbxItemName_TextChanged(object sender, EventArgs e)
        {
            itemNameEntry = tbxItemName.Text;
        }

        private void tbxItemName_Click(object sender, EventArgs e)
        {
            if (tbxItemName.Text == "Enter item name here")
            {
                tbxItemName.Text = null;
            }
        }

        private void tbxEnterItemPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemPriceEntry = double.Parse(tbxEnterItemPrice.Text);
            }catch(FormatException x)
            {
                if(e != null)
                {
                    Console.WriteLine("FormatException on price entry: \n" + x);
                }
            }          
        }

        private void tbxEnterItemPrice_Click(object sender, EventArgs e)
        {
            if (tbxEnterItemPrice.Text == "Enter item price here")
            {
                tbxEnterItemPrice.Text = null;
            }
        }

        private void tbxItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                tbxEnterItemPrice.Focus();
            }
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
        }
    }
}
