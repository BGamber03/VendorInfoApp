using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorInfoApp
{
    public partial class VendorInfo : Form
    {
        public VendorInfo()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Retrieve vendor details
            string vendorName = txtName.Text;
            string company = txtCompany.Text;
            string phone = txtCell.Text;
            string city = lstCity.GetItemText(lstCity.SelectedItem);

            // 2. Determine selected product
            string product = "";
            if (rdCoffee.Checked)
            {
                product = "Coffee Beans";
            }
            else if (rdGreenTea.Checked)
            {
                product = "Green Tea";
            }
            else if (rdHerbs.Checked)
            {
                product = "Herbs";
            }

            // 3. Determine selected dairy product (Check for selection and avoid an empty string)
            string dairyProduct = "";
            if (rdMilk.Checked)
            {
                dairyProduct = "Milk";
            }
            else if (rdCream.Checked)
            {
                dairyProduct = "Cream";
            }

            // Optional: Handle cases where no dairy product is selected
            if (string.IsNullOrEmpty(dairyProduct))
            {
                dairyProduct = "no dairy product";
            }

            // 4. Determine delivery status
            string deliveryStatus = "";
            if (ckOntime.Checked)
            {
                deliveryStatus = "on time";
            }
            else if (ckDelayed.Checked)
            {
                deliveryStatus = "delayed";
            }

            // 5. Determine payment status
            string paymentStatus = "";
            if (ckPaid.Checked)
            {
                paymentStatus = "paid";
            }
            else if (ckUnpaid.Checked)
            {
                paymentStatus = "unpaid";
            }

            // 6. Construct the final message to show in the MessageBox
            string message = $"The vendor is {vendorName}, from {company}, they delivered {product}, {dairyProduct}, {deliveryStatus} and {paymentStatus}.";

            // 7. Show the message in a MessageBox
            MessageBox.Show(message, "Vendor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }


        private void ckOntime_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}