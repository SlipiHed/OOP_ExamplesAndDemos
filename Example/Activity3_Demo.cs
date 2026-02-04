using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Activity3_Demo : Form
    {
        public Activity3_Demo()
        {
            InitializeComponent();
        }

        //
        // variables
        //        
        float temp_quantity = 0;
        float temp_price = 0;
        float temp_discountAmount = 0;
        float temp_DiscountedAmount = 0;

        float currently_appliedDiscount = 0;
        string currently_nameOfOrder = "";
        
        float cash_rendered = 0;

        float total_quantity = 0;
        float total_discountGiven = 0;
        float total_discountedAmount = 0;
        float total_change = 0;

        float temp_currentOrderPrice = 0;

        // Price of items
        float Order1_price = 100.00f;
        float Order2_price = 200.00f;

        // Name of items
        string Order1_name = "Ice Cream Sundae";
        string Order2_name = "Cheese burger + fries";

        //
        // Helper Functions
        // 
        private void updateDisplay()
        {
            txtbox_NameOfItem.Text = currently_nameOfOrder;
            txtbox_Quantity.Text = temp_quantity.ToString();
            txtbox_Price.Text = temp_price.ToString("F2");
            txtbox_DiscountAmount.Text = temp_discountAmount.ToString("F2");
            txtbox_DiscountedAmount.Text = temp_DiscountedAmount.ToString("F2");
        }

        private void resetDisplay()
        {
            txtbox_NameOfItem.Text = "";
            txtbox_Quantity.Text = "0";
            txtbox_Price.Text = "0.00";
            txtbox_DiscountAmount.Text = "0.00";
            txtbox_DiscountedAmount.Text = "0.00";
        }
        private void calculateOrder()
        {
            temp_price = temp_quantity * temp_currentOrderPrice;
            temp_discountAmount = temp_price * currently_appliedDiscount;
            temp_DiscountedAmount = temp_price - temp_discountAmount;
        }
        private void resetOrder()
        {           
            temp_quantity = 0;
            temp_price = 0;
            temp_discountAmount = 0;
            temp_DiscountedAmount = 0;

            currently_appliedDiscount = 0;
            currently_nameOfOrder = "";

        }

        private void addToTotals()
        {
            total_quantity += temp_quantity;
            total_discountGiven += temp_discountAmount;
            total_discountedAmount += temp_DiscountedAmount;
        }

        private void displayTotals()
        {
            txtbox_totalquantity.Text = total_quantity.ToString();
            txtbox_totalDiscountGiven.Text = total_discountGiven.ToString("F2");
            txtbox_TotalDiscountedAmount.Text = total_discountedAmount.ToString("F2");
        }

        private void resetTotals()
        {
            total_quantity = 0;
            total_discountGiven = 0;
            total_discountedAmount = 0;
            txtbox_totalquantity.Text = "0";
            txtbox_totalDiscountGiven.Text = "0.00";
            txtbox_TotalDiscountedAmount.Text = "0.00";

            txtbox_cashrendered.Text = "";
            txtbox_totalchange.Text = "";
        }
        //
        // WHEN PICTURE BOXES ARE CLICKED
        //
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // set default discount to 0
            radiobtn_Discount.Checked = true;

            // set value based on picturebox clicked
            temp_currentOrderPrice = Order1_price;
            currently_nameOfOrder = Order1_name;

            /*
            Example ng Hard coded: (mas mahirap i copy paste, also if mag palit ng name hiwahiwalay, compared pag dikit dikit mga varibales sa iisang section)
            basta general rule: prevent random values like strings and numbers, always use variables when performing calculations etc.
            
            currently_nameOfOrder = "Ice Cream Sundae";
            
            */

            // increase curr qunatity if clicked again
            temp_quantity++;

            // calculate stuff
            calculateOrder();
            /* move to helper function for cleaner code (hard coded pa value neto dati ;-;, also para mas madali i copy-psate sa multiple textbox)
            temp_price += temp_currentOrderPrice;
            temp_quantity++;            
            temp_discountAmount = temp_currentOrderPrice * currently_appliedDiscount;
            temp_DiscountedAmount = (temp_quantity * temp_price) - temp_discountAmount;
            */

            // display stuff
            updateDisplay();
            /* move to helper function for cleaner code 
            txtbox_NameOfItem.Text = Order1_name;
            txtbox_Quantity.Text = temp_quantity.ToString();
            txtbox_Price.Text = temp_price.ToString("F2");
            txtbox_DiscountAmount.Text = temp_discountAmount.ToString("F2");
            txtbox_DiscountedAmount.Text = temp_DiscountedAmount.ToString("F2");
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // set default discount to 0
            radiobtn_Discount.Checked = true;

            // set value based on picturebox clicked
            temp_currentOrderPrice = Order2_price;
            currently_nameOfOrder = Order2_name;

            // increase curr qunatity if clicked again
            temp_quantity++;

            // calculate stuff
            calculateOrder();         

            // display stuff
            updateDisplay();
        }


        //
        // Apply discount based on radio button clicked (default = 0)
        // Based sa book: Senior = 30% Card = 0.10% Employee = 15%
        //

        private void radiobtn_Discount_CheckedChanged(object sender, EventArgs e)
        {
            currently_appliedDiscount = 0;
            calculateOrder();
            updateDisplay();
        }

        private void radiobtn_Employee_CheckedChanged(object sender, EventArgs e)
        {
            currently_appliedDiscount = 0.15f;
            calculateOrder();
            updateDisplay();
        }

        private void radiobtn_Card_CheckedChanged(object sender, EventArgs e)
        {
            currently_appliedDiscount = 0.10f;
            calculateOrder(); 
            updateDisplay();
        }

        private void radiobtn_Senior_CheckedChanged(object sender, EventArgs e)
        {
            currently_appliedDiscount = 0.30f;
            calculateOrder(); 
            updateDisplay();
        }

        //
        // Calcuate, new, cancel, exit buttons
        //

        private void btn_New_Click(object sender, EventArgs e)
        {
            resetOrder();
            resetDisplay();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            addToTotals();
            displayTotals();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // reset everything to 0
            resetOrder();
            resetDisplay();
            // also reset totals
            resetTotals();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // close the form when exit button is clicked   
            this.Close();
        }


        // 
        // CODE FOR CALCULATOR STUFF
        //

        // side note: honestly di q alam para san ung operations, wala ding example / code sa book ;-; or bulag lang ako

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            // calculate stuff
            cash_rendered = float.Parse(txtbox_cashrendered.Text);
            total_change = cash_rendered - total_discountedAmount;

            // display final change
            txtbox_totalchange.Text = total_change.ToString("F2");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtbox_cashrendered.Text += "9";
        }
    }
}
