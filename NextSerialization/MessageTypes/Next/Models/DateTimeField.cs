namespace NextSerialization.MessageTypes.Next;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.Next.Interfaces;

/// <summary>
/// Represents a textual element consisting of a formatted date and/or timestamp including configured
/// day/week/month/year offsets.
/// </summary>
[Serializable]
[XmlType(TypeName = "DateTimeFieldObject")]
public class DateTimeField : TextField, IFontObject
{
    /// <summary>
    /// The number of days to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Days { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Days"/> XML node when the value of <see cref="Days"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool DaysSpecified { get; set; }

    /// <summary>
    /// The number of weeks to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Weeks { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Weeks"/> XML node when the value of <see cref="Weeks"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool WeeksSpecified { get; set; }

    /// <summary>
    /// The number of months to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Months { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Months"/> XML node when the value of <see cref="Months"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool MonthsSpecified { get; set; }

    /// <summary>
    /// The number of years to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Years { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Years"/> XML node when the value of <see cref="Years"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool YearsSpecified { get; set; }

    /// <summary>
    /// A string that describes the ouptut format.
    ///
    /// <list type="table">
    /// <listheader>
    ///     <term>Date Format</term>
    ///     <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///     <term>[d]</term>
    ///     <description>Day (1-31)</description>
    ///     </item>
    ///     <item>
    ///     <term>[dd]</term>
    ///     <description>Day (01-31)</description>
    ///     </item>
    ///     <item>
    ///     <term>[DD]</term>
    ///     <description>Day (Julian)</description>
    ///     </item>
    ///     <item>
    ///     <term>[ddd]</term>
    ///     <description>Day (Mon-Sun)</description>
    ///     </item>
    ///     <item>
    ///     <term>[dddd]</term>
    ///     <description>Day (Monday-Sunday)</description>
    ///     </item>
    ///     <item>
    ///     <term>[DM]</term>
    ///     <description>Day of Month (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[DW]</term>
    ///     <description>Day of Week (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[M]</term>
    ///     <description>Month (1-12)</description>
    ///     </item>
    ///     <item>
    ///     <term>[MM]</term>
    ///     <description>Month (01-12)</description>
    ///     </item>
    ///     <item>
    ///     <term>[MMM]</term>
    ///     <description>Month (JAN-DEC)</description>
    ///     </item>
    ///     <item>
    ///     <term>[MMMM]</term>
    ///     <description>Month (January-December)</description>
    ///     </item>
    ///     <item>
    ///     <term>[MMMMM]</term>
    ///     <description>Month (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[wwww]</term>
    ///     <description>Week (01-53)</description>
    ///     </item>
    ///     <item>
    ///     <term>[WWWW]</term>
    ///     <description>Week (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[y]</term>
    ///     <description>Year (0-9)</description>
    ///     </item>
    ///     <item>
    ///     <term>[yy]</term>
    ///     <description>Year (00-99)</description>
    ///     </item>
    ///     <item>
    ///     <term>[yyyy]</term>
    ///     <description>Year (0000-9999)</description>
    ///     </item>
    ///     <item>
    ///     <term>[YYYY]</term>
    ///     <description>Year (User Defined)</description>
    ///     </item>
    ///     </list>
    ///
    ///  <list type="table">
    ///     <listheader>
    ///     <term>Time Format</term>
    ///     <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///     <term>[h]</term>
    ///     <description>Hour (1-12)</description>
    ///     </item>
    ///     <item>
    ///     <term>[H]</term>
    ///     <description>Hour (0-23)</description>
    ///     </item>
    ///     <item>
    ///     <term>[hh]</term>
    ///     <description>Hour (01-12)</description>
    ///     </item>
    ///     <item>
    ///     <term>[HH]</term>
    ///     <description>Hour (00-23)</description>
    ///     </item>
    ///     <item>
    ///     <term>[HHH]</term>
    ///     <description>Hour (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[m]</term>
    ///     <description>Minute (0-59)</description>
    ///     </item>
    ///     <item>
    ///     <term>[mm]</term>
    ///     <description>Minute (00-59)</description>
    ///     </item>
    ///     <item>
    ///     <term>[mmm]</term>
    ///     <description>Minute (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[qh]</term>
    ///     <description>Quarter Hour (00-95)</description>
    ///     </item>
    ///     <item>
    ///     <term>[QH]</term>
    ///     <description>Quarter Hour (User Defined)</description>
    ///     </item>
    ///     <item>
    ///     <term>[s]</term>
    ///     <description>Second (0-59)</description>
    ///     </item>
    ///     <item>
    ///     <term>[ss]</term>
    ///     <description>Second (00-59)</description>
    ///     </item>
    /// </list>
    ///
    /// <list type="table">
    ///     <listheader>
    ///     <term>Format Modifier</term>
    ///     <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///     <term>[a]</term>
    ///     <description>am/pm</description>
    ///     </item>
    ///     <item>
    ///     <term>[A]</term>
    ///     <description>AM/PM</description>
    ///     </item>
    ///     <item>
    ///     <term>[ap]</term>
    ///     <description>am/pm</description>
    ///     </item>
    ///     <item>
    ///     <term>[AP]</term>
    ///     <description>AM/PM</description>
    ///     </item>
    ///     <item>
    ///     <term>[n]</term>
    ///     <description>Next Line</description>
    ///     </item>
    ///     <item>
    ///     <term>[shift]</term>
    ///     <description>Shift code</description>
    ///     </item>
    ///     <item>
    ///     <term>[t]</term>
    ///     <description>Timezone</description>
    ///     </item>
    ///     <item>
    ///     <term>[tab]</term>
    ///     <description>Tab</description>
    ///     </item>
    /// </list>
    /// </summary>
    [XmlAttribute]
    public string? Format { get; set; }
}
