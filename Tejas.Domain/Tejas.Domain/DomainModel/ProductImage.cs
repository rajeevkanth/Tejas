using System;
using System.Runtime.Serialization;

namespace Tejas.Domain.DomainModel
{
    [Serializable]
    [DataContract]
    public class ProductImage :DomainBase
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public Product Product { get; set; }

        [DataMember]
        public byte[] Image { get; set; }
    }
}