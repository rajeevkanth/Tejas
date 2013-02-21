// Type: System.ServiceModel.NetTcpBinding
// Assembly: System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceModel.dll

using System.ComponentModel;
using System.Runtime;
using System.ServiceModel.Channels;
using System.Xml;

namespace System.ServiceModel
{
  /// <summary>
  /// A secure, reliable binding suitable for cross-machine communication.
  /// </summary>
  public class NetTcpBinding : Binding, IBindingRuntimePreferences
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.NetTcpBinding"/> class.
    /// </summary>
    public NetTcpBinding();
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.NetTcpBinding"/> class with the type of security used specified.
    /// </summary>
    /// <param name="securityMode">The <see cref="T:System.ServiceModel.SecurityMode"/> value that specifies the type of security used with the binding.</param>
    public NetTcpBinding(SecurityMode securityMode);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.NetTcpBinding"/> class with the type of security used specified and with a value that indicates whether reliable sessions are explicitly enabled.
    /// </summary>
    /// <param name="securityMode">The <see cref="T:System.ServiceModel.SecurityMode"/> value that specifies the type of security used with the binding.</param><param name="reliableSessionEnabled">true if reliable sessions are enabled; otherwise, false.</param>
    public NetTcpBinding(SecurityMode securityMode, bool reliableSessionEnabled);
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ServiceModel.NetTcpBinding"/> class with a specified configuration name.
    /// </summary>
    /// <param name="configurationName">The binding configuration name for the <see cref="T:System.ServiceModel.NetTcpBinding"/>.</param>
    public NetTcpBinding(string configurationName);
    /// <summary>
    /// Creates a collection with the binding elements for the binding.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> of type <see cref="T:System.ServiceModel.Channels.BindingElement"/> that makes up the binding.
    /// </returns>
    public override BindingElementCollection CreateBindingElements();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.ReaderQuotas"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.ReaderQuotas"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReaderQuotas();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.Security"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.Security"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSecurity();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.TransactionProtocol"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.TransactionProtocol"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTransactionProtocol();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.ReliableSession"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.ReliableSession"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReliableSession();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.ListenBacklog"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.ListenBacklog"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeListenBacklog();
    /// <summary>
    /// Returns a value that indicates whether the <see cref="P:System.ServiceModel.NetTcpBinding.MaxConnections"/> property has changed from its default value and should be serialized.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.ServiceModel.NetTcpBinding.MaxConnections"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMaxConnections();
    /// <summary>
    /// Gets or sets a value that determines whether transaction flow is enabled.
    /// </summary>
    /// 
    /// <returns>
    /// true if transaction flow is enabled; otherwise, false. The default value is false.
    /// </returns>
    [DefaultValue(false)]
    public bool TransactionFlow { get; set; }
    /// <summary>
    /// Gets or sets the transactions protocol used by the service to flow transactions.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.TransactionProtocol"/> used by the service to flow transactions.
    /// </returns>
    public TransactionProtocol TransactionProtocol { get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether the service configured with the binding uses streamed or buffered (or both) modes of message transfer.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.TransferMode"/> value that indicates whether the service configured with the binding uses streamed or buffered (or both) modes of message transfer.
    /// </returns>
    [DefaultValue(TransferMode.Buffered)]
    public TransferMode TransferMode { get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether the hostname is used to reach the service when matching the URI.
    /// </summary>
    /// 
    /// <returns>
    /// One of the <see cref="T:System.ServiceModel.HostnameComparisonMode"/> values that indicates whether the hostname is used to reach the service when matching the URI. The default value is <see cref="F:System.ServiceModel.HostnameComparisonMode.StrongWildcard"/>, which ignores the hostname in the match.
    /// </returns>
    [DefaultValue(HostNameComparisonMode.StrongWildcard)]
    public HostNameComparisonMode HostNameComparisonMode { get; set; }
    /// <summary>
    /// Gets or sets the maximum size, in bytes, allowed for a buffer pool that stores TCP messages processed by the binding.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum size allowed for a buffer pool that stores TCP messages processed by the binding. The default value is 524,288 bytes.
    /// </returns>
    [DefaultValue(524288)]
    public long MaxBufferPoolSize { get; set; }
    /// <summary>
    /// Gets or sets a value that specifies the maximum size, in bytes, of the buffer used to store messages in memory.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum size, in bytes, of the buffer used to store messages in memory. The default value is 65,536 bytes.
    /// </returns>
    [DefaultValue(65536)]
    public int MaxBufferSize { get; set; }
    /// <summary>
    /// Gets or sets a value that controls the maximum number of connections to be pooled for subsequent reuse on the client and the maximum number of connections allowed to be pending dispatch on the server.
    /// </summary>
    /// 
    /// <returns>
    /// On the client, the maximum number of connections to be pooled for subsequent reuse; on the server, the maximum number of connections allowed to be pending dispatch.
    /// </returns>
    public int MaxConnections { get; set; }
    /// <summary>
    /// Gets or sets the maximum number of queued connection requests that can be pending.
    /// </summary>
    /// 
    /// <returns>
    /// Returns the maximum number of pending queued connection requests. The default is 10.
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value cannot be less than zero.</exception>
    public int ListenBacklog { get; set; }
    /// <summary>
    /// Gets or sets the maximum size, in bytes, for a received message that is processed by the binding.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum size (in bytes) for a received message that is processed by the binding. The default value is 65,536 bytes.
    /// </returns>
    [DefaultValue(65536)]
    public long MaxReceivedMessageSize { get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether TCP port sharing is enabled for the connection configured with this binding.
    /// </summary>
    /// 
    /// <returns>
    /// true if TCP port sharing is enabled; otherwise, false. The default value is false.
    /// </returns>
    [DefaultValue(false)]
    public bool PortSharingEnabled { get; set; }
    /// <summary>
    /// Gets or sets constraints on the complexity of SOAP messages that can be processed by endpoints configured with this binding.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Xml.XmlDictionaryReaderQuotas"/> that specifies the complexity constraints on soap messages exchanged. The default values for these constraints are provided in the following Remarks section.
    /// </returns>
    public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
    /// <summary>
    /// Gets a value that indicates whether incoming requests are handled synchronously or asynchronously.
    /// </summary>
    /// 
    /// <returns>
    /// true if incoming requests are handled synchronously; false if incoming requests are handled asynchronously. The default value is false.
    /// </returns>
    bool IBindingRuntimePreferences.ReceiveSynchronously { get; }
    /// <summary>
    /// Gets an object that indicates whether a reliable session is established between channel endpoints.
    /// </summary>
    /// 
    /// <returns>
    /// An <see cref="T:System.ServiceModel.OptionalReliableSession"/> that indicates whether a WS-RM reliable session is established between channel endpoints. The default value for <see cref="P:System.ServiceModel.OptionalReliableSession.Enabled"/> is false.
    /// </returns>
    public OptionalReliableSession ReliableSession { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Returns the URI scheme for the transport.
    /// </summary>
    /// 
    /// <returns>
    /// The URI scheme for the transport, which is "net.tcp".
    /// </returns>
    public override string Scheme { get; }
    /// <summary>
    /// Gets the version of SOAP that is used for messages processed by this binding.
    /// </summary>
    /// 
    /// <returns>
    /// The value of the <see cref="T:System.ServiceModel.EnvelopeVersion"/> that is used with this binding. The value is SOAP 1.2.
    /// </returns>
    public EnvelopeVersion EnvelopeVersion { get; }
    /// <summary>
    /// Gets an object that specifies the type of security used with services configured with this binding.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.ServiceModel.NetTcpSecurity"/> that contains the types of security used with this binding. The default mode of security for the NetTCPBinding is <see cref="F:System.ServiceModel.SecurityMode.Transport"/>.
    /// </returns>
    public NetTcpSecurity Security { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
  }
}
