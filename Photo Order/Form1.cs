using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            cbxSize.Items.Add("Extra Large");

            cbxSize.SelectedIndex = 0;//Select the first size
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numUpDown.Text, out int quantity) == false)
            {
                MessageBox.Show("Quantity must be a number", "Error");
                return;
            }
            if(quantity < 1)//Make sure it's positive too
            {
                MessageBox.Show("Quantity must be positive", "Error");
                return;
            }
            
            string size = cbxSize.SelectedItem.ToString();
            double price = 0;
            double totalPrice = 0;          
            
            switch(size)// switch state has size for condition
            {
                case "Small":
                    price = 0.20;
                    totalPrice = quantity * price;
                    break;              
                case "Medium":
                    price = 0.30;
                    totalPrice = quantity * price;
                    break;            
                case "Large":
                    price = 0.40;
                    totalPrice = quantity * price;
                    break;
                case "Extra Large":
                    price = 0.50;
                    totalPrice = quantity * price;
                    break;
                default:
                    MessageBox.Show("Unknown size");//Display other size other than above.
                    return; //Stop processing this event
            }
            txtPrice.Text = totalPrice.ToString("c");//Display price in currency format
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
