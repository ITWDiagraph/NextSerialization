using Diagraph.Message.Serialization.Interfaces;

namespace Diagraph.Message.Serialization.Serializers;

/// <summary>
/// Factory class used to create the correct <see cref="IMessageSerializer"/> according to 
/// the contents of a message file or string.
/// </summary>
public static class MessageSerializerFactory
{
    /// <summary>
    /// Reads <paramref name="messageXmlContent"/> and creates an <see cref="IMessageSerializer"/>
    /// appropriate for the message data contained in <paramref name="messageXmlContent"/>.
    /// </summary>
    /// <param name="messageXmlContent">
    /// An XML string with PRD, Grouped PRD, or NEXT message data.
    /// </param>
    /// <returns>
    /// An <see cref="IMessageSerializer"/> capable of serialization and deserialization of
    /// the content of <paramref name="messageXmlContent"/>.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the content of <paramref name="messageXmlContent"/>
    /// does not represent one of the known message types.
    /// </exception>
    public static IMessageSerializer CreateSerializerFromContent(string messageXmlContent) =>
        messageXmlContent switch
        {
            var s when s.Contains("<group") => new GroupMessageSerializer(),
            var s when s.Contains("<product") => new PrdMessageSerializer(),
            var s when s.Contains("<ProductObject") => new NextMessageSerializer(),
            _ => throw new InvalidOperationException("Unknown message type.")
        };

    /// <summary>
    /// Reads the contents of the file located at <paramref name="filePath"/> and creates an <see cref="IMessageSerializer"/>
    /// appropriate for the message data contained in the file located at <paramref name="filePath"/>.
    /// </summary>
    /// <param name="filePath">
    /// The full path to the message file.
    /// </param>
    /// <returns>
    /// An <see cref="IMessageSerializer"/> capable of serialization and deserialization of
    /// the content of the file located at <paramref name="filePath"/>.
    /// </returns>
    public static IMessageSerializer CreateSerializerFromFile(string filePath) =>
        CreateSerializerFromContent(File.ReadAllText(filePath));
}