﻿using System.Xml.Serialization;

namespace Diagraph.Message.Next.Enumerations;
/// <summary>
/// 
/// </summary>
public enum PrintHeadTypes
{
    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "384")]
    Mark2,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "768")]
    Mark4
}
