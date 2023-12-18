using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_money_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numbers = { 0, 0, 0, 0, 0, 0};
        double[] values = { 0.05, 0.10, 0.20, 0.50, 1.00, 2.00};
        double[] totalValues = { 0, 0, 0, 0, 0, 0 };
        int buttonPressed;

        private void btnFiveCent_Click(object sender, EventArgs e)
        {
            buttonPressed = 0;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }

        private void btnTenCent_Click(object sender, EventArgs e)
        {
            buttonPressed = 1;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }

        private void btnTwentyCent_Click(object sender, EventArgs e)
        {
            buttonPressed = 2;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }

        private void btnFiftyCent_Click(object sender, EventArgs e)
        {
            buttonPressed = 3;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }

        private void btnOneEuro_Click(object sender, EventArgs e)
        {
            buttonPressed = 4;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }

        private void btnTwoEuro_Click(object sender, EventArgs e)
        {
            buttonPressed = 5;
            AddCoin(buttonPressed);
            UpdateCoinBoxInfo();
        }
        private void UpdateCoinBoxInfo()
        {
            CalculateTotal();
            double totalValue = 0;
            lbCoins.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                totalValue += totalValues[i];
                lbCoins.Items.Add("€" + values[i] + "\t" + numbers[i] + "\t" + totalValues[i]);
            }
            tbTotal.Text = totalValue.ToString();
        }
        private void AddCoin(int buttonNumber)
        {
            if (tbNumberOfCoins.Text != "")
            {
                numbers[buttonNumber] += Convert.ToInt32(tbNumberOfCoins.Text);
            }
            else
            {
                numbers[buttonNumber]++;
            }
        }

        private void CalculateTotal()
        {
            for (int i=0; i<6; i++)
            {
                totalValues[i] = values[i] * numbers[i];
            }
        }

        private void tbNumberOfCoins_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
