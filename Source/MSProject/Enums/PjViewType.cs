﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 14, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff898414(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,14,16)]
	[EntityType(EntityType.IsEnum)]
	public enum PjViewType
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewUndefined = -1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewBarRollup = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewCalendar = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewDescriptiveNetworkDiagram = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewDetailGantt = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewGantt = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewGanttWithTimeline = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewLevelingGantt = 6,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewMilestoneDateRollup = 7,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewMilestoneRollup = 8,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewMultipleBaselinesGantt = 9,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewNetworkDiagram = 10,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewRelationshipDiagram = 11,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceAllocation = 12,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceForm = 13,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceGraph = 14,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceNameForm = 15,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceSchedulingView = 16,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceSheet = 17,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewResourceUsage = 18,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskForm = 19,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskDetailsForm = 20,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskEntry = 21,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskNameForm = 22,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskSheet = 23,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTaskUsage = 24,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>25</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTimeline = 25,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14, 16
		 /// </summary>
		 /// <remarks>26</remarks>
		 [SupportByVersion("MSProject", 11,14,16)]
		 pjViewTrackingGantt = 26,

		 /// <summary>
		 /// SupportByVersion MSProject 16
		 /// </summary>
		 /// <remarks>27</remarks>
		 [SupportByVersion("MSProject", 16)]
		 pjViewResourcePlan = 27
	}
}