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
    public partial class scratch : Form
    {
        
        public scratch()
        {
            InitializeComponent();
            
        }

        //
        // helper functions
        //
        private void temp_process_and_output()
        {
            // process
            var_price = var_current_price * var_quantity;
            var_discountAmount = var_price * var_current_discount;
            var_discountedAmount = var_price - var_discountAmount;

            // output
            txtbox_NameOfItem.Text = var_nameOfOrder;
            txtbox_Quantity.Text = var_quantity.ToString();
            txtbox_Price.Text = var_price.ToString();
            txtbox_DiscountAmount.Text = var_discountAmount.ToString();
            txtbox_DiscountedAmount.Text = var_discountedAmount.ToString();
        }

        //
        // variables
        //
        string var_nameOfOrder = "";
        float var_quantity = 0;
        float var_price = 0;
        float var_discountAmount = 0;
        float var_discountedAmount = 0;

        float var_current_price = 0;
        float var_current_discount = 0;

        float disc_nodisc = 0;
        float disc_card = 0.20f;
        float disc_senior = 0.30f;
        float disc_employee = 0.10f;

        float var_tot_quantity = 0;
        float var_tot_discountAmount = 0;
        float var_tot_discountedAmount = 0;

        float final_cashrendered = 0;
        float final_change = 0;
        
        // order name
        string order_name_1 = "Ice Cream Sundae";
        string order_name_2 = "Burger";

        // order price
        float order_price_1 = 60;
        float order_price_2 = 140;

        // input
        // process
        // output



        private void radiobtn_Discount_CheckedChanged(object sender, EventArgs e)
        {
            var_current_discount = disc_nodisc;

            temp_process_and_output();
        }

        private void radiobtn_Employee_CheckedChanged(object sender, EventArgs e)
        {
            var_current_discount = disc_employee;

            temp_process_and_output();
        }

        private void radiobtn_Card_CheckedChanged(object sender, EventArgs e)
        {
            var_current_discount = disc_card;

            temp_process_and_output();
        }

        private void radiobtn_Senior_CheckedChanged(object sender, EventArgs e)
        {
            var_current_discount = disc_senior;

            temp_process_and_output();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // input

            // process
            var_tot_quantity += var_quantity;
            var_tot_discountAmount += var_discountAmount;
            var_tot_discountedAmount += var_discountedAmount;

            // output
            txtbox_totalquantity.Text = var_tot_quantity.ToString();
            txtbox_totalDiscountGiven.Text = var_tot_discountAmount.ToString();
            txtbox_TotalDiscountedAmount.Text = var_tot_discountedAmount.ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
          
            txtbox_NameOfItem.Clear();
            txtbox_Quantity.Clear();
            txtbox_Price.Clear();
            txtbox_DiscountAmount.Clear();
            txtbox_DiscountedAmount.Clear();

            var_nameOfOrder = "";
            var_quantity = 0;
            var_price = 0;
            var_discountAmount = 0;
            var_discountedAmount = 0;

            var_current_price = 0;
            var_current_discount = 0;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            // process
            final_cashrendered = float.Parse(txtbox_cashrendered.Text);
            final_change = final_cashrendered - var_tot_discountedAmount;

            // output
            txtbox_totalchange.Text = final_change.ToString();
        }

        private void picbox_1_Click(object sender, EventArgs e)
        {
            // input
            var_nameOfOrder = order_name_1;
            var_current_price = order_price_1;
            var_quantity++;

            temp_process_and_output();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // input
            var_nameOfOrder = order_name_2;
            var_current_price = order_price_2;
            var_quantity++;

            temp_process_and_output();
        }

        private void scratch_Load(object sender, EventArgs e)
        {

        }
    }
}
