using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class Session
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime SessionStart { get; set; }
        [DataMember]
        public DateTime SessionEnd { get; set; }
        [DataMember]
        public TimeSpan SessionDuration { get; set; }


        [DataMember]
        public int? ClientId { get; set; }
        [DataMember]
        public Client Client { get; set; }
    }
}