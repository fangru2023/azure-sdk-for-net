// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The repeating times at which this profile begins. This element is not used if the FixedDate element is used. </summary>
    public partial class MonitorRecurrence
    {
        /// <summary> Initializes a new instance of <see cref="MonitorRecurrence"/>. </summary>
        /// <param name="frequency"> the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning each week will have the same set of profiles. For example, to set a daily schedule, set **schedule** to every day of the week. The frequency property specifies that the schedule is repeated weekly. </param>
        /// <param name="schedule"> the scheduling constraints for when the profile begins. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> is null. </exception>
        public MonitorRecurrence(RecurrenceFrequency frequency, RecurrentSchedule schedule)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));

            Frequency = frequency;
            Schedule = schedule;
        }

        /// <summary> the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning each week will have the same set of profiles. For example, to set a daily schedule, set **schedule** to every day of the week. The frequency property specifies that the schedule is repeated weekly. </summary>
        public RecurrenceFrequency Frequency { get; set; }
        /// <summary> the scheduling constraints for when the profile begins. </summary>
        public RecurrentSchedule Schedule { get; set; }
    }
}
