namespace Diagraph.Message.Serialization.MessageTypes.Prd;

/// <summary>
/// Wrapper class for a PRD.
/// </summary>
public class PrdMessage
{
    /// <summary>
    /// Represents the root node of the XML contained in the PRD message data.
    /// </summary>
    public Prd.Message? Product { get; set; }
}
