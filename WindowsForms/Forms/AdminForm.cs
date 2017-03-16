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
    public partial class AdminForm : Form
    {
        DateTime startDate;
        DateTime endDate;
        Client selectedClient;
        List<Session> sessionsByPeriod;

        Service1Client wcfClient = new Service1Client();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            loginComboBox.DataSource = wcfClient.GetAllClients();
            loginComboBox.DisplayMember = "LoginName";
            loginComboBox.ValueMember = "Id";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            startDate = startDatePicker.Value;
            endDate = endDatePicker.Value;
            selectedClient = (Client) loginComboBox.SelectedItem;
            sessionsByPeriod = wcfClient.GetClientSessionsByPeriod(selectedClient.Id, startDate, endDate).ToList();

            TimeSpan resultTimeSpan = TimeSpan.Zero;

            foreach(Session session in sessionsByPeriod)
                resultTimeSpan += session.SessionDuration;

            summaryLabel.Text = resultTimeSpan.ToString(@"d\.hh\:mm\:ss");

            string result = "";

            foreach(Session session in sessionsByPeriod)
                result += String.Format("{0} | {1} | {2} ", session.SessionStart.ToString(), session.SessionEnd.ToString(), session.SessionDuration.ToString(@"hh\:mm\:ss"));
            
            resultTextBox.Text = result;
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            selectedClient = (Client) loginComboBox.SelectedItem;
            EditForm editForm = new EditForm(selectedClient);
            editForm.ShowDialog();
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            selectedClient = (Client)loginComboBox.SelectedItem;
            wcfClient.DeleteClient(selectedClient);
            MessageBox.Show("Client was deleted, relogin to admin panel");
            Close();
        }
    }
}
