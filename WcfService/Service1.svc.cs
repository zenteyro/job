using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        ClientSessionContext db = new ClientSessionContext();

        public bool DeleteClient(Client deletedClient)
        {
            deletedClient = GetClientById(deletedClient.Id);
            
            db.Clients.Remove(deletedClient);
            db.SaveChanges();
            return true;
        }

        public List<Client> GetAllClients()
        {
            return db.Clients.Include(c => c.Sessions).ToList();
        }

        public List<Session> GetAllSessions()
        {
            return db.Sessions.Include(c => c.Client).ToList();
        }

        public Client GetClientById(int id)
        {
            return db.Clients.Include(c => c.Sessions).FirstOrDefault(c => c.Id == id);
        }

        public Client GetClientByLogin(string login)
        {
            return db.Clients.Include(c => c.Sessions).FirstOrDefault(c => c.LoginName == login);
        }

        public List<Session> GetClientSessionsByPeriod(int clientId, DateTime start, DateTime end)
        {
            return db.Sessions.Where(c => c.ClientId == clientId).Where(c => c.SessionStart >= start && c.SessionEnd <= end).ToList();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Session> GetSessionsByClientId(int id)
        {
            return db.Sessions.Include(c => c.Client).Where(c => c.ClientId == id).ToList();
        }

        public bool InsertClient(Client client)
        {
            Client currentClient = GetClientById(client.Id);
            if (currentClient == null)
            {
                db.Clients.Add(client);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertSession(Session session, Client client)
        {
            db.Sessions.Add(session);
            db.SaveChanges();
            return true;
        }

        public bool UpdateClient(Client editedClient)
        {

            db.Entry(editedClient).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
