
using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.Next.Interfaces;

namespace NextSerialization.MessageTypes.Next;
/// <summary>
/// Renders a text element.
/// </summary>
[Serializable()]
[XmlType(TypeName = "TextFieldObject")]
public class TextField : FieldObject, IFontObject
{
    /// <summary>
    /// The name of the font to be rendered.
    /// </summary>
    [XmlAttribute]
    public string? Family { get; set; }

    /// <summary>
    /// The style to render the font (e.g. Italic, Bold, etc.).
    /// </summary>
    [XmlAttribute]
    public string? Style { get; set; }

    /// <summary>
    /// The text to render.
    /// </summary>
    [XmlAttribute]
    public string? Data { get; set; }
}
