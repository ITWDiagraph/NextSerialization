using System.ComponentModel;
using System.Xml.Serialization;

using Diagraph.Message.Serialization.Interfaces;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(ElementName = "product", Namespace = "", IsNullable = false)]
public partial class Message : IMessage
{
    /// <remarks/>
    [XmlElement("barcode", typeof(BarcodeField))]
    [XmlElement("block", typeof(BlockField))]
    [XmlElement("count", typeof(CountField))]
    [XmlElement("date", typeof(DateField))]
    [XmlElement("logo", typeof(LogoField))]
    [XmlElement("text", typeof(TextField))]
    [XmlElement("time", typeof(TimeField))]
    [XmlElement("var", typeof(VariableField))]
    public FieldObject[]? FieldObjects { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "len")]
    public int Length { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "margin")]
    public int LeftMargin { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "margin2")]
    public int RightMargin { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "charwidth")]
    public int CharacterWidth { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "hspc")]
    public int HorizontalSpacing { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "pwr")]
    public int Power { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "speed")]
    public int Speed { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "name")]
    public string? Name { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool PrintUpsideDown
    {
        get => Convert.ToBoolean(PrintUpsideDownXMLValue);
        set => PrintUpsideDownXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "prntupsdn")]
    public int PrintUpsideDownXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool Mirror
    {
        get => Convert.ToBoolean(MirrorXMLValue);
        set => MirrorXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "mirror")]
    public int MirrorXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool PrintOnce
    {
        get => Convert.ToBoolean(PrintOnceXMLValue);
        set => PrintOnceXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "prntonce")]
    public int PrintOnceXMLValue { get; set; }

    /// <remarks/>
    [XmlIgnore]
    public bool ContinuousPrint
    {
        get => Convert.ToBoolean(ContinuousPrintXMLValue);
        set => ContinuousPrintXMLValue = Convert.ToInt32(value);
    }

    /// <remarks/>
    [XmlAttribute(attributeName: "contprnt")]
    public int ContinuousPrintXMLValue { get; set; }
}