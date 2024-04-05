using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime.number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CheckButton_Click(object sender, EventArgs e)
        { 
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                bool isPrime = true;
                for (int i=2; i<=result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if(isPrime)
                {
                    this.BackColor = Color.LightGreen;
                }
                else { this.BackColor = Color.LightPink; }
            } else 
            {
                this.BackColor = Color.LightYellow;
                MessageBox.Show("S-a introdus un text");
            }
        }
        private void PrimeNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
