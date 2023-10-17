namespace Diagraph.Message.Next.Interfaces;

/// <summary>
/// Defines properties that describe shapes, like lines and rectangles, to be rendered on the message.
/// </summary>
public interface IShapeObject
{
    /// <summary>
    /// Indicates whether the shape is oriented horizontally or vertically.
    /// </summary>
    public string? Orientation { get; set; }

    /// <summary>
    /// The thickness of the bounding lines of the shape.
    /// </summary>
    public LineThickness? LineThickness { get; set; }
}
