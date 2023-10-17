using System.Xml.Serialization;

namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// 
/// </summary>
public enum PrintResolutions
{
    /// <summary>
    /// ResMark 150 DPI
    /// </summary>
    [XmlEnum(Name = "150")]
    Low,

    /// <summary>
    /// ResMark 200 DPI
    /// </summary>
    [XmlEnum(Name = "200")]
    Medium,

    /// <summary>
    /// ResMark 300 DPI
    /// </summary>
    [XmlEnum(Name = "300")]
    High
}
