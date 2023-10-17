
using System;
using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Represent a textual element that is rendered and printed on each message and incremented by <see cref="Increment"/> for each
/// subsequent message in the print run.
/// </summary>
[Serializable]
[XmlType(TypeName = "CountFieldObject")]
public class CountField : TextField
{
    private bool alphaCount;

    /// <summary>
    /// The initial value to use when printing.
    /// </summary>
    [XmlAttribute]
    public int StartCount { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="StartCount"/> XML node when the value of <see cref="StartCount"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool StartCountSpecified { get; set; }

    /// <summary>
    /// The value of the count that will signal the printer to stop printing.
    /// </summary>
    [XmlAttribute]
    public int StopCount { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="StopCount"/> XML node when the value of <see cref="StopCount"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool StopCountSpecified { get; set; }

    /// <summary>
    /// The number to add to the count each time a message is printed.
    /// </summary>
    [XmlAttribute]
    public int Increment { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Increment"/> XML node when the value of <see cref="Increment"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool IncrementSpecified { get; set; }

    /// <summary>
    /// The number of digits in the count.  Used to determine leading zeros to be displayed.
    /// </summary>
    [XmlAttribute]
    public int NumberOfDigits { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="NumberOfDigits"/> XML node when the value of <see cref="NumberOfDigits"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool NumberOfDigitsSpecified { get; set; }

    /// <summary>
    /// The number of items that a full pallet can contain.
    /// </summary>
    [XmlAttribute]
    public int PalletSize { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="PalletSize"/> XML node when the value of <see cref="PalletSize"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool PalletSizeSpecified { get; set; }

    /// <summary>
    /// Indicates that the count contains alphanumeric digits.
    /// </summary>
    [XmlAttribute]
    public string AlphaCount
    {
        get => alphaCount.ToString();
        set => alphaCount = bool.Parse(value);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="AlphaCount"/> XML node when the value of <see cref="AlphaCount"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool AlphaCountSpecified { get; set; }
}
