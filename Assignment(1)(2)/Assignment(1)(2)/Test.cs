/* Name: Bhuvnesh Sain
 * Program: Btech <CSE>
 * Sem: 6th
 * Course: .NET Technology
 * Assignment: 1,2
 * RNB Global University */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1__2_
{
    public partial class Calculator : Form
    {
        string op;
        double first, second;
        public Calculator()
        {
            InitializeComponent();
            txtbox.Text = "0";
        }
       
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "0";
            else
                txtbox.Text = txtbox.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "1";
            else
                txtbox.Text = txtbox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "2";
            else
                txtbox.Text = txtbox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "3";
            else
                txtbox.Text = txtbox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "4";
            else
                txtbox.Text = txtbox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "5";
            txtbox.Text = txtbox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "6";
            else
                txtbox.Text = txtbox.Text + "6";
        }
        
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "7";
            else
                txtbox.Text = txtbox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "8";
            else
                txtbox.Text = txtbox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "9";
            else
                txtbox.Text = txtbox.Text + "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
                txtbox.Text = "0.";
            else if (txtbox.Text.Contains(".")) ;
            else
                txtbox.Text = txtbox.Text + ".";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbox.Text = "0";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (txtbox.Text.Length > 1)
                txtbox.Text = txtbox.Text.Substring(0, txtbox.Text.Length - 1);
            else
                txtbox.Text = "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
            first = Convert.ToDouble(txtbox.Text);
            op = "+";
            txtbox.Text = "0";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtbox.Text);
            op = "*";
            txtbox.Text = "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtbox.Text);
            op = "/";
            txtbox.Text = "0";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtbox.Text);
            op = "-";
            txtbox.Text = "0";
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtbox.Text);
            op = "%";
            txtbox.Text = "0";
        }

        private void btnans_Click(object sender, EventArgs e)
        {
            try
            {
                second = Convert.ToDouble(txtbox.Text);
                switch (op)
                {
                    case "+":
                        first += second;
                        break;
                    case "-":
                        first -= second;
                        break;
                    case "*":
                        first *= second;
                        break;
                    case "/":
                        first /= second;
                        break;
                    case "%":
                        first %= second;
                        break;
                }

                txtbox.Text = "" + first;
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error! Enter valid expression");
                txtbox.Text = "0";
                first = 0.0;
                second = 0.0;
            
            }
        }  
    }
    }

