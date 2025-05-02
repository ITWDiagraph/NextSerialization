namespace Diagraph.Message.Serialization;

/// <summary>
/// Contains string constants used by the message serializers.
/// </summary>
public static class Constants
{
    /// <summary>
    /// The XML namespace that must be injected into the XML of the message files
    /// to satisfy the requirements of <see cref="System.Xml.Serialization.XmlSerializer"/>.
    /// </summary>
    public const string ProductXmlNamespace = "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"";

    /// <summary>
    /// The XML declaration that must be injected into the XML of the message files
    /// to satisfy the requirements of <see cref="System.Xml.Serialization.XmlSerializer"/>.
    /// </summary>
    public const string XmlDeclaration = "<?xml version=\"1.0\"?>";

    /// <summary>
    /// The opening XML tag of a PRD message.
    /// </summary>
    public const string ProductTag = "<product";

    /// <summary>
    /// The opening XML tag of a grouped PRD message.
    /// </summary>
    public const string GroupTag = "<group";

    /// <summary>
    /// The opening XML tag of a NEXT message.
    /// </summary>
    public const string ProductObjectTag = "<ProductObject";
}
