namespace Diagraph.Message.Next.Interfaces;

/// <summary>
/// Defines properties that are intrinsic to any element to be rendered.
/// </summary>
public interface IFieldObject
{
    /// <summary>
    /// The horizontal distance that the element will be rendered measured, in inches, from the top left corner of the message.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="X"/> coordinate are localized in the UI but will always be saved in the message file in inches.</remarks>
    public decimal X { get; set; }

    /// <summary>
    /// The vertical distance that the element will be rendered measured from the top left corner of the message.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="Y"/> coordinate are localized in the UI but will always be saved in the message file in inches.</remarks>
    public decimal Y { get; set; }

    /// <summary>
    /// Indicates that the element's aspect ratio should be maintained when resizing.
    /// </summary>
    public string? LockAspectRatio { get; set; }

    /// <summary>
    /// The vertical measurement of the size of the element.
    /// </summary>
    /// <remarks>The units of measure for the <see cref="Height"/> are localized in the UI but will always be saved in the message file in inches.</remarks>
    public decimal Height { get; set; }

    /// <summary>
    /// Function 1 Symbol Character used as a data separator in GS1 barcodes.
    /// </summary>
    /// <remarks>Note: <see cref="FNC1"/> is only used when a <see cref="FieldObject"/> is a sub-element of a <see cref="BarcodeField"/> element.</remarks>
    public string? FNC1 { get; set; }
}
