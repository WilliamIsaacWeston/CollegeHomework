using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class FormMainWindow : Form
    {
        double subtotal = 0.0;
        double gratuity = 0.0;

        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void radioButtonSixInch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSixInch.Checked)
            {
                subtotal += 5.0;
            }
            else
            {
                subtotal -= 5.0;
            }

            this.onAnyChange(sender, e);
        }

        private void radioButtonNineInch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNineInch.Checked)
            {
                subtotal += 8.0;
            }
            else
            {
                subtotal -= 8.0;
            }

            this.onAnyChange(sender, e);
        }

        private void radioButtonTwelveInch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTwelveInch.Checked)
            {
                subtotal += 10.0;
            }
            else
            {
                subtotal -= 10.0;
            }

            this.onAnyChange(sender, e);
        }

        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheese.Checked)
            {
                subtotal += 1.0;
                radioButtonAmerican.Enabled = true;
                radioButtonProvolone.Enabled = true;
                radioButtonCheddar.Enabled = true;
            }
            else
            {
                subtotal -= 1.0;
                radioButtonAmerican.Enabled = false;
                radioButtonProvolone.Enabled = false;
                radioButtonCheddar.Enabled = false;
            }

            this.onAnyChange(sender, e);
        }

        private void textBoxGratuity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gratuity = Double.Parse(textBoxGratuity.Text);
            }
            catch(Exception)
            {
                gratuity = 0.0;
            }

            this.onAnyChange(sender, e);
        }

        private void onAnyChange(object sender, EventArgs e)
        {
            double tax = subtotal * 0.06;
            double total = subtotal + tax + gratuity;

            labelSubtotalAmount.Text = String.Format("{0:C}", subtotal);
            labelTaxAmount.Text = String.Format("{0:C}", tax);
            labelGratuityAmount.Text = String.Format("{0:C}", gratuity);
            labelTotalAmount.Text = String.Format("{0:C}", total);
        }
    }
}
