﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862309(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14,16)]
	[EntityType(EntityType.IsEnum)]
	public enum PjTimescaledData
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjWork = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCost = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCumulativeWork = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCumulativeCost = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualWork = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualOvertimeWork = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjOvertimeWork = 6,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaselineWork = 7,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjOverallocation = 8,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjFixedCost = 9,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualCost = 10,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaselineCost = 11,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjRegularWork = 12,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBCWS = 13,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBCWP = 14,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjACWP = 15,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjSV = 16,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCV = 17,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjPercentAllocation = 18,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjPeakUnits = 19,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjRemainingAvailability = 20,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjPctComplete = 21,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCumPctComplete = 22,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjAllTaskRows = 23,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjAllResourceRows = 23,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjAllAssignmentRows = 24,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>25</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjUnitAvailability = 25,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>26</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjWorkAvailability = 26,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>27</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline1Work = 27,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>28</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline1Cost = 28,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>29</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline2Work = 29,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>30</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline2Cost = 30,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>31</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline3Work = 31,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline3Cost = 32,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>33</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline4Work = 33,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>34</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline4Cost = 34,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>35</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline5Work = 35,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>36</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline5Cost = 36,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>37</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline6Work = 37,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>38</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline6Cost = 38,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>39</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline7Work = 39,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>40</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline7Cost = 40,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>41</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline8Work = 41,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>42</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline8Cost = 42,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>43</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline9Work = 43,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>44</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline9Cost = 44,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>45</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline10Work = 45,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>46</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline10Cost = 46,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>47</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualFixedCost = 47,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>48</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCPI = 48,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>49</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjSPI = 49,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>50</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjCVP = 50,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>51</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjSVP = 51,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>52</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualWorkProtected = 52,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>53</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjActualOvertimeWorkProtected = 53,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>54</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBudgetWork = 54,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>55</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBudgetCost = 55,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>56</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaselineBudgetWork = 56,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>57</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaselineBudgetCost = 57,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>58</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline1BudgetWork = 58,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>59</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline1BudgetCost = 59,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>60</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline2BudgetWork = 60,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>61</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline2BudgetCost = 61,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>62</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline3BudgetWork = 62,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>63</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline3BudgetCost = 63,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline4BudgetWork = 64,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>65</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline4BudgetCost = 65,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>66</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline5BudgetWork = 66,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>67</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline5BudgetCost = 67,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>68</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline6BudgetWork = 68,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>69</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline6BudgetCost = 69,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>70</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline7BudgetWork = 70,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>71</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline7BudgetCost = 71,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>72</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline8BudgetWork = 72,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>73</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline8BudgetCost = 73,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>74</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline9BudgetWork = 74,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>75</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline9BudgetCost = 75,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>76</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline10BudgetWork = 76,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14, 16
		 /// </summary>
		 /// <remarks>77</remarks>
		 [SupportByVersion("MSProject", 11,12,14,16)]
		 pjBaseline10BudgetCost = 77,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>78</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjCumulativeActualWork = 78,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>79</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjRemainingCumulativeActualWork = 79,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>80</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjRemainingCumulativeWork = 80,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>81</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjRemainingTasks = 81,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>82</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjRemainingActualTasks = 82,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>83</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaselineRemainingCumulativeWork = 83,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>84</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline1RemainingCumulativeWork = 84,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>85</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline2RemainingCumulativeWork = 85,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>86</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline3RemainingCumulativeWork = 86,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>87</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline4RemainingCumulativeWork = 87,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>88</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline5RemainingCumulativeWork = 88,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>89</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline6RemainingCumulativeWork = 89,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>90</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline7RemainingCumulativeWork = 90,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>91</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline8RemainingCumulativeWork = 91,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>92</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline9RemainingCumulativeWork = 92,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>93</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline10RemainingCumulativeWork = 93,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>94</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaselineRemainingTasks = 94,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>95</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline1RemainingTasks = 95,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>96</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline2RemainingTasks = 96,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>97</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline3RemainingTasks = 97,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>98</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline4RemainingTasks = 98,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>99</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline5RemainingTasks = 99,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>100</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline6RemainingTasks = 100,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>101</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline7RemainingTasks = 101,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>102</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline8RemainingTasks = 102,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>103</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline9RemainingTasks = 103,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>104</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline10RemainingTasks = 104,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>105</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaselineCumulativeWork = 105,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>106</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline1CumulativeWork = 106,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>107</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline2CumulativeWork = 107,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>108</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline3CumulativeWork = 108,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>109</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline4CumulativeWork = 109,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>110</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline5CumulativeWork = 110,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>111</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline6CumulativeWork = 111,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>112</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline7CumulativeWork = 112,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>113</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline8CumulativeWork = 113,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>114</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline9CumulativeWork = 114,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 16
		 /// </summary>
		 /// <remarks>115</remarks>
		 [SupportByVersion("MSProject", 11,16)]
		 pjBaseline10CumulativeWork = 115,

		 /// <summary>
		 /// SupportByVersion MSProject 16
		 /// </summary>
		 /// <remarks>116</remarks>
		 [SupportByVersion("MSProject", 16)]
		 pjProposedWork = 116,

		 /// <summary>
		 /// SupportByVersion MSProject 16
		 /// </summary>
		 /// <remarks>117</remarks>
		 [SupportByVersion("MSProject", 16)]
		 pjCommittedWork = 117,

		 /// <summary>
		 /// SupportByVersion MSProject 16
		 /// </summary>
		 /// <remarks>118</remarks>
		 [SupportByVersion("MSProject", 16)]
		 pjProposedMaxUnits = 118,

		 /// <summary>
		 /// SupportByVersion MSProject 16
		 /// </summary>
		 /// <remarks>119</remarks>
		 [SupportByVersion("MSProject", 16)]
		 pjCommittedMaxUnits = 119
	}
}