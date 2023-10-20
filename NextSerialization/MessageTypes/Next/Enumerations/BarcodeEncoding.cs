namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// Enumerates supported barcode encoding types.
/// </summary>
public enum BarcodeEncoding
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [XmlEnum(Name = "8-Bit")]
    EightBit,

    [XmlEnum(Name = "AlphaNumeric")]
    AlphaNumeric,

    [XmlEnum(Name = "ASCII")]
    Ascii,

    [XmlEnum(Name = "Best")]
    Best,

    [XmlEnum(Name = "Binary")]
    Binary,

    [XmlEnum(Name = "ECI")]
    Eci,

    [XmlEnum(Name = "EDIFACT")]
    EdiFact,

    [XmlEnum(Name = "Fast")]
    Fast,

    [XmlEnum(Name = "FNC1 first")]
    Fnc1First,

    [XmlEnum(Name = "FNC1 second")]
    Fnc1Second,

    [XmlEnum(Name = "Kanji")]
    Kanji,

    [XmlEnum(Name = "Numeric")]
    Numeric,

    [XmlEnum(Name = "Text")]
    Text,

    [XmlEnum(Name = "X12")]
    X12
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
