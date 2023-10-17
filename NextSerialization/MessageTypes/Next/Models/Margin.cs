
using System.Xml.Serialization;

namespace NextSerialization.MessageTypes.Next;
/// <summary>
/// Defines the area to remain blank on either side of the message.
/// </summary>
[Serializable]
[XmlType(TypeName = nameof(Margin))]
public class Margin
{
    /// <summary>
    /// The distance, in inches, to the left of the message that should be blank.
    /// </summary>
    [XmlElement(IsNullable = false)]
    public decimal Left { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Left"/> XML node when the value of <see cref="Left"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool LeftSpecified { get; set; }

    /// <summary>
    /// The distance, in inches, to the right of the message that shold be blank.
    /// </summary>
    [XmlElement(IsNullable = false)]
    public decimal Right { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Right"/> XML node when the value of <see cref="Right"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool RightSpecified { get; set; }
}
