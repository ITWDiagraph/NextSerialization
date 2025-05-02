namespace Diagraph.Message.Serialization.Interfaces;

/// <summary>
/// Contains methods for serializing and deserializing NEXT message data.
/// </summary>
public interface IMessageSerializer
{
    /// <summary>
    /// Reads the message file and deserializes the XML data into an <see cref="IMessage"/>.
    /// </summary>
    /// <param name="filePath">
    /// The full or relative path and name of the message file to be read.
    /// </param>
    /// <returns>
    /// A <see cref="IMessage"/> object hydrated with data from the XML nodes and attributes from 
    /// the contents of the file located at <paramref name="filePath"/>.
    /// </returns>
    IMessage? ReadMessageFile(string filePath);

    /// <summary>
    /// Reads a string representing the message and deserializes the XML data into the object tree where the root node 
    /// corresponds to an object that implements <see cref="IMessage"/>.
    /// </summary>
    /// <param name="messageXml">
    /// A string containing XML data that represents a <see cref="MessageTypes.Next.Message"/>
    /// </param>
    /// <returns>
    /// A <see cref="IMessage"/> object hydrated with data from the XML nodes and attributes from 
    /// the contents <paramref name="messageXml"/>.
    /// </returns>
    IMessage? ReadMessageXml(string messageXml);

    /// <summary>
    /// Writes the data from <paramref name="message"/> as XML to the the file specified by <paramref name="filePath"/>.
    /// </summary>
    /// <param name="message">
    /// The <see cref="IMessage"/> object that represents the root node of the XML that will be written to the message file.
    /// </param>
    /// <param name="filePath">
    /// The full path and name of the file to be written.
    /// </param>
    void WriteMessageFile(IMessage message, string filePath);
}
