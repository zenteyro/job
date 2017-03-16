using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);




        [OperationContract]
        List<Client> GetAllClients();

        [OperationContract]
        Client GetClientById(int id);

        [OperationContract]
        Client GetClientByLogin(string login);

        [OperationContract]
        bool InsertClient(Client client);

        [OperationContract]
        bool InsertSession(Session session, Client client);

        [OperationContract]
        List<Session> GetAllSessions();

        [OperationContract]
        List<Session> GetSessionsByClientId(int id);

        [OperationContract]
        List<Session> GetClientSessionsByPeriod(int clientId, DateTime start, DateTime end);

        [OperationContract]
        bool UpdateClient(Client editedClient);
        
        [OperationContract]
        bool DeleteClient(Client deletedClient);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
