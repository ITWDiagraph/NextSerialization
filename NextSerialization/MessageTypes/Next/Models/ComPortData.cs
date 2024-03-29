﻿using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Represents data transmitted as key/value pairs over a serial connection.
/// </summary>
[XmlType(TypeName = "Comm")]
public class ComPortData
{
    /// <summary>
    /// The data identifier.
    /// </summary>
    [XmlAttribute]
    public string? Key { get; set; }

    /// <summary>
    /// The data transmitted.
    /// </summary>
    [XmlAttribute]
    public string? Value { get; set; }
}
