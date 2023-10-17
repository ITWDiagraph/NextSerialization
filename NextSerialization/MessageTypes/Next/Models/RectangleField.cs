using System.Xml.Serialization;

using Diagraph.Message.Next.Interfaces;

namespace Diagraph.Message.Next;
/// <summary>
/// Describes a rectangular element to be rendered on the message.
/// </summary>
[Serializable()]
[XmlType(TypeName = "RectangleFieldObject")]
public class RectangleField : FieldObject, IShapeObject
{
    /// <summary>
    /// Indicates how the rectangle should be rendered.
    /// <list type="table">
    /// <item><term>Horizontal</term><description>Indicates that the long edges of the rectangle are horizontal.</description></item>
    /// <item><term>Vertical</term><description>Indicates that the long edges of the rectangle are vertical.</description></item>
    /// </list>
    /// </summary>
    [XmlAttribute]
    public string? Orientation { get; set; }

    /// <summary>
    /// The line weight of the border of the rectangle.
    /// </summary>
    [XmlElement("LineThickness", IsNullable = false)]
    public LineThickness? LineThickness { get; set; }
}
