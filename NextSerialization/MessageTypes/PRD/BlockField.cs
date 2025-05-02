using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class BlockField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "height")]
    public int Height { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "width")]
    public int Width { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "hgt_in")]
    public int HeightIn { get; set; }
}
