using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Buddy!");
        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From Another Button");
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            MessageBox.Show(name + " Hi!");
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = (firstNumber + secondNumber).ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = (firstNumber - secondNumber).ToString();
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = (firstNumber * secondNumber).ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = (firstNumber / secondNumber).ToString();
        }
    }
}
