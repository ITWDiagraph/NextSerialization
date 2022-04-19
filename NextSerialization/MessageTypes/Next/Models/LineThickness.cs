﻿namespace NextSerialization.MessageTypes.Next;

using System.Xml.Serialization;

/// <summary>
/// Specifies the stroke weight of a shape element.
/// </summary>
[Serializable]
public class LineThickness
{
    /// <summary>
    /// The horizontal stroke weight.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// The vertical stroke weight.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}