
using System;
using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// A collection of external file resources.
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Resources
{
    /// <summary>
    /// The collection of <see cref="Resource"/> elements.
    /// </summary>
    public Resource[]? Resource { get; set; }
}
