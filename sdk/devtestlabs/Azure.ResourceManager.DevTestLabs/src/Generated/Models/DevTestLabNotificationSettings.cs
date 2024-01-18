// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Notification settings for a schedule. </summary>
    public partial class DevTestLabNotificationSettings
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabNotificationSettings"/>. </summary>
        public DevTestLabNotificationSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabNotificationSettings"/>. </summary>
        /// <param name="status"> If notifications are enabled for this schedule (i.e. Enabled, Disabled). </param>
        /// <param name="timeInMinutes"> Time in minutes before event at which notification will be sent. </param>
        /// <param name="webhookUri"> The webhook URL to which the notification will be sent. </param>
        /// <param name="emailRecipient"> The email recipient to send notifications to (can be a list of semi-colon separated email addresses). </param>
        /// <param name="notificationLocale"> The locale to use when sending a notification (fallback for unsupported languages is EN). </param>
        internal DevTestLabNotificationSettings(DevTestLabEnableStatus? status, int? timeInMinutes, Uri webhookUri, string emailRecipient, string notificationLocale)
        {
            Status = status;
            TimeInMinutes = timeInMinutes;
            WebhookUri = webhookUri;
            EmailRecipient = emailRecipient;
            NotificationLocale = notificationLocale;
        }

        /// <summary> If notifications are enabled for this schedule (i.e. Enabled, Disabled). </summary>
        public DevTestLabEnableStatus? Status { get; set; }
        /// <summary> Time in minutes before event at which notification will be sent. </summary>
        public int? TimeInMinutes { get; set; }
        /// <summary> The webhook URL to which the notification will be sent. </summary>
        public Uri WebhookUri { get; set; }
        /// <summary> The email recipient to send notifications to (can be a list of semi-colon separated email addresses). </summary>
        public string EmailRecipient { get; set; }
        /// <summary> The locale to use when sending a notification (fallback for unsupported languages is EN). </summary>
        public string NotificationLocale { get; set; }
    }
}
