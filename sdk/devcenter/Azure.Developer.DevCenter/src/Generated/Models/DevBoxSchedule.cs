// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> A Schedule to execute action. </summary>
    public partial class DevBoxSchedule
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxSchedule"/>. </summary>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZone"/> is null. </exception>
        internal DevBoxSchedule(ScheduledType scheduledType, ScheduleFrequency frequency, TimeSpan time, string timeZone)
        {
            Argument.AssertNotNull(timeZone, nameof(timeZone));

            ScheduledType = scheduledType;
            Frequency = frequency;
            Time = time;
            TimeZone = timeZone;
        }

        /// <summary> Initializes a new instance of <see cref="DevBoxSchedule"/>. </summary>
        /// <param name="name"> Display name for the Schedule. </param>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        internal DevBoxSchedule(string name, ScheduledType scheduledType, ScheduleFrequency frequency, TimeSpan time, string timeZone)
        {
            Name = name;
            ScheduledType = scheduledType;
            Frequency = frequency;
            Time = time;
            TimeZone = timeZone;
        }

        /// <summary> Display name for the Schedule. </summary>
        public string Name { get; }
        /// <summary> Supported type this scheduled task represents. </summary>
        public ScheduledType ScheduledType { get; }
        /// <summary> The frequency of this scheduled task. </summary>
        public ScheduleFrequency Frequency { get; }
        /// <summary> The target time to trigger the action. The format is HH:MM. </summary>
        public TimeSpan Time { get; }
        /// <summary> The IANA timezone id at which the schedule should execute. </summary>
        public string TimeZone { get; }
    }
}
