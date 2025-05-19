using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPACalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double prevCGPA = double.Parse(txtPrevCgpa.Text);
                int prevCredits = int.Parse(txtPrevCrHrs.Text);
                double newSGPA = double.Parse(txtNewSgpa.Text);
                int newCredits = int.Parse(txtNewCrHrs.Text); // ✅ Fixed

                double totalPoints = (prevCGPA * prevCredits) + (newSGPA * newCredits);
                int totalCredits = prevCredits + newCredits;

                double finalCGPA = totalPoints / totalCredits;
                txtResultCgpa.Text = finalCGPA.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // You can remove this if not used
        }
    }
}
