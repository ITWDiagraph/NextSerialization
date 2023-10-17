using System.Xml.Serialization;

using Diagraph.Message.Next.Enumerations;

namespace Diagraph.Message.Next;
/// <summary>
/// A horizontal or vertical line element.
/// </summary>
[Serializable]
[XmlType(TypeName = "LineFieldObject")]
[XmlInclude(typeof(RectangleField))]
[XmlInclude(typeof(LogoField))]
public class LineField : FieldObject
{
    /// <summary>
    /// Indicates whether the shape is oriented horizontally or vertically.
    /// </summary>
    [XmlAttribute]
    public FieldOrientation Orientation { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Orientation"/> XML node when the value of <see cref="Orientation"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool OrientationSpecified { get; set; }

    /// <summary>
    /// The thickness of the stroke.
    /// </summary>
    [XmlElement("LineThickness")]
    public LineThickness? LineThickness { get; set; }
}
