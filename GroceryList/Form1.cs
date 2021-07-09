using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryList
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> itemList = new Dictionary<string, double>(){
        {"Milk", 25.00},
        {"Bread", 10.00},
        {"Wine", 32.00},
        {"Cheese", 15.00},
        {"Bacon", 19.99}
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedItem = lstBoxSell.SelectedItem.ToString();
            lstBoxBuy.Items.Add(selectedItem);
            double price = Convert.ToDouble(lblPrice.Text) +  itemList[selectedItem];
            lblPrice.Text = String.Format("{0:0.00}", price);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
             //Checks for Empty List Selection
            if(lstBoxBuy.SelectedItem != null)
            {
                string selectedItem = lstBoxBuy.SelectedItem.ToString();
                lstBoxBuy.Items.Remove(selectedItem);
                double price = Convert.ToDouble(lblPrice.Text) - itemList[selectedItem];
                lblPrice.Text = String.Format("{0:0.00}", price);
            }  
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxBuy.Items.Clear();
            lblPrice.Text = String.Format("{0:0.00}", 0);
        }
    }
}
