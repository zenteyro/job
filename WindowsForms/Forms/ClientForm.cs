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
    public partial class ClientForm : Form
    {
        Service1Client wcFclient = new Service1Client();
        DateTime sessionStart;
        DateTime sessionEnd;
        TimeSpan sessionDuration;
        Client client;

        public ClientForm(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            sessionStart = DateTime.Now;

            loginNameLabel.Text = client.LoginName;
            firstNameLabel.Text = client.FirstName;
            lastNameLabel.Text = client.LastName;
            sessionStartLabel.Text = sessionStart.ToString();

            client = wcFclient.GetClientByLogin(client.LoginName);
            List<Session> sessionsByCurrentClient = wcFclient.GetSessionsByClientId(client.Id).ToList();

            sessionQtyLabel.Text = sessionsByCurrentClient.Count.ToString() + " session(s)";

        }

        private void stopSessionButton_Click(object sender, EventArgs e)
        {
            sessionEnd = DateTime.Now;
            sessionDuration = sessionEnd - sessionStart;
            Session currentSession = new Session
            {
                SessionStart = sessionStart,
                SessionEnd = sessionEnd,
                SessionDuration = sessionDuration,
                ClientId = client.Id
            };
            wcFclient.InsertSession(currentSession, client);
            string result = String.Format("Session end: {0}. Duratrion: {1}", sessionEnd.ToString(), sessionDuration.ToString(@"hh\:mm\:ss"));
            MessageBox.Show(result);
            wcFclient.Close();
            Close();
        }
    }
}
