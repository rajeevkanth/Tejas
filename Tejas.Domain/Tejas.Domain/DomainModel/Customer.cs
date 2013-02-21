using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tejas.Domain.DomainModel
{
    [Serializable]
    [DataContract]
    public class Customer :DomainBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public virtual ICollection<Order> Orders { get; set; }
    
    }
}