using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tejas.Domain.DomainModel
{
    [Serializable]
    [DataContract]
    public class Product : DomainBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Cost { get; set; }

        [DataMember]
        public virtual List<ProductImage> Images { get; set; }
    }
}
