using System.Text;
using System.Xml.Serialization;

namespace Diagraph.Message.Next.Serialization;
/// <summary>
/// Contains methods for serializing and deserializing message data.
/// </summary>
public class MessageSerializer
{
    const string ProductXmlNamespace = "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"";

    /// <summary>
    /// Reads the message file and deserializes the XML data into the object tree where the root object <typeparamref name="T"/> 
    /// corresponds to the XML root node.
    /// </summary>
    /// <param name="filePath">The full or relative path and name of the message file to be read.</param>
    /// <typeparam name="T">The type represented by the root node of the message XML data.</typeparam>
    /// <returns>
    /// An object of type <typeparamref name="T"/> corresponding to the root node of the XML from <paramref name="filePath"/> and hydrated with
    /// data from the XML nodes and attributes.
    /// </returns>
    public static T? ReadMessageFile<T>(string filePath) where T : class =>
        ReadMessageXml<T>(CorrectMessageXml(File.ReadLines(filePath)));

    /// <summary>
    /// Fixes missing 'xsi:type' XML namespace that prevents proper serialization of the original message.
    /// </summary>
    /// <param name="messageXml">The underlying XML string of the message.</param>
    /// <returns>The message XML with the namespace injected into the <see cref="Product"/> node.</returns>
    public static string CorrectMessageXml(string messageXml)
    {
        var messageLines = new List<string>();
        using var reader = new StringReader(messageXml);

        while (true)
        {
            var line = reader.ReadLine();

            if (line is null)
            {
                break;
            }

            messageLines.Add(line);
        }

        return CorrectMessageXml(messageLines);
    }

    /// <summary>
    /// Fixes missing 'xsi:type' XML namespace that prevents proper serialization of the original message.
    /// </summary>
    /// <param name="messageLines">An enumerable collection of lines of the message.</param>
    /// <returns>The message XML with the namespace injected into the <see cref="Product"/> node.</returns>
    public static string CorrectMessageXml(IEnumerable<string> messageLines)
    {
        var xmlDeclaration = messageLines.First(line => line.StartsWith("<?xml"));
        var productObjectNode = messageLines.First(line => line.StartsWith("<ProductObject"));
        var restOfMessage = messageLines.Skip(2);

        if (productObjectNode.Contains(ProductXmlNamespace, StringComparison.InvariantCultureIgnoreCase))
        {
            return string.Join(Environment.NewLine, messageLines);
        }

        var productObjectTag = productObjectNode.Split(" ").First();
        var productObjectAttribs = productObjectNode.Split(" ").Skip(1);

        var newProductObjectNode = $"{productObjectTag} {ProductXmlNamespace} {string.Join(" ", productObjectAttribs)}";

        var builder = new StringBuilder();
        builder.AppendLine(xmlDeclaration);
        builder.AppendLine(newProductObjectNode);
        foreach (var line in restOfMessage)
        {
            builder.AppendLine(line);
        }

        return builder.ToString();
    }

    /// <summary>
    /// Reads a string representing the message and deserializes the XML data into the object tree where the root object <typeparamref name="T"/> 
    /// corresponds to the XML root node.
    /// </summary>
    /// <typeparam name="T">The type represented by the root node of the message XML data.</typeparam>
    /// <param name="messageXml">A string containing XML data that represents a message.</param>
    /// <returns>
    /// An object of type <typeparamref name="T"/> corresponding to the root node of the XML from <paramref name="messageXml"/> and hydrated with
    /// data from the XML nodes and attributes.
    /// </returns>
    public static T? ReadMessageXml<T>(string messageXml) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StringReader(messageXml);
        return serializer.Deserialize(reader) as T;
    }

    /// <summary>
    /// Writes the data from <paramref name="messageRoot"/> as XML to the the file specified by <paramref name="fileName"/>.
    /// </summary>
    /// <typeparam name="T">The type represented by the root node of the message XML data.</typeparam>
    /// <param name="messageRoot">The object that represents the root node of the XML that will be written to the message file.</param>
    /// <param name="fileName">The full path and name of the file to be written.</param>
    public static void WriteMessageFile<T>(T messageRoot, string fileName) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));
        using TextWriter writer = new StreamWriter(fileName);
        serializer.Serialize(writer, messageRoot);
        writer.Close();
    }
}
