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
        private const string itemPriceHintText = "Enter item price here";
        private const string itemNameHintText = "Enter item name here";
        private string itemNameEntry;
        private double itemPriceEntry;
        private List<Item> itemList = new List<Item>();
        
        public ManageInventoryUserControl()
        {
            InitializeComponent();
        }

        /**
         * Adds the items to the list for final review and sets all data fields for the item object.
         * */
        private void btnAddItem_Click(object sender, EventArgs e)
        {
              try
              {
                  if (tbxItemName.Text != itemNameHintText && tbxItemName.Text != "" && itemPriceEntry != 0.0)
                  {
                    itemList.Add(new Item(itemNameEntry, itemPriceEntry));
                    resetHints();
                    updateCheckListBoxAnswers();
                      } else if(tbxItemName.Text == "" || tbxItemName.Text == itemPriceHintText && 
                                itemPriceEntry == 0.0 || tbxEnterItemPrice.Text == itemPriceHintText)
                      {
                    lblEnterItemNameHint.Text = "Please enter an item name";
                    lblPriceHint.Text = "Please enter an item price in double format";
                      }  
              }catch(NullReferenceException nullReferenceException)
              {
                  if(nullReferenceException != null)
                  {
                      Console.WriteLine("NullReferenceException when adding item. Continuing...");
                  }
              }             
        }

        /**
         * Removes selected items from the itemList data source and refreshes checked list box accordingly.
         * */
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndices.Count < 1)
            {
                MessageBox.Show(this, "Please select answer to be deleted");
            }
            else
            {
                for (int i = checkedListBox1.Items.Count -1; i >= 0; i--)
                {
                    if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                    {
                        itemList.RemoveAt(i);
                    }
                }
                updateCheckListBoxAnswers();
            }
        }

        /**
         * Removes item name text box hint on click.
         * */
        private void tbxItemName_Click(object sender, EventArgs e)
                {
                    if (tbxItemName.Text == itemNameHintText)
                    {
                        tbxItemName.Text = null;
                    }
                }

        /**
         * Sets the local itemNameEntry variable to what is entered in the text box
         * */
        private void tbxItemName_TextChanged(object sender, EventArgs e)
        {
            itemNameEntry = tbxItemName.Text;
        }

        /**
         * Sets Tab Key after Item Name text box
         * */
        private void tbxItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                tbxEnterItemPrice.Focus();
            }
        }

         /**
         * Sets Item Price Text Box to empty when it is clicked on.
         * */
        private void tbxEnterItemPrice_Click(object sender, EventArgs e)
        {
            if (tbxEnterItemPrice.Text == itemPriceHintText)
            {
                tbxEnterItemPrice.Text = null;
            }
        }       

        /**
        * Sets the item price variable and checks that it is a double.
         * */
        private void tbxEnterItemPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if(itemPriceEntry != 0.0)
                {
                    lblPriceHint.Text = "";
                }
                itemPriceEntry = double.Parse(tbxEnterItemPrice.Text);
            }
            catch (FormatException formatException)
            {
                if (formatException != null)
                {
                    Console.WriteLine("Format Exception occured on price entry. Continuing...");
                    tbxEnterItemPrice.Text = null;
                } 
            }
        }

        /**
        ///Refreshes the checkedListBox
        /*/
        private void updateCheckListBoxAnswers()
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = itemList;
        }

        private void resetHints()
        {
            lblEnterItemNameHint.Text = null;
            lblPriceHint.Text = null;
        }
    }
}
