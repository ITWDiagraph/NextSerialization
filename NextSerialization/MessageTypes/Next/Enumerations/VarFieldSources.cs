using System.Xml.Serialization;

namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// Enumerates the possible values of <see cref="DataSource"/>s for <see cref="VariableField"/> objects.
/// </summary>
public enum VarFieldSources
{
    /// <summary>
    /// Indicates that variable field data is obtained from a COM Port.
    /// </summary>
    [XmlEnum(Name = "Comm")]
    ComPort,

    /// <summary>
    /// Indicates that variable field data is obtained from an external source.
    /// </summary>
    [XmlEnum(Name = "Data")]
    Data,

    /// <summary>
    /// Indicates that variable field data is obtained from a database.
    /// </summary>
    [XmlEnum(Name = "Database")]
    Database
}
