
using System;
using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Defines the overall dimentions of the surfaces and message.
/// </summary>
/// <remarks>Data is not currently used.</remarks>
[Serializable]
[XmlType(AnonymousType = true)]
public class Box
{
    /// <summary>
    /// The width, in inches, of the print surface.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// The length, in inches, of the message.
    /// </summary>
    [XmlAttribute]
    public decimal Length { get; set; }

    /// <summary>
    /// The height, in inches, of the print surface.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}
