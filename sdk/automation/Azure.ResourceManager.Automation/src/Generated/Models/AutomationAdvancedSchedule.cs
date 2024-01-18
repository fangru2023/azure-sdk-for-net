// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The properties of the create Advanced Schedule. </summary>
    public partial class AutomationAdvancedSchedule
    {
        /// <summary> Initializes a new instance of <see cref="AutomationAdvancedSchedule"/>. </summary>
        public AutomationAdvancedSchedule()
        {
            WeekDays = new ChangeTrackingList<string>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<AutomationAdvancedScheduleMonthlyOccurrence>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationAdvancedSchedule"/>. </summary>
        /// <param name="weekDays"> Days of the week that the job should execute on. </param>
        /// <param name="monthDays"> Days of the month that the job should execute on. Must be between 1 and 31. </param>
        /// <param name="monthlyOccurrences"> Occurrences of days within a month. </param>
        internal AutomationAdvancedSchedule(IList<string> weekDays, IList<int> monthDays, IList<AutomationAdvancedScheduleMonthlyOccurrence> monthlyOccurrences)
        {
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
        }

        /// <summary> Days of the week that the job should execute on. </summary>
        public IList<string> WeekDays { get; }
        /// <summary> Days of the month that the job should execute on. Must be between 1 and 31. </summary>
        public IList<int> MonthDays { get; }
        /// <summary> Occurrences of days within a month. </summary>
        public IList<AutomationAdvancedScheduleMonthlyOccurrence> MonthlyOccurrences { get; }
    }
}
