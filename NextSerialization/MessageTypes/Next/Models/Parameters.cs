using System.Xml.Serialization;

using Diagraph.Message.Next.Enumerations;

namespace Diagraph.Message.Next;
/// <summary>
/// Defines aspects of the barcode required to validate and render properly.
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Parameters
{
    private decimal _ratio;
    private bool _isHumanReadable;
    private bool _checksum;
    private bool _caseSensitive;

    /// <summary>
    /// Used to prevent the direct printing pressure from being concentrated on the barcode and to keep the printing pressure even.
    /// </summary>
    [XmlElement(IsNullable = false)]
    public Bearer? Bearer { get; set; }

    /// <summary>
    /// Specifies the width of the narrowest element, whether it's a bar or space, in thousandths of an inch.
    /// </summary>
    [XmlAttribute]
    public int MilSize { get; set; }

    /// <summary>
    /// The quiet zone is the area that surrounds the barcode or 2D symbol that is free of all text, characters, graphics, marks, and blemishes.
    /// This blank space allows verifiers or readers to " understand" where the barcode begins and ends so the code can be read as intended.
    /// </summary>
    [XmlAttribute]
    public decimal QuietZone { get; set; }

    /// <summary>
    /// Indicates that the textual representation of the barcode data is also rendered.
    /// </summary>
    [XmlAttribute]
    public string IsHumanReadable
    {
        get => _isHumanReadable.ToString();
        set => _isHumanReadable = bool.Parse(value);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="IsHumanReadable"/> XML node when the value of <see cref="IsHumanReadable"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool IsHumanReadableSpecified { get; set; }

    /// <summary>
    /// The differenc of width of the thin and thick bars on an I2 of 5 barcode type.
    /// </summary>
    [XmlAttribute("Ratio")]
    public string FormattedRatio
    {
        get => _ratio.ToString("F3");
        set => _ = decimal.TryParse(value, out _ratio);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="FormattedRatio"/> XML node when the value of <see cref="FormattedRatio"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool FormattedRatioSpecified { get; set; }

    /// <summary>
    /// The number located on the far right side of a bar code. The purpose of a check digit is to verify 
    /// that the information on the barcode has been entered correctly.
    /// </summary>
    [XmlAttribute]
    public string Checksum
    {
        get => _checksum.ToString();
        set => _checksum = bool.Parse(value);
    }
    /// <summary>
    /// Tells the serializer to omit the <see cref="Checksum"/> XML node when the value of <see cref="Checksum"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool ChecksumSpecified { get; set; }

    /// <summary>
    /// Specifies the type of encoding for the barcode.
    /// </summary>
    [XmlAttribute]
    public BarcodeEncoding Encoding { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Encoding"/> XML node when the value of <see cref="Encoding"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool EncodingSpecified { get; set; }

    /// <summary>
    /// Indicates whether the barcode is case sensitive or not.
    /// </summary>
    [XmlAttribute]
    public string CaseSensitive
    {
        get => _caseSensitive.ToString();
        set => _caseSensitive = bool.Parse(value);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="CaseSensitive"/> XML node when the value of <see cref="CaseSensitive"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool CaseSensitiveSpecified { get; set; }

    /// <summary>
    /// The horizontal dimention of the barcode.
    /// </summary>
    [XmlAttribute]
    public int Width { get; set; }

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
    /// The vertical dimension of the barcode.
    /// </summary>
    [XmlAttribute]
    public int Height { get; set; }

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
