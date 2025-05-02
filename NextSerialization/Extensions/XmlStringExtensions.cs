using System.Text;

namespace Diagraph.Message.Serialization.Extensions;

/// <summary>
/// Extension methods for working with XML strings.
/// </summary>
public static class XmlStringExtensions
{
    /// <summary>
    /// Fixes missing 'xsi:type' XML namespace that prevents proper serialization of the original message.
    /// </summary>
    /// <param name="messageXml">The underlying XML string of the message.</param>
    /// <returns>The message XML with the namespace injected into the root node.</returns>
    public static string CorrectMessageXml(this string messageXml)
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
    /// <returns>The message XML with the namespace injected into the root node.</returns>
    private static string CorrectMessageXml(IEnumerable<string> messageLines)
    {
        var xmlDeclaration = messageLines.FirstOrDefault(line => line.StartsWith("<?xml")) ?? Constants.XmlDeclaration;

        var rootNode = messageLines.First(line =>
            line.StartsWith(Constants.ProductObjectTag) || line.StartsWith(Constants.ProductTag) || line.StartsWith(Constants.GroupTag));

        var restOfMessage = messageLines.FirstOrDefault(line => line.StartsWith(Constants.ProductObjectTag)) is not null
            ? messageLines.Skip(2)
            : messageLines.Skip(1);

        if (rootNode.Contains(Constants.ProductXmlNamespace, StringComparison.InvariantCultureIgnoreCase))
        {
            return string.Join(Environment.NewLine, messageLines);
        }

        var correctedRootNode = rootNode.StartsWith(Constants.GroupTag) ? rootNode.Replace(">", string.Empty) : rootNode.Split(" ").First();
        var rootNodeAttributes = rootNode.Split(" ").Skip(1);

        var newProductObjectNode = rootNode.StartsWith(Constants.GroupTag)
            ? $"{correctedRootNode} {Constants.ProductXmlNamespace}>"
            : $"{correctedRootNode} {Constants.ProductXmlNamespace} {string.Join(" ", rootNodeAttributes)}";

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
    /// Reads the entire file located at <paramref name="filePath"/>.
    /// </summary>
    /// <param name="filePath">The full file path for the NEXT/PRD message file.</param>
    /// <returns>A string with the contents of the file.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the contents of the file cannot be read.</exception>
    public static string ReadMessageFromFile(this string filePath)
    {
        return File.ReadAllText(filePath)
            ?? throw new InvalidOperationException($"Unable to read message data from {filePath}");
    }
}
