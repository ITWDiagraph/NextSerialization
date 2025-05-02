using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class TimeField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "fmt")]
    public int TimeFormat { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "offset")]
    public int TimeOffset { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "txtht")]
    public int TextHeight { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "fnt")]
    public string? Font { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "txt")]
    public string? Text { get; set; }
}
