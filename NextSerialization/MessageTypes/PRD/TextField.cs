using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class TextField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "txtht")]
    public int TextHeight { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "fnt")]
    public string? Font { get; set; }

    /// <remarks/>
    [XmlText]
    public string? Text { get; set; }
}
