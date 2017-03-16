using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.ServiceReference1;

namespace WindowsForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Service1Client wcfClient = new Service1Client();
            
            string login = loginTextBox.Text.Trim(' ');
            string firstName = firstNameTextBox.Text.Trim(' ');
            string lastName = lastNameTextBox.Text.Trim(' ');
            string phoneNumber = phoneTextBox.Text;
            string address = addressTextBox.Text.Trim(' ');

            if (wcfClient.GetClientByLogin(login) != null || login == "admin")
            {
                MessageBox.Show("The user exists with pointed login");
            }
            else
            {
                if (String.IsNullOrEmpty(login))
                    MessageBox.Show("Input your login");
                else
                {
                    Client createdClient = new Client
                    {
                        LoginName = login,
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber,
                        Address = address
                    };

                    wcfClient.InsertClient(createdClient);

                    MessageBox.Show("The user was successfully registered");
                    Close();
                }
            }

            wcfClient.Close();
        }
    }
}
