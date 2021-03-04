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
    public partial class UserDefinedPersonalInfoUI : Form
    {
        public UserDefinedPersonalInfoUI()
        {
            InitializeComponent();
        }

        Person person = new Person();
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            person.firstName = firstNameTextBox.Text;
            person.lastName = lastNameTextBox.Text;
            person.fathersName = fathersNameTextBox.Text;
            person.mothersName = mothersNameTextBox.Text;
            person.address = addressTextBox.Text;

            ClearAllText();
        }

        private void ClearAllText()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            fathersNameTextBox.Text = String.Empty;
            mothersNameTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            ClearAllText();

            firstNameTextBox.Text = person.firstName;
            lastNameTextBox.Text = person.lastName;
        }

        private void fathersNameButton_Click(object sender, EventArgs e)
        {
            ClearAllText();

            fathersNameTextBox.Text = person.fathersName;
        }

        private void mothersNameButton_Click(object sender, EventArgs e)
        {
            ClearAllText();

            mothersNameTextBox.Text = person.mothersName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            ClearAllText();

            addressTextBox.Text = person.address;
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            ClearAllText();

            firstNameTextBox.Text = person.firstName;
            lastNameTextBox.Text = person.lastName;
            fathersNameTextBox.Text = person.fathersName;
            mothersNameTextBox.Text = person.mothersName;
            addressTextBox.Text = person.address;
        }
    }
}
