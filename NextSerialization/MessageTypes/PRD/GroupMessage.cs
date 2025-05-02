using System.ComponentModel;
using System.Xml.Serialization;

using Diagraph.Message.Serialization.Interfaces;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "group", Namespace = "", IsNullable = false)]
public partial class GroupMessage : IMessage
{
    /// <remarks/>
    [XmlElement(elementName: "product")]
    public Message[] Products { get; set; } = Array.Empty<Message>();

    /// <summary>
    /// Satisfies the interface
    /// </summary>
    [XmlIgnore]
    public string? Name => Products.First().Name ?? string.Empty;
}
