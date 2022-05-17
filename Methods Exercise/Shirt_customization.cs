//programmer name: Prathyusha Pinnintti
//project number: ch5 Exercise
//Description:Method exercise

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_Exercise
{
    public partial class Shirt_customization : Form
    {
        public Shirt_customization()
        {
            InitializeComponent();
        }

        private void Shirt_customization_Load(object sender, EventArgs e)
        {
            
        }

        private void txtShirtsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtShirtsize.Text == "S")
            {
                txtPlainshirtprice.Text = "10";
            }
            else if(txtShirtsize.Text == "M")
            {
                txtPlainshirtprice.Text = "11";
            }
            else if(txtShirtsize.Text == "L")
            {
                txtPlainshirtprice.Text = "12";
            }
            else if (txtShirtsize.Text == "XL")
            {
                txtPlainshirtprice.Text = "12";
            }
        }

        private void txtCustomizationtext_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < txtCustomizationtext.Text.Length; i++)
            {
                count++;
            }
            textCharacters.Text = txtCustomizationtext.Text.Length.ToString();
        }

        private void textCharacters_TextChanged(object sender, EventArgs e)
        {
            txtCustomizedShirtPrice.Text = ((Double.Parse(textCharacters.Text) * Double.Parse(txtCustomizationCharge.Text))+ Double.Parse(txtPlainshirtprice.Text)).ToString();
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            Shirt_customization shirt_Customization = new Shirt_customization();
            shirt_Customization.Show();
            this.Hide();
        }

        private void txtCustomizedShirtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            txtTotalcharge.Text = ((Double.Parse(txtCustomizedShirtPrice.Text) * Double.Parse(txtquantity.Text))).ToString();
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            rtfRECEIPT.Clear();

            rtfRECEIPT.AppendText(Environment.NewLine);
            rtfRECEIPT.AppendText("\tSHIRT PRICE:\t\t\t" + txtPlainshirtprice.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tCUSTOMIZED SHIRT PRIZE\t\t" + txtCustomizedShirtPrice.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tQUANTITY:\t\t\t" + txtquantity.Text + Environment.NewLine);
            rtfRECEIPT.AppendText("\tTOTAL CHARGE:\t\t\t" + txtTotalcharge.Text + Environment.NewLine);
         
        }
    }
}
