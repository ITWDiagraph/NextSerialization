namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// Enumerates the supported barcode types.
/// </summary>
public enum BarcodeTypes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [XmlEnum(Name = "Code128")]
    Code128,

    [XmlEnum(Name = "CODE39")]
    Code3of9,

    [XmlEnum(Name = "DataMatrix")]
    DataMatrix,

    [XmlEnum(Name = "EAN8")]
    Ean8,

    [XmlEnum(Name = "EAN13")]
    Ean13,

    [XmlEnum(Name = "GS1-Code128")]
    Gs1Code128,

    [XmlEnum(Name = "GS1-DataMatrix")]
    Gs1DataMatrix,

    [XmlEnum(Name = "GS1-QrCode")]
    Gs1QrCode,

    [XmlEnum(Name = "I2of5")]
    I2of5,

    [XmlEnum(Name = "QrCode")]
    QrCode,

    [XmlEnum(Name = "GTIN-14")]
    Scc14I2of5,

    [XmlEnum(Name = "UPCE")]
    UpcA,

    [XmlEnum(Name = "UPCA")]
    UpcE
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
