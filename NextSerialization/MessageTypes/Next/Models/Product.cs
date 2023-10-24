using System.Xml.Serialization;

using Diagraph.Message.Next.Enumerations;

namespace Diagraph.Message.Next;
/// <summary>
/// Represents the item that the message data describes and serves as the root XML element of the message file.
/// </summary>
[Serializable]
[XmlRoot(ElementName = "ProductObject", Namespace = "", IsNullable = false)]
public class Product
{
    private bool _usePrintCount;
    private bool _continuousPrint;

    /// <summary>
    /// The name of the message.
    /// </summary>
    [XmlAttribute]
    public string? Name { get; set; }

    /// <summary>
    /// The distance between messages.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="GapBetweenPrint"/> are localized in the UI but will always be saved in the message file in inches.</remarks>
    [XmlAttribute]
    public decimal GapBetweenPrint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int HorizontalSpacing { get; set; }

    /// <summary>
    /// Indicates the print technology to use for the message.
    /// </summary>
    /// <remarks>Currently the only valid value is 'HighResTask'.</remarks>
    [XmlAttribute]
    public TaskTypes TaskType { get; set; }

    /// <summary>
    /// The number of times to print the message before stopping.
    /// </summary>
    [XmlAttribute]
    public int PrintCount { get; set; }

    /// <summary>
    /// Indicates the the message shoule be printed <see cref="PrintCount"/> times and then printing should stop.
    /// </summary>
    [XmlAttribute]
    public string UsePrintCount
    {
        get => _usePrintCount.ToString();
        set => _usePrintCount = bool.Parse(value);
    }

    /// <summary>
    /// Indicates that the message should be printed as long as the photocell indicates that
    /// a surface is in front of the print heads.
    /// </summary>
    [XmlAttribute]
    public string ContinuousPrint
    {
        get => _continuousPrint.ToString();
        set => _continuousPrint = bool.Parse(value);
    }

    /// <summary>
    /// Specifies the horizontal resolution for the message.
    /// </summary>
    /// <remarks>
    /// Valid values for message DPI are <see cref="PrintResolutions.Low"/> for 150 DPI and <see cref="PrintResolutions.High"/> for 300 DPI
    /// </remarks>
    [XmlAttribute("DPI")]
    public PrintResolutions Dpi { get; set; }

    /// <summary>
    /// Defines the area to remain blank on either side of the message.
    /// </summary>
    [XmlElement("Margin", IsNullable = false)]
    public Margin? Margin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Box", IsNullable = false)]
    public Box? Box { get; set; }

    /// <summary>
    /// Defines a collection of data connections and source columns for <see cref="VariableField"/> elements.
    /// </summary>
    [XmlElement("Variables")]
    public Variables? Variables { get; set; }

    /// <summary>
    /// Represents a <see cref="Product"/> surface in which message data will be printed.
    /// </summary>
    /// <remarks>
    /// <b>NOTE:</b> Only the "Front" <see cref="Panel"/> is currently supported.
    /// </remarks>
    [XmlElement("Panel")]
    public Panel[]? Panel { get; set; }

    /// <summary>
    /// Defines external resources, such as images, that are used to render fields on the message.
    /// </summary>
    [XmlArray("Resources")]
    [XmlArrayItem("Resource", IsNullable = false)]
    public Resource[]? Resources { get; set; }
}
