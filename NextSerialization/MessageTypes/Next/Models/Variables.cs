
using System;
using System.Xml.Serialization;

namespace NextSerialization.MessageTypes.Next;
/// <summary>
/// Defines a collection of data connections and source columns for <see cref="VariableField"/> elements.
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Variables
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("Comm")]
    [XmlArrayItem("Comm")]
    public ComPortData[]? ComPortSources { get; set; }

    /// <summary>
    /// Defines a DataSet XML element that represents the collection of DataSetObjects.  DataSetObject represents
    /// a connection to a database, Excel, or CSV file and the corresponding columns available to use as sources
    /// of data for rendering in a <see cref="VariableField"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="XmlArrayAttribute"/> and <see cref="XmlArrayItemAttribute"/> are both applied to the
    /// <see cref="DataSources"/> property in order to match the required XML structure without the need for extra classes and properties. 
    /// </remarks>
    [XmlArray("DataSet")]
    [XmlArrayItem("DataSetObject", IsNullable = false)]
    public DataSource[]? DataSources { get; set; }
}
