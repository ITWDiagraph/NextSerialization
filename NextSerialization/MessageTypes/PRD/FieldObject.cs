using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "indent")]
    public int HorizontalCoordinate { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "startDot")]
    public int VerticalCoordinate { get; set; }

    /// <remarks>
    /// Character spacing UOM is print columns (0..25)
    /// For PEL (6..150) in multiples of 6
    /// </remarks>
    [XmlAttribute(attributeName: "cspc")]
    public int CharacterSpacing { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "hspc")]
    public int HorizontalSpacing { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool DraftMode
    {
        get => Convert.ToBoolean(DraftXMLValue);
        set => DraftXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "draft")]
    public int DraftXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool FlipVertically
    {
        get => Convert.ToBoolean(VFlipXMLValue);
        set => VFlipXMLValue = Convert.ToInt32(value);
    }

    /// <remarks>
    /// For XML serialization, the <see cref="FlipVertically"/> property is
    /// the boolean representation of the integer <see cref="VFlipXMLValue"/> (0 or 1).
    /// </remarks>
    [XmlAttribute(attributeName: "vflip")]
    public int VFlipXMLValue { get; set; }

}
