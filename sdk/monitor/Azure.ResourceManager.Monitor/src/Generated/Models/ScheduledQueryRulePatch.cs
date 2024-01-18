// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The scheduled query rule resource for patch operations. </summary>
    public partial class ScheduledQueryRulePatch
    {
        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRulePatch"/>. </summary>
        public ScheduledQueryRulePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Scopes = new ChangeTrackingList<string>();
            TargetResourceTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRulePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="createdWithApiVersion"> The api-version used when creating this alert rule. </param>
        /// <param name="isLegacyLogAnalyticsRule"> True if alert rule is legacy Log Analytic rule. </param>
        /// <param name="description"> The description of the scheduled query rule. </param>
        /// <param name="displayName"> The display name of the alert rule. </param>
        /// <param name="severity"> Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest. Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="isEnabled"> The flag which indicates whether this scheduled query rule is enabled. Value should be true or false. </param>
        /// <param name="scopes"> The list of resource id's that this scheduled query rule is scoped to. </param>
        /// <param name="evaluationFrequency"> How often the scheduled query rule is evaluated represented in ISO 8601 duration format. Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="windowSize"> The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size). Relevant and required only for rules of the kind LogAlert. </param>
        /// <param name="overrideQueryTimeRange"> If specified then overrides the query time range (default is WindowSize*NumberOfEvaluationPeriods). Relevant only for rules of the kind LogAlert. </param>
        /// <param name="targetResourceTypes"> List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="criteria"> The rule criteria that defines the conditions of the scheduled query rule. </param>
        /// <param name="muteActionsDuration"> Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="actions"> Actions to invoke when the alert fires. </param>
        /// <param name="isWorkspaceAlertsStorageConfigured"> The flag which indicates whether this scheduled query rule has been configured to be stored in the customer's storage. The default is false. </param>
        /// <param name="checkWorkspaceAlertsStorageConfigured"> The flag which indicates whether this scheduled query rule should be stored in the customer's storage. The default is false. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="skipQueryValidation"> The flag which indicates whether the provided query should be validated or not. The default is false. Relevant only for rules of the kind LogAlert. </param>
        /// <param name="autoMitigate"> The flag that indicates whether the alert should be automatically resolved or not. The default is true. Relevant only for rules of the kind LogAlert. </param>
        internal ScheduledQueryRulePatch(IDictionary<string, string> tags, string createdWithApiVersion, bool? isLegacyLogAnalyticsRule, string description, string displayName, AlertSeverity? severity, bool? isEnabled, IList<string> scopes, TimeSpan? evaluationFrequency, TimeSpan? windowSize, TimeSpan? overrideQueryTimeRange, IList<string> targetResourceTypes, ScheduledQueryRuleCriteria criteria, TimeSpan? muteActionsDuration, ScheduledQueryRuleActions actions, bool? isWorkspaceAlertsStorageConfigured, bool? checkWorkspaceAlertsStorageConfigured, bool? skipQueryValidation, bool? autoMitigate)
        {
            Tags = tags;
            CreatedWithApiVersion = createdWithApiVersion;
            IsLegacyLogAnalyticsRule = isLegacyLogAnalyticsRule;
            Description = description;
            DisplayName = displayName;
            Severity = severity;
            IsEnabled = isEnabled;
            Scopes = scopes;
            EvaluationFrequency = evaluationFrequency;
            WindowSize = windowSize;
            OverrideQueryTimeRange = overrideQueryTimeRange;
            TargetResourceTypes = targetResourceTypes;
            Criteria = criteria;
            MuteActionsDuration = muteActionsDuration;
            Actions = actions;
            IsWorkspaceAlertsStorageConfigured = isWorkspaceAlertsStorageConfigured;
            CheckWorkspaceAlertsStorageConfigured = checkWorkspaceAlertsStorageConfigured;
            SkipQueryValidation = skipQueryValidation;
            AutoMitigate = autoMitigate;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The api-version used when creating this alert rule. </summary>
        public string CreatedWithApiVersion { get; }
        /// <summary> True if alert rule is legacy Log Analytic rule. </summary>
        public bool? IsLegacyLogAnalyticsRule { get; }
        /// <summary> The description of the scheduled query rule. </summary>
        public string Description { get; set; }
        /// <summary> The display name of the alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest. Relevant and required only for rules of the kind LogAlert. </summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary> The flag which indicates whether this scheduled query rule is enabled. Value should be true or false. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The list of resource id's that this scheduled query rule is scoped to. </summary>
        public IList<string> Scopes { get; }
        /// <summary> How often the scheduled query rule is evaluated represented in ISO 8601 duration format. Relevant and required only for rules of the kind LogAlert. </summary>
        public TimeSpan? EvaluationFrequency { get; set; }
        /// <summary> The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size). Relevant and required only for rules of the kind LogAlert. </summary>
        public TimeSpan? WindowSize { get; set; }
        /// <summary> If specified then overrides the query time range (default is WindowSize*NumberOfEvaluationPeriods). Relevant only for rules of the kind LogAlert. </summary>
        public TimeSpan? OverrideQueryTimeRange { get; set; }
        /// <summary> List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria. Relevant only for rules of the kind LogAlert. </summary>
        public IList<string> TargetResourceTypes { get; }
        /// <summary> The rule criteria that defines the conditions of the scheduled query rule. </summary>
        internal ScheduledQueryRuleCriteria Criteria { get; set; }
        /// <summary> A list of conditions to evaluate against the specified scopes. </summary>
        public IList<ScheduledQueryRuleCondition> CriteriaAllOf
        {
            get
            {
                if (Criteria is null)
                    Criteria = new ScheduledQueryRuleCriteria();
                return Criteria.AllOf;
            }
        }

        /// <summary> Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired. Relevant only for rules of the kind LogAlert. </summary>
        public TimeSpan? MuteActionsDuration { get; set; }
        /// <summary> Actions to invoke when the alert fires. </summary>
        public ScheduledQueryRuleActions Actions { get; set; }
        /// <summary> The flag which indicates whether this scheduled query rule has been configured to be stored in the customer's storage. The default is false. </summary>
        public bool? IsWorkspaceAlertsStorageConfigured { get; }
        /// <summary> The flag which indicates whether this scheduled query rule should be stored in the customer's storage. The default is false. Relevant only for rules of the kind LogAlert. </summary>
        public bool? CheckWorkspaceAlertsStorageConfigured { get; set; }
        /// <summary> The flag which indicates whether the provided query should be validated or not. The default is false. Relevant only for rules of the kind LogAlert. </summary>
        public bool? SkipQueryValidation { get; set; }
        /// <summary> The flag that indicates whether the alert should be automatically resolved or not. The default is true. Relevant only for rules of the kind LogAlert. </summary>
        public bool? AutoMitigate { get; set; }
    }
}
