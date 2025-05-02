using System.ComponentModel;
using System.Xml.Serialization;

namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <remarks/>
[Serializable()]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, TypeName = "var")]
public partial class VariableField : FieldObject
{
    /// <remarks/>
    [XmlAttribute(attributeName: "length")]
    public int Length { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "prompt")]
    public string? Prompt { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "src")]
    public int Source { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "txtht")]
    public int TextHeight { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "fnt")]
    public string? Font { get; set; }

    /// <remarks/>
    [XmlAttribute(attributeName: "txt")]
    public string? DefaultText { get; set; }
}
