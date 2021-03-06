﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VisioApi
{
	/// <summary>
	/// CoClass Comment 
	/// SupportByVersion Visio, 15, 16
	/// </summary>
	[SupportByVersion("Visio", 15, 16)]
	[EntityType(EntityType.IsCoClass)]
	[TypeId("000D0A41-0000-0000-C000-000000000046")]
 	public interface Comment : IVComment
	{

	}
}
