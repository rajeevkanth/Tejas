using System;
using System.Runtime.Serialization;

namespace Tejas.Domain.DomainModel
{
    [Serializable]
    [DataContract]
    public class DomainBase
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public byte[] TimeStamp { get; set; }

    }
}