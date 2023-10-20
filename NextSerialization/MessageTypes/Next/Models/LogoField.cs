
using System;
using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// An image element.
/// </summary>
[Serializable]
[XmlType(TypeName = "LogoFieldObject")]
public class LogoField : FieldObject
{
    /// <summary>
    /// The name of the image file.
    /// </summary>
    [XmlAttribute]
    public string? FileName { get; set; }
}
