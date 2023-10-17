namespace Diagraph.Message.Next.Interfaces;

/// <summary>
/// Defines properties that describe a font element that is rendered as part of another rendered 
/// element, such as <see cref="TextField"/> or <see cref="BarcodeField"/>.
/// </summary>
public interface IFontObject
{
    /// <summary>
    /// The name of the font to be rendered.
    /// </summary>
    public string? Family { get; set; }

    /// <summary>
    /// The style to render the font (e.g. Italic, Bold, etc.).
    /// </summary>
    public string? Style { get; set; }
}
