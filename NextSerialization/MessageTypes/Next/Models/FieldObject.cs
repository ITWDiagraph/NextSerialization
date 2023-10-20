using System.Xml.Serialization;

using Diagraph.Message.Next.Interfaces;

namespace Diagraph.Message.Next;
/// <summary>
/// Contains properties that are used to define a general content element on
/// a <see cref="NextMessage"/> file and serves as the base class for the all derived
/// fields.
/// <h2>Derived Fields</h2>
/// <list type="table">
/// <item><term><seealso cref="BarcodeField"/></term><description>Defines the barcode type and other rendering aspects needed to render and print a barcode element.</description></item>
/// <item><term><seealso cref="CountField"/></term><description>Defines the properties needed to render and print an incremental count element.</description></item>
/// <item><term><seealso cref="DateTimeField"/></term><description>Defines the format and style for rendering and printing a date or time element.</description></item>
/// <item><term><seealso cref="LineField"/></term><description>Defines the length, line weight, and orientation to render and print a line element.</description></item>
/// <item><term><seealso cref="LogoField"/></term><description>Defines the file name and dimentions required to render and print an image element.</description></item>
/// <item><term><seealso cref="RectangleField"/></term><description>Defines the length, width, line weight, and orientation to render and print a rectangular element.</description></item>
/// <item><term><seealso cref="TextField"/></term><description>Defines the font and other aspects required to render and print a text element.</description></item>
/// <item><term><seealso cref="VariableField"/></term><description>Defines the data source and other aspects to render and print a data bound element.</description></item>
/// </list>
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
[XmlInclude(typeof(LogoField))]
[XmlInclude(typeof(LineField))]
[XmlInclude(typeof(CountField))]
[XmlInclude(typeof(DateTimeField))]
[XmlInclude(typeof(BarcodeField))]
[XmlInclude(typeof(RectangleField))]
[XmlInclude(typeof(TextField))]
[XmlInclude(typeof(VariableField))]
public abstract class FieldObject : IFieldObject
{
    /// <summary>
    /// The horizontal distance that the element will be rendered measured, in inches, from the top left corner of the message.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="X"/> coordinate are localized in the UI but will always be saved in the message file in inches.</remarks>
    [XmlAttribute]
    public decimal X { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="X"/> XML node when the value of <see cref="X"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool XSpecified { get; set; }

    /// <summary>
    /// The vertical distance that the element will be rendered measured, in inches, from the top left corner of the message.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="Y"/> coordinate are localized in the UI but will always be saved in the message file in inches.</remarks>
    [XmlAttribute]
    public decimal Y { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Y"/> XML node when the value of <see cref="Y"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool YSpecified { get; set; }

    /// <summary>
    /// The horizontal measurement of the size of the element.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="Width"/> are localized in the UI but will always be saved in the message file in inches.</remarks>
    [XmlAttribute]
    public virtual decimal Width { get; set; }

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
    /// The vertical measurement of the size of the element.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="Height"/> are localized in the UI but will always be saved in the message file in inches.</remarks>
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

    /// <summary>
    /// Indicates that the element's aspect ratio should be maintained when resizing.
    /// </summary>
    [XmlAttribute]
    public string? LockAspectRatio { get; set; }

    /// <summary>
    /// Function 1 Symbol Character used as a data separator in GS1 barcodes.
    /// </summary>
    /// <remarks>Note: <see cref="FNC1"/> is only used when a <see cref="FieldObject"/> is a sub-element of a <see cref="BarcodeField"/> element.</remarks>
    [XmlAttribute]
    public virtual string? FNC1 { get; set; }

    /// <summary>
    /// The GS1 application identifier code.
    /// </summary>
    [XmlAttribute(AttributeName = "AI")]
    public virtual string? Ai { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Height"/> XML node when the value of <see cref="Height"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool AiSpecified { get; set; }

    /// <summary>
    /// A regular expression used to validate that the data generated satisfies the configured restraints for the selected GS1 
    /// application identifier.
    /// </summary>
    /// <remarks>
    /// The value of the <see cref="Regex"/> attribute is typically generated by the NEXT Create UI.  Setting the value
    /// of the <see cref="Regex"/> attribute to an arbitrary regular expression may yield unexpected results.
    /// </remarks>
    [XmlAttribute]
    public string? Regex { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Regex"/> XML node when the value of <see cref="Regex"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool RegexSpecified { get; set; }
}
