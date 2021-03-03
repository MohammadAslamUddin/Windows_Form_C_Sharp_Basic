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
    public partial class PersonalInformationsUI : Form
    {
        public PersonalInformationsUI()
        {
            InitializeComponent();
        }

        private string firstName;
        private string lastName;
        private string fathersName;
        private string mothersName;
        private string address;
        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;

            ClearAllInfo();
        }

        private void ClearAllInfo()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            fathersNameTextBox.Text = String.Empty;
            mothersNameTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            ClearAllInfo();

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }

        private void fathersNameButton_Click(object sender, EventArgs e)
        {
            ClearAllInfo();

            fathersNameTextBox.Text = fathersName;
        }

        private void mothersNameButton_Click(object sender, EventArgs e)
        {
            ClearAllInfo();

            mothersNameTextBox.Text = mothersName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            ClearAllInfo();

            addressTextBox.Text = address;
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            ClearAllInfo();

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
            addressTextBox.Text = address;
        }
    }
}
