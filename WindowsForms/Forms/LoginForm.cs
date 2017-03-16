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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client wcfClient = new Service1Client();

            loginTextBox.Text = loginTextBox.Text.Trim(' ');

            string login = loginTextBox.Text;

            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Input login");
            }
            else if (login == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {

                Client currentClient = wcfClient.GetClientByLogin(login);

                if (currentClient != null)
                {
                    ClientForm clientForm = new ClientForm(currentClient);
                    clientForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The user with pointed login doesn't exist");
                }
            }
                        
            wcfClient.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registartionForm = new RegistrationForm();
            registartionForm.ShowDialog();
        }
    }
}
