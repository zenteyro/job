using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Address { get; set; }

        public ICollection<Session> Sessions { get; set; }
        public Client()
        {
            Sessions = new List<Session>();
        }
    }
}