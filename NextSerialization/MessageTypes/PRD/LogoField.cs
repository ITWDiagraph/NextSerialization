using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, TypeName = "logo")]
public partial class LogoField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "bmp")]
    public string? Bitmap { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "rotate")]
    public int DegreesOfRotation { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "sHeight")]
    public int ScaledHeight { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "hgt_in")]
    public int Height { get; set; }
}
