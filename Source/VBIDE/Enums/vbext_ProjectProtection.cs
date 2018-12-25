﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.VBIDEApi.Enums
{
	 /// <summary>
	 /// SupportByVersion VBIDE 5.3, 12, 14, 15
	 /// </summary>
	[SupportByVersion("VBIDE", 5.3,12,14,15)]
	[EntityType(EntityType.IsEnum)]
	public enum vbext_ProjectProtection
	{
		 /// <summary>
		 /// SupportByVersion VBIDE 5.3, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("VBIDE", 5.3,12,14,15)]
		 vbext_pp_none = 0,

		 /// <summary>
		 /// SupportByVersion VBIDE 5.3, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("VBIDE", 5.3,12,14,15)]
		 vbext_pp_locked = 1
	}
}