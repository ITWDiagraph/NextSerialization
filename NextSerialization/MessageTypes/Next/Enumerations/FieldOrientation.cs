namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// Enumerates orientation values for <see cref="FieldObject"/>s.
/// </summary>
public enum FieldOrientation
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [XmlEnum(Name = "Horizontal")]
    Horizontal,

    [XmlEnum(Name = "Vertical")]
    Vertical
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
