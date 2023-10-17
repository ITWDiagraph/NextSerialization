
using System;
using System.Xml.Serialization;

namespace NextSerialization.MessageTypes.Next;
/// <summary>
/// Defines the thickness of the lines that create a bounding box around the rendered barcode element.
/// </summary>
[Serializable]
public class Bearer
{
    /// <summary>
    /// The width, in inches, of the vertical lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Width"/> XML node when the value of <see cref="Width"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool WidthSpecified { get; set; }

    /// <summary>
    /// The width, in inches, of the horizontal lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Height"/> XML node when the value of <see cref="Height"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool HeightSpecified { get; set; }
}
