// Type: System.ServiceModel.EndpointAddress
// Assembly: System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceModel.dll

using System;
using System.ComponentModel;
using System.Runtime;
using System.ServiceModel.Channels;
using System.Xml;

namespace System.ServiceModel
{
  /// <summary>
  /// Provides a unique network address that a client uses to communicate with a service endpoint.
  /// </summary>
  public class EndpointAddress
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.EndpointAddress"/> class with a specified URI string.
    /// </summary>
    /// <param name="uri">The URI that identifies the endpoint.</param>
    public EndpointAddress(string uri);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.EndpointAddress"/> class with a specified URI and headers.
    /// </summary>
    /// <param name="uri">The <see cref="T:System.Uri"/> that identifies the endpoint location.</param><param name="addressHeaders">The <see cref="T:System.Array"/> of type <see cref="T:System.ServiceModel.Channels.AddressHeader"/> that contains address information used to interact with the endpoint.</param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public EndpointAddress(Uri uri, params AddressHeader[] addressHeaders);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.EndpointAddress"/> class with a specified URI, identity, and headers.
    /// </summary>
    /// <param name="uri">The <see cref="T:System.Uri"/> that identifies the endpoint location.</param><param name="identity">The <see cref="T:System.ServiceModel.EndpointIdentity"/> for the endpoint.</param><param name="addressHeaders">The <see cref="T:System.Array"/> of type <see cref="T:System.ServiceModel.Channels.AddressHeader"/> that contains address information used to interact with the endpoint.</param>
    public EndpointAddress(Uri uri, EndpointIdentity identity, params AddressHeader[] addressHeaders);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.EndpointAddress"/> class with a specified URI, identity, and header collection.
    /// </summary>
    /// <param name="uri">The <see cref="T:System.Uri"/> that identifies the endpoint location.</param><param name="identity">The <see cref="T:System.ServiceModel.EndpointIdentity"/> for the endpoint.</param><param name="headers">The <see cref="T:System.ServiceModel.Channels.AddressHeaderCollection"/> that contains address information used to interact with the endpoint.</param>
    public EndpointAddress(Uri uri, EndpointIdentity identity, AddressHeaderCollection headers);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.EndpointAddress"/> class with a specified URI, identity, header collection, and metadata and extension readers.
    /// </summary>
    /// <param name="uri">The <see cref="T:System.Uri"/> that identifies the endpoint location.</param><param name="identity">The <see cref="T:System.ServiceModel.EndpointIdentity"/> for the endpoint.</param><param name="headers">The <see cref="T:System.ServiceModel.Channels.AddressHeaderCollection"/> that contains address information used to interact with the endpoint.</param><param name="metadataReader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which the endpoint metadata is obtained.</param><param name="extensionReader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which extensions are obtained.</param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public EndpointAddress(Uri uri, EndpointIdentity identity, AddressHeaderCollection headers, XmlDictionaryReader metadataReader, XmlDictionaryReader extensionReader);
    /// <summary>
    /// Returns a value that indicates whether specified endpoint addresses are not equivalent.
    /// </summary>
    /// 
    /// <returns>
    /// true if the endpoint addresses are equivalent; otherwise, false.
    /// </returns>
    /// <param name="address1">One of the <see cref="T:System.ServiceModel.EndpointAddress"/> objects being compared.</param><param name="address2">One of the <see cref="T:System.ServiceModel.EndpointAddress"/> objects being compared.</param>
    public static bool operator ==(EndpointAddress address1, EndpointAddress address2);
    /// <summary>
    /// Returns a value that indicates whether specified endpoint addresses are not equivalent.
    /// </summary>
    /// 
    /// <returns>
    /// true if the endpoint addresses are not equivalent; otherwise, false.
    /// </returns>
    /// <param name="address1">One of the <see cref="T:System.ServiceModel.EndpointAddress"/> objects being compared.</param><param name="address2">One of the <see cref="T:System.ServiceModel.EndpointAddress"/> objects being compared.</param>
    public static bool operator !=(EndpointAddress address1, EndpointAddress address2);
    /// <summary>
    /// Assigns the URI and properties of the endpoint address to the values of the headers of a specified message.
    /// </summary>
    /// <param name="message">The <see cref="T:System.ServiceModel.Channels.Message"/> whose header values are being assigned.</param><exception cref="T:System.ArgumentNullException"><paramref name="message"/> is null.</exception>
    public void ApplyTo(Message message);
    /// <summary>
    /// Returns a value that indicates whether a specified object is equivalent to the current endpoint address.
    /// </summary>
    /// 
    /// <returns>
    /// true if the specified object is equivalent to the current address; otherwise, false.
    /// </returns>
    /// <param name="obj">The <see cref="T:System.Object"/> to be compared to the current endpoint address.</param>
    public override bool Equals(object obj);
    /// <summary>
    /// Provides a unique hash code for the current endpoint address.
    /// </summary>
    /// 
    /// <returns>
    /// A unique hash code for the current endpoint address.
    /// </returns>
    public override int GetHashCode();
    /// <summary>
    /// Gets the XML dictionary reader that provides access to the metadata for an endpoint.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Xml.XmlDictionaryReader"/> that provides access to the metadata for an endpoint.
    /// </returns>
    public XmlDictionaryReader GetReaderAtMetadata();
    /// <summary>
    /// Gets the XML dictionary reader that provides access to the extensions.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Xml.XmlDictionaryReader"/> that provides access to the extensions.
    /// </returns>
    public XmlDictionaryReader GetReaderAtExtensions();
    /// <summary>
    /// Reads an endpoint address from a specified XML dictionary reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> read from the XML dictionary reader.
    /// </returns>
    /// <param name="reader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which the endpoint address is obtained.</param>
    public static EndpointAddress ReadFrom(XmlDictionaryReader reader);
    /// <summary>
    /// Reads an endpoint address with a specified qualified name from a specified XML dictionary reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> with the qualified name read from the XML dictionary reader.
    /// </returns>
    /// <param name="reader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which the endpoint address is obtained.</param><param name="localName">An <see cref="T:System.Xml.XmlDictionaryString"/> that contains the local name for the XML node to contain the endpoint address.</param><param name="ns">An <see cref="T:System.Xml.XmlDictionaryString"/> that contains the namespace for the XML node to contain the endpoint address.</param>
    public static EndpointAddress ReadFrom(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns);
    /// <summary>
    /// Reads an endpoint address for a specified address version from a specified XML reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> read from the XML reader.
    /// </returns>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="reader">The <see cref="T:System.Xml.XmlReader"/> from which the endpoint address is obtained.</param>
    public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlReader reader);
    /// <summary>
    /// Reads an endpoint address for a specified address version with a specified qualified name from a specified XML reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> with the qualified name read from the XML reader.
    /// </returns>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="reader">The <see cref="T:System.Xml.XmlReader"/> from which the endpoint address is obtained.</param><param name="localName">Contains the local name for the XML node to contain the endpoint address.</param><param name="ns">Contains the namespace for the XML node to contain the endpoint address.</param>
    public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlReader reader, string localName, string ns);
    /// <summary>
    /// Reads an endpoint address for a specified address version from a specified XML dictionary reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> read from the XML dictionary reader.
    /// </returns>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="reader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which the endpoint address is obtained.</param>
    public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlDictionaryReader reader);
    /// <summary>
    /// Reads an endpoint address for a specified address version with a specified qualified name from a specified XML dictionary reader.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointAddress"/> with the qualified name read from the XML reader.
    /// </returns>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="reader">The <see cref="T:System.Xml.XmlDictionaryReader"/> from which the endpoint address is obtained.</param><param name="localName">Contains the local name for the XML node to contain the endpoint address.</param><param name="ns">Contains the namespace for the XML node to contain the endpoint address.</param>
    public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns);
    /// <summary>
    /// Returns a canonical string representation of the URI that is contained in the endpoint address.
    /// </summary>
    /// 
    /// <returns>
    /// The URI that identifies the endpoint.
    /// </returns>
    public override string ToString();
    /// <summary>
    /// Saves all the child nodes of the node to the XML dictionary writer specified.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlDictionaryWriter"/> to which the endpoint address is saved.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> is null.</exception>
    public void WriteContentsTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer);
    /// <summary>
    /// Saves all the child nodes of the node to the XML writer specified.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlWriter"/> to which the endpoint address is saved.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> is null.</exception>
    public void WriteContentsTo(AddressingVersion addressingVersion, XmlWriter writer);
    /// <summary>
    /// Saves the current endpoint address of a specified version to a specified XML dictionary writer.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlDictionaryWriter"/> to which the endpoint address is saved.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> is null.</exception>
    public void WriteTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer);
    /// <summary>
    /// Saves the current endpoint address of a specified version to an XML dictionary writer with a specified namespace and local name.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlDictionaryWriter"/> to which the endpoint address is saved.</param><param name="localName">The <see cref="T:System.Xml.XmlDictionaryString"/> that contains the local name for the XML node to contain the endpoint address.</param><param name="ns">The <see cref="T:System.Xml.XmlDictionaryString"/> that contains the namespace for the XML node to contain the endpoint address.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> or <paramref name="localName"/> or <paramref name="ns"/> is null.</exception>
    public void WriteTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer, XmlDictionaryString localName, XmlDictionaryString ns);
    /// <summary>
    /// Saves the current endpoint address of a specified version to a specified XML writer.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlWriter"/> to which the endpoint address is saved.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> is null.</exception>
    public void WriteTo(AddressingVersion addressingVersion, XmlWriter writer);
    /// <summary>
    /// Saves the current endpoint address of a specified version to an XML writer with a specified namespace and local name.
    /// </summary>
    /// <param name="addressingVersion">The <see cref="T:System.ServiceModel.Channels.AddressingVersion"/> of the current endpoint address.</param><param name="writer">The <see cref="T:System.Xml.XmlWriter"/> to which the endpoint address is saved.</param><param name="localName">The <see cref="T:System.Xml.XmlDictionaryString"/> that contains the local name for the XML node to contain the endpoint address.</param><param name="ns">The <see cref="T:System.Xml.XmlDictionaryString"/> that contains the namespace for the XML node to contain the endpoint address.</param><exception cref="T:System.ArgumentNullException"><paramref name="writer"/> or <paramref name="addressingVersion"/> or <paramref name="localName"/> or <paramref name="ns"/> is null.</exception>
    public void WriteTo(AddressingVersion addressingVersion, XmlWriter writer, string localName, string ns);
    /// <summary>
    /// Gets a version-neutral representation of the anonymous URI.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Uri"/> with the value http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous.
    /// </returns>
    public static Uri AnonymousUri { get; }
    /// <summary>
    /// Gets a version-neutral URI used for the address of an endpoint to which a message must not be sent.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Uri"/> with the value http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/None.
    /// </returns>
    public static Uri NoneUri { get; }
    /// <summary>
    /// Gets the collection of address headers for the endpoints that the builder can create.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.Channels.AddressHeaderCollection"/> that contains address information for the endpoint.
    /// </returns>
    public AddressHeaderCollection Headers { get; }
    /// <summary>
    /// Gets the identity for the endpoint used to authenticate it.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.EndpointIdentity"/> for the endpoint.
    /// </returns>
    public EndpointIdentity Identity { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets a value that indicates whether the endpoint is anonymous.
    /// </summary>
    /// 
    /// <returns>
    /// true if the endpoint is <see cref="P:System.ServiceModel.EndpointAddress.AnonymousUri"/>; otherwise, false.
    /// </returns>
    public bool IsAnonymous { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets a value that indicates whether the URI for the endpoint is the <see cref="P:System.ServiceModel.EndpointAddress.NoneUri"/>.
    /// </summary>
    /// 
    /// <returns>
    /// true if the URI of the endpoint is <see cref="P:System.ServiceModel.EndpointAddress.NoneUri"/>; otherwise, false.
    /// </returns>
    public bool IsNone { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets the URI for the endpoint.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Uri"/> for the endpoint.
    /// </returns>
    [TypeConverter(typeof (UriTypeConverter))]
    public Uri Uri { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
  }
}
