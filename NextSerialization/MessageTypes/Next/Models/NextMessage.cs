namespace Diagraph.Message.Next;

/// <summary>
/// Wrapper class for the data contained in the NEXT message file.
/// </summary>
public class NextMessage
{
    /// <summary>
    /// Represents the root node of the XML contained in the NEXT message data.
    /// </summary>
    public Product? Product { get; set; }
}
