using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Represents a database or CSV column of data.
/// </summary>
[Serializable]
public class Column
{
    /// <summary>
    /// The database name for the column or the CSV/Excel column heading.
    /// </summary>
    [XmlAttribute]
    public string? Name { get; set; }

    /// <summary>
    /// The value from a row in the <see cref="Column"/> to use as the default value to
    /// display on the message surface.  Each time the message prints, the value from the 
    /// next row of data will be rendered.
    /// </summary>
    [XmlAttribute]
    public string? Value { get; set; }
}
