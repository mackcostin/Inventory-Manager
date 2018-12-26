using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager.User_Controls
{
    public partial class AddInventoryUserControl : UserControl
    {
        #region UC Variables
        private const string itemPriceHintText = "Enter item price here";
        private const string itemNameHintText = "Enter item name here";
        private const string itemNumberHintText = "Enter item number here";
        private string itemNameEntry;
        private double itemPriceEntry;
        private int itemNumberEntry;
        private List<InventoryItem> itemList = new List<InventoryItem>();
        private HashSet<InventoryItem> hashSet = new HashSet<InventoryItem>();
        #endregion

        public AddInventoryUserControl()
        {
            InitializeComponent();
        }

        #region UC Event Handlers
        /**
         * Adds the items to the list for final review and sets all data fields for the item object.
         * */
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (checkFormEntries() == true)
                {
                    InventoryItem newItem = new InventoryItem(itemNameEntry, itemNumberEntry, itemPriceEntry);
                    if (checkDuplicates(newItem) == true)
                    {
                        MessageBox.Show("InventoryItem with that item number already added to list! Cannot contain duplicate entries.");
                        resetFormEntry();
                    }
                    else
                    {
                        itemList.Add(newItem);
                        updateCheckListBoxAnswers();
                        resetFormEntry();
                        itemList.ForEach(Console.WriteLine);
                    }
                }
            }
            catch (NullReferenceException nullReferenceException)
            {
                if (nullReferenceException != null)
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
            if (checkedListBox1.SelectedIndices.Count < 1)
            {
                MessageBox.Show(this, "Please select answer to be deleted");
            }
            else
            {
                for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
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
         * Sends the data to the DAC class -
         * Adds the relevant data to the SQL database.
         * */
        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
        }

        /**
         * Removes item name text box hint when clicked.
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
         * Sets the local itemNumberEntry variable to value entered in text box.
         * */
        private void tbxEnterItemNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemNumberEntry = int.Parse(tbxEnterItemNumber.Text);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("FormatException occured: \n" + formatException + "Continuing...");
            }
        }

        /**
         * Removes item number text box hint when clicked.
         * */
        private void tbxEnterItemNumber_Click(object sender, EventArgs e)
        {
            if (tbxEnterItemNumber.Text == itemNumberHintText)
            {
                tbxEnterItemNumber.Text = null;
            }
        }

        /**
        * Sets InventoryItem Price Text Box to empty when it is clicked on.
        * */
        private void tbxEnterItemPrice_Click(object sender, EventArgs e)
        {
            if (tbxEnterItemPrice.Text == itemPriceHintText)
            {
                tbxEnterItemPrice.Text = null;
            }
        }

        /**
         * Takes input from the user and catches error if input format is wrong.
         * */
        private void tbxEnterItemPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemPriceEntry = double.Parse(tbxEnterItemPrice.Text);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("FormatException occured: \n" + formatException + "Continuing...");
            }

        }
        #endregion

        #region UC refreshing
        /**
        ///Refreshes the checkedListBox
        /*/
        private void updateCheckListBoxAnswers()
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = itemList;
        }

        /**
         * Resets the form.
         * */
        private void resetFormEntry()
        {
            lblEnterItemNameHint.Text = null;
            lblEnterPriceHint.Text = null;
            lblEnterItemNumberHint.Text = null;
            tbxEnterItemPrice.Text = itemPriceHintText;
            tbxItemName.Text = itemNameHintText;
            tbxEnterItemNumber.Text = itemNumberHintText;
            itemNameEntry = null;
            itemPriceEntry = 0;
            itemNumberEntry = 0;
        }
        #endregion

        #region UC Entries Validation
        /**
         * This method checks that all entries in the form are valid and
         * returns true if cleared or false if not cleared.
         * */
        private bool checkFormEntries()
        {
            if (tbxItemName.Text != itemNameHintText &&
                tbxItemName.Text != "" && itemPriceEntry != 0 &&
                itemNumberEntry != 0)
            {
                return true;
            }

            if (String.IsNullOrWhiteSpace(tbxItemName.Text) || tbxItemName.Text == itemNameHintText)
            {
                itemNameEntry = null;
                tbxItemName.Text = itemNameHintText;
                lblEnterItemNameHint.Text = itemNameHintText;
            }
            else
            {
                lblEnterItemNameHint.Text = null;
            }

            if (itemNumberEntry == 0 || tbxEnterItemNumber.Text == itemNumberHintText)
            {
                itemNumberEntry = 0;
                tbxEnterItemNumber.Text = itemNumberHintText;
                lblEnterItemNumberHint.Text = "Please enter a valid item number";
            }
            else
            {
                lblEnterItemNumberHint.Text = null;
            }

            if (itemPriceEntry == 0 || tbxEnterItemPrice.Text == itemPriceHintText)
            {
                itemPriceEntry = 0;
                tbxEnterItemPrice.Text = itemPriceHintText;
                lblEnterPriceHint.Text = "Please enter a price of double format";
            }
            else
            {
                lblEnterPriceHint.Text = null;
            }

            return false;


        }

        /**
         * Checks if new item has the same item number as an existing item in the list.
         * */
        private bool checkDuplicates(InventoryItem newItem)
        {

            foreach (InventoryItem item in itemList)
            {
                if (item.itemNumber == newItem.itemNumber)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
