
using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.Next.Interfaces;

namespace NextSerialization.MessageTypes.Next;
/// <summary>
/// Describes the aspects of the typeface of a textual element.
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Font : IFontObject
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
    /// The horizontal character size in points.
    /// </summary>
    [XmlAttribute]
    public int Width { get; set; }

    /// <summary>
    /// The vertical character size in points.
    /// </summary>
    [XmlAttribute]
    public int Height { get; set; }
}
