
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();

		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "1";
            }
            else
            {
                txtInput.Text = txtInput.Text + "1";
            }
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "2";
            }
            else
            {
                txtInput.Text = txtInput.Text + "2";
            }
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "3";
            }
            else
            {
                txtInput.Text = txtInput.Text + "3";
            }
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "4";
            }
            else
            {
                txtInput.Text = txtInput.Text + "4";
            }
		}
		
		void Btn5Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "5";
            }
            else
            {
                txtInput.Text = txtInput.Text + "5";
            }
		}
		
		void Btn6Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "6";
            }
            else
            {
                txtInput.Text = txtInput.Text + "6";
            }			
		}
		
		void Btn7Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "7";
            }
            else
            {
                txtInput.Text = txtInput.Text + "7";
            }			
		}
		
		void Btn8Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "8";
            }
            else
            {
                txtInput.Text = txtInput.Text + "8";
            }
		}
		
		void Btn9Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "9";
            }
            else
            {
                txtInput.Text = txtInput.Text + "9";
            }
		}
		
		void Btn0Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = "0";
            }
            else
            {
                txtInput.Text = txtInput.Text + "0";
            }
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			if (txtInput.Text == "0" && txtInput.Text != null)
            {
                txtInput.Text = ".";
            }
            else
            {
                txtInput.Text = txtInput.Text + ".";
            }
		}
		
		void BtnEnterClick(object sender, EventArgs e)
		{
			txtSubTotal.Text = txtInput.Text;
		}
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			double subtotal;
			double tax;
            double result;

            subtotal = Convert.ToDouble(txtSubTotal.Text);
            
            if (subtotal < 100)
            {
                result = (subtotal * 0.05) + subtotal;
                tax = subtotal * 0.05;
                txtTotal.Text = result.ToString();
                txtTax.Text = Convert.ToString(tax);
            }
            else if (subtotal >= 100 && subtotal <= 499)
            {
                result = (subtotal * 0.075) + subtotal;
                tax = subtotal * 0.075;
                txtTotal.Text = result.ToString();
                txtTax.Text = Convert.ToString(tax);
            }
            else if (subtotal > 499)
            {
                result = (subtotal * 0.1) + subtotal;
                tax = subtotal * 0.1;
                txtTotal.Text = result.ToString();
                txtTax.Text = Convert.ToString(tax);
            }
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if (txtInput.Text != string.Empty)
            {
                int txtlength = txtInput.Text.Length;
                if (txtlength != 1)
                {
                    txtInput.Text = txtInput.Text.Remove(txtlength - 1);
                }
                else
                {
                    txtInput.Text = 0.ToString();
                }
                
                txtSubTotal.Text = "";
                txtTax.Text = "";
                txtTotal.Text = "";
            }
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtInput.Text = "";
			txtSubTotal.Text = "";
			txtTax.Text = "";
			txtTotal.Text = "";
		}
	}
}
