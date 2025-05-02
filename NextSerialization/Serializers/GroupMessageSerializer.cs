using System.Xml.Serialization;

using Diagraph.Message.Serialization.Extensions;
using Diagraph.Message.Serialization.Interfaces;

namespace Diagraph.Message.Serialization.Serializers;

/// <inheritdoc/>
class GroupMessageSerializer : IMessageSerializer
{
    /// <inheritdoc/>
    public IMessage? ReadMessageFile(string filePath) => ReadMessageXml(filePath.ReadMessageFromFile());

    /// <inheritdoc/>
    public IMessage? ReadMessageXml(string messageXml)
    {
        var serializer = new XmlSerializer(typeof(MessageTypes.Prd.GroupMessage));
        using var reader = new StringReader(messageXml.CorrectMessageXml());
        return (IMessage)(serializer.Deserialize(reader) as MessageTypes.Prd.GroupMessage)!;
    }

    /// <inheritdoc/>
    public void WriteMessageFile(IMessage message, string filePath)
    {
        var serializer = new XmlSerializer(typeof(MessageTypes.Prd.GroupMessage));
        using TextWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, message);
        writer.Close();
    }
}
