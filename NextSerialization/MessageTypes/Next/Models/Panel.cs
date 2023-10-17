
using System;
using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Represents a surface of a product in which a message can be printed.
/// </summary>
[Serializable]
public class Panel
{
    /// <summary>
    /// The name of the panel for the print head and message segment.
    /// </summary>
    [XmlAttribute]
    public string? Name { get; set; }

    /// <summary>
    /// Defines the print heads and message elements for each head.
    /// </summary>
    [XmlElement("Head")]
    public PrintHead[]? PrintHead { get; set; }
}
