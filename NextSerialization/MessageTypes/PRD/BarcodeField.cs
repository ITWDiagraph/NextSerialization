using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class BarcodeField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "mil")]
    public int BarWidth { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "str")]
    public string? Data { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "type")]
    public int BarcodeType { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "bleed")]
    public int BleedFactor { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "human")]
    public int HumanReadableXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool IsHumanReadable
    {
        get => Convert.ToBoolean(HumanReadableXMLValue);
        set => HumanReadableXMLValue = Convert.ToInt32(value);
    }

    /// <remarks>Not sure what this represents</remarks>
    [XmlAttribute(attributeName: "inc")]
    public int Inc { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "fnt")]
    public string? HumanReadableFont { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "hgt")]
    public int Height { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "bbhgt")]
    public int BearerBarHeight { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "bbwid")]
    public int BearerBarWidth { get; set; }
}
