﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867292(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14,16)]
	[EntityType(EntityType.IsEnum)]
	public enum PjVisualReportsCubeType
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjTaskTP = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjResourceTP = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjAssignmentTP = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjTaskNTP = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjResourceNTP = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjAssignmentNTP = 6
	}
}