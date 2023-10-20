using System.Xml.Serialization;

namespace Diagraph.Message.Next;
/// <summary>
/// Defines the properties needed to connect to a database, Excel, or CSV file along with the table and 
/// columns to use as the source for data on a <see cref="VariableField"/>.
/// </summary>
/// <remarks>The <see cref="DataSource"/> class corresponds to the DataSetObject node of the message XML.</remarks>
[XmlType(TypeName = nameof(DataSource))]
public class DataSource
{
    /// <summary>
    /// The data columns displayed to the user when creating a <see cref="VariableField"/> element.
    /// </summary>
    [XmlArray("DisplayColumns")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[]? DisplayColumns { get; set; }

    /// <summary>
    /// The data columns available to draw data from.
    /// </summary>
    [XmlArray("DataColumns")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[]? DataColumns { get; set; }

    /// <summary>
    /// The default columns and values displayed to the user.
    /// </summary>
    [XmlArray("ColumnValues")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[]? ColumnValues { get; set; }

    /// <summary>
    /// The database or spreadsheet name.
    /// </summary>
    [XmlAttribute]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The name of the database table or Excel sheet.
    /// </summary>
    [XmlAttribute]
    public string TableName { get; set; } = string.Empty;

    /// <summary>
    /// An identifier used to indicate the connection information to use.
    /// </summary>
    /// <remarks>
    /// The database connection information is stored in a separate file.
    /// </remarks>
    [XmlAttribute]
    public string DataConnection { get; set; } = Guid.Empty.ToString();

    /// <summary>
    /// A unique (GUID) identifier for the data source.
    /// </summary>
    [XmlAttribute("ID")]
    public string Id { get; set; } = Guid.Empty.ToString();
}
