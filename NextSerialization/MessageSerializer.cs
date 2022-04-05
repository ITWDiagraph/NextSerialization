﻿namespace NextSerialization.MessageTypes.NextMessage.Serialization;
using System.Xml.Serialization;

/// <summary>
/// Contains methods for serializing and deserializing message data.
/// </summary>
public class MessageSerializer
{
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
    public T? ReadMessageFile<T>(string filePath) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StreamReader(filePath);
        return serializer.Deserialize(reader) as T;
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
    public T? ReadMessageXml<T>(string messageXml) where T : class
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
    public void WriteMessageFile<T>(T messageRoot, string fileName) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));
        using TextWriter writer = new StreamWriter(fileName);
        serializer.Serialize(writer, messageRoot);
        writer.Close();
    }
}
