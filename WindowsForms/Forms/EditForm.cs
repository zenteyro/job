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
    public partial class EditForm : Form
    {
        private Client editClient;
        public EditForm(Client client)
        {
            editClient = client;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            labelLogin.Text = editClient.LoginName;
            firstNameTextBox.Text = editClient.FirstName;
            lastNameTextBox.Text = editClient.LastName;
            phoneNumberMaskedBox.Text = editClient.PhoneNumber;
            addressTextBox.Text = editClient.Address;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            Service1Client wcfClient = new Service1Client();
            editClient.FirstName = firstNameTextBox.Text;
            editClient.LastName = lastNameTextBox.Text;
            editClient.PhoneNumber = phoneNumberMaskedBox.Text;
            editClient.Address = addressTextBox.Text;
            wcfClient.UpdateClient(editClient);
            wcfClient.Close();
            MessageBox.Show("Information about client was updated");
            Close();
        }
    }
}
