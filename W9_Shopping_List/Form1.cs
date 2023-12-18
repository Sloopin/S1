using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W9_Shopping_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> itemName = new List<string>();
        List<double> itemPrice = new List<double>();
        List<int> itemAmount = new List<int>();

        List<string> itemNameFiltered = new List<string>();
        List<double> itemPriceFiltered = new List<double>();
        List<int> itemAmountFiltered = new List<int>();


        //Method to check if input is integer
        private bool IsInt(string inputString)
        {
            if (!int.TryParse(inputString, out int result))
            {
                MessageBox.Show("Please input a valid amount", "Error");
                return false;
            } else
            {
                return true;
            }
        }

        //Method to check if input is double
        private bool IsDouble(string inputString)
        {
            if (!double.TryParse(inputString, out double result))
            {
                MessageBox.Show("Please input a valid price", "Error");
                return false;
            } else
            {
                return true;
            }
        }


        //Method to add new item
        private bool AddItem(string name, string price, string amount)
        {
            bool isValid;

            if (string.IsNullOrEmpty(price))
            {
                price = "0";
            }

            if (string.IsNullOrEmpty(amount) || amount == "0")
            {
                amount = "1";
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid item name", "Error");
                isValid = false;
                return isValid;
            }


            if (IsDouble(price)
                && IsInt(amount)
                && !itemName.Contains(name))
            {
                itemName.Add(name);
                itemPrice.Add(Math.Round(Convert.ToDouble(price), 2));
                itemAmount.Add(Convert.ToInt32(amount));

                isValid = true;
            } 
            else if (itemName.Contains(name))
            {
                MessageBox.Show("Item already in list", "Warning!");
                isValid = false;
            } 
            else
            {
                isValid = false;
            }

            return isValid;
        }

        //Method to show all items in the listbox
        private void ShowAllItems()
        {
            lbxItems.Items.Clear();

            string entry;

            for (int i=0; i<itemName.Count; i++)
            {
                entry = itemName[i] + ": \t$" + itemPrice[i].ToString() + "\tx" + itemAmount[i].ToString();

                lbxItems.Items.Add(entry);
            }
        }

        //Method to calculate total price
        private double CalculateTotal()
        {
            double totalPrice = 0;

            for (int i=0; i<itemName.Count; i++)
            {
                totalPrice = totalPrice + (itemPrice[i] * itemAmount[i]);
            }

            return totalPrice;
        }

        //Method to calculate total price after filtering
        private double CalculateTotalAfterFilter()
        {
            double totalPriceAfterFilter = 0;

            for (int i=0; i<itemNameFiltered.Count; i++)
            {
                totalPriceAfterFilter = totalPriceAfterFilter + (itemPriceFiltered[i] * itemAmountFiltered[i]);
            }

            return totalPriceAfterFilter;
        }

        //Method to determine index of selected item
        private int GetSelectedItem()
        {
            if (lbxItems.SelectedIndex != -1)
            {
                string selectedString = lbxItems.SelectedItem.ToString();
                int charLocation = selectedString.IndexOf(':');
                string substring = selectedString.Substring(0, charLocation);
                int index = itemName.IndexOf(substring);
                return index;
            } else
            {
                return -1;
            }
        }

        //Method to calculate total for selected entry
        private double CalculateTotalForEntry()
        {
            int index = GetSelectedItem();

            double totalPriceEntry = itemPrice[index] * itemAmount[index];
            return totalPriceEntry;
        }

        //Method to remove selected item
        private void RemoveItem(int index)
        {

            if (index == -1)
            {
                return;
            }

            itemName.RemoveAt(index);
            itemPrice.RemoveAt(index);
            itemAmount.RemoveAt(index);
        }

        //Method to filter above certain price
        private void FilterItemsByPrice(double price, bool above)
        {
            lbxItems.Items.Clear();

            itemNameFiltered.Clear();
            itemPriceFiltered.Clear();
            itemAmountFiltered.Clear();

            if (above)
            {
                for (int i = 0; i < itemName.Count; i++)
                {
                    if (itemPrice[i] >= price)
                    {
                        itemNameFiltered.Add(itemName[i]);
                        itemPriceFiltered.Add(itemPrice[i]);
                        itemAmountFiltered.Add(itemAmount[i]);
                    }
                }
            }

            if (!above)
            {
                for (int i = 0; i < itemName.Count; i++)
                {
                    if (itemPrice[i] < price)
                    {
                        itemNameFiltered.Add(itemName[i]);
                        itemPriceFiltered.Add(itemPrice[i]);
                        itemAmountFiltered.Add(itemAmount[i]);
                    }
                }
            }
            

            for (int i = 0; i<itemNameFiltered.Count; i++)
            {
                string entry = itemNameFiltered[i] + ": \t$" + itemPriceFiltered[i].ToString() + "\tx" + itemAmountFiltered[i].ToString();
                lbxItems.Items.Add(entry);
            }
        }


        //Method to filter items by substring
        private void FilterItemsBySubstring(string substr)
        {
            lbxItems.Items.Clear();

            itemNameFiltered.Clear();
            itemPriceFiltered.Clear();
            itemAmountFiltered.Clear();


            for (int i=0; i<itemName.Count; i++)
            {
                if (itemName[i].Contains(substr))
                {
                    itemNameFiltered.Add(itemName[i]);
                    itemPriceFiltered.Add(itemPrice[i]);
                    itemAmountFiltered.Add(itemAmount[i]);
                }
            }

            for (int i = 0; i < itemNameFiltered.Count; i++)
            {
                string entry = itemNameFiltered[i] + ": \t$" + itemPriceFiltered[i].ToString() + "\tx" + itemAmountFiltered[i].ToString();
                lbxItems.Items.Add(entry);
            }
        }

        //Method to filter items by user set limit
        private void FilterItemsByMoneyLimit(double limit)
        {
            lbxItems.Items.Clear();

            itemNameFiltered.Clear();
            itemPriceFiltered.Clear();
            itemAmountFiltered.Clear();

            double totalPrice = 0;

            for (int i=0; i<itemName.Count; i++)
            {
                if ((totalPrice + (itemPrice[i] * itemAmount[i])) <= limit)
                {
                    itemNameFiltered.Add(itemName[i]);
                    itemPriceFiltered.Add(itemPrice[i]);
                    itemAmountFiltered.Add(itemAmount[i]);
                } else
                {
                    break;
                }

                totalPrice = totalPrice + (itemPrice[i] * itemAmount[i]);
            }

            for (int i = 0; i < itemNameFiltered.Count; i++)
            {
                string entry = itemNameFiltered[i] + ": \t$" + itemPriceFiltered[i].ToString() + "\tx" + itemAmountFiltered[i].ToString();
                lbxItems.Items.Add(entry);
            }
        }



        //===================================================================================================================//
        //===================================================================================================================//


        //
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (AddItem(tbxItem.Text, tbxPrice.Text, tbxAmount.Text))
            {
                ShowAllItems();
            }

            tbxTotal.Text = CalculateTotal().ToString();
            tbxTotalForEntry.Text = "";

            tbxItem.Text = "";
            tbxPrice.Text = "";
            tbxAmount.Text = "";
        }

        //
        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetSelectedItem() != -1)
            {
                tbxTotalForEntry.Text = CalculateTotalForEntry().ToString();
            } else
            {
                tbxTotalForEntry.Text = "";
            }
        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
            RemoveItem(GetSelectedItem());
            lbxItems.Items.Clear();
            ShowAllItems();
            tbxTotal.Text = CalculateTotal().ToString();
            tbxTotalForEntry.Text = "";
        }

        //
        private void btnShowAllItems_Click(object sender, EventArgs e)
        {
            ShowAllItems();
            tbxTotalForEntry.Text = "";
            tbxTotal.Text = CalculateTotal().ToString();
        }

        //
        private void btnFilterAbove_Click(object sender, EventArgs e)
        {
            double abovePrice;
            tbxTotalForEntry.Text = "";

            if (IsDouble(tbxFilterPrice.Text))
            {
                abovePrice = Convert.ToDouble(tbxFilterPrice.Text);
                FilterItemsByPrice(abovePrice, true);
                tbxTotal.Text = CalculateTotalAfterFilter().ToString();
            } else
            {
                return;
            }
        }

        //
        private void btnFilterBelow_Click(object sender, EventArgs e)
        {
            double belowPrice;
            tbxTotalForEntry.Text = "";

            if (IsDouble(tbxFilterPrice.Text))
            {
                belowPrice = Convert.ToDouble(tbxFilterPrice.Text);
                FilterItemsByPrice(belowPrice, false);
                tbxTotal.Text = CalculateTotalAfterFilter().ToString();
            }
            else
            {
                return;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = tbxFilterString.Text;
            tbxTotalForEntry.Text = "";

            FilterItemsBySubstring(searchString);
            tbxTotal.Text = CalculateTotalAfterFilter().ToString();
        }

        private void btnFilterLimit_Click(object sender, EventArgs e)
        {
            double priceLimit;
            tbxTotalForEntry.Text = "";

            if (IsDouble(tbxFilterLimit.Text))
            {
                priceLimit = Convert.ToDouble(tbxFilterLimit.Text);
                FilterItemsByMoneyLimit(priceLimit);
                tbxTotal.Text = CalculateTotalAfterFilter().ToString();
            } else
            {
                return;
            }
        }
    }
}
