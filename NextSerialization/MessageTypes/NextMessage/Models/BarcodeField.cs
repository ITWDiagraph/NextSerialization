﻿namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Represents data encoded and rendered as a barcode.
/// </summary>
[Serializable]
[XmlType(TypeName = "BarcodeFieldObject")]
public class BarcodeField : FieldObject
{
    /// <summary>
    /// The type of barcode to render.
    /// </summary>
    // TODO: Enumerate available barcode types.
    [XmlAttribute(AttributeName = "Type")]
    public string? BarcodeType { get; set; }

    /// <summary>
    /// Defines barcode specific information required to properly render the barcode.
    /// </summary>
    [XmlElement(ElementName = "Parameters", IsNullable = false)]
    public Parameters? Parameters { get; set; }

    /// <summary>
    /// Defines the typeface of human readable text displayed with the barcode.
    /// </summary>
    [XmlElement("Font", IsNullable = false)]
    public Font? Font { get; set; }

    /// <summary>
    /// A collection of sub-elements that are used to define the data encoded into the barcode.
    /// </summary>
    /// <remarks>
    /// The aggregated output of all of the <see cref="FieldObject"/>s in the collection must satisfy
    /// the validation conditions for the <see cref="BarcodeType"/> specified.</remarks>
    [XmlElement("FieldObject")]
    public FieldObject[]? FieldObject { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="FieldObject"/> XML nodes when the value of <see cref="FieldObject"/> is null or empty.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool FieldObjectSpecified { get; set; }
}
