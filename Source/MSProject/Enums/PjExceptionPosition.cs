﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860691(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14,16)]
	[EntityType(EntityType.IsEnum)]
	public enum PjExceptionPosition
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjFirst = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjSecond = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjThird = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjFourth = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjLast = 4
	}
}