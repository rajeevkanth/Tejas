using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tejas.Domain.DomainModel
{
    [Serializable]
    [DataContract]
    public class Order:DomainBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public virtual ICollection<Product> Products { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }
    }
}