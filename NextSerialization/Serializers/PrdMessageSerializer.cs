using System.Xml.Serialization;

using Diagraph.Message.Serialization.Extensions;
using Diagraph.Message.Serialization.Interfaces;

namespace Diagraph.Message.Serialization.Serializers;

/// <inheritdoc/>
public class PrdMessageSerializer : IMessageSerializer
{
    /// <inheritdoc/>
    public IMessage? ReadMessageFile(string filePath) => ReadMessageXml(filePath.ReadMessageFromFile());

    /// <inheritdoc/>
    public IMessage? ReadMessageXml(string messageXml)
    {
        var serializer = new XmlSerializer(typeof(MessageTypes.Prd.Message));
        using var reader = new StringReader(messageXml.CorrectMessageXml());
        return (IMessage)(serializer.Deserialize(reader) as MessageTypes.Prd.Message)!;
    }

    /// <inheritdoc/>
    public void WriteMessageFile(IMessage message, string filePath)
    {
        var serializer = new XmlSerializer(typeof(MessageTypes.Prd.Message));
        using TextWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, message);
        writer.Close();
    }
}
