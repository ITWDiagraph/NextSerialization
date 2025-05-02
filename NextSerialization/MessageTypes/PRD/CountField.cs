using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class CountField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "cnt")]
    public string? Count { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "start")]
    public int Start { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "stop")]
    public int Stop { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "inc")]
    public int IncrementBy { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "zeros")]
    public int LeadingZerosXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool PrintLeadingZeros
    {
        get => Convert.ToBoolean(LeadingZerosXMLValue);
        set => LeadingZerosXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "pallet")]
    public int PalletCount { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "psize")]
    public int PalletSize { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "pinct")]
    public string? PalletIncrementBy { get; set; }

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


