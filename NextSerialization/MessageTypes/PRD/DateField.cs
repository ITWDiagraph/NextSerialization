using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class DateField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "fmt")]
    public int Format { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "offset")]
    public int Offset { get; set; }

    /// <remarks>
    /// The offset type indicates whether the date offset is in months or days.
    /// Days = 3
    /// Months = 2
    /// </remarks>
    [XmlAttribute(attributeName: "type")]
    public int OffsetType { get; set; }

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
