// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Properties of the Queue info for event subscription.</summary>
    public partial class QueueInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfo,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfoInternal
    {

        /// <summary>Type of the endpoint for the dead letter destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string DeadLetterDestinationEndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestinationEndpointType; }

        /// <summary>
        /// Backing field for <see cref="DeadLetterDestinationWithResourceIdentity" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentity _deadLetterDestinationWithResourceIdentity;

        /// <summary>
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent
        /// to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (namely, topic) to acquire the authentication tokens being used
        /// during delivery / dead-lettering.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentity DeadLetterDestinationWithResourceIdentity { get => (this._deadLetterDestinationWithResourceIdentity = this._deadLetterDestinationWithResourceIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.DeadLetterWithResourceIdentity()); set => this._deadLetterDestinationWithResourceIdentity = value; }

        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
        /// being used during delivery / dead-lettering.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestination DeadLetterDestinationWithResourceIdentityDeadLetterDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestination; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestination = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="EventTimeToLive" /> property.</summary>
        private global::System.TimeSpan? _eventTimeToLive;

        /// <summary>
        /// Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time
        /// the message was published.
        /// This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
        /// - (n) is replaced by the value of each time element that follows the (n).
        /// - P is the duration (or Period) designator and is always placed at the beginning of the duration.
        /// - Y is the year designator, and it follows the value for the number of years.
        /// - M is the month designator, and it follows the value for the number of months.
        /// - W is the week designator, and it follows the value for the number of weeks.
        /// - D is the day designator, and it follows the value for the number of days.
        /// - T is the time designator, and it precedes the time components.
        /// - H is the hour designator, and it follows the value for the number of hours.
        /// - M is the minute designator, and it follows the value for the number of minutes.
        /// - S is the second designator, and it follows the value for the number of seconds.
        /// This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its
        /// minimum value is 1 minute, and its maximum is determined
        /// by topic’s EventRetentionInDays value. The followings are examples of valid values:
        /// - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
        /// - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public global::System.TimeSpan? EventTimeToLive { get => this._eventTimeToLive; set => this._eventTimeToLive = value; }

        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).IdentityType = value ?? null; }

        /// <summary>The user identity associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).IdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).IdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Backing field for <see cref="MaxDeliveryCount" /> property.</summary>
        private int? _maxDeliveryCount;

        /// <summary>The maximum delivery count of the events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public int? MaxDeliveryCount { get => this._maxDeliveryCount; set => this._maxDeliveryCount = value; }

        /// <summary>Internal Acessors for DeadLetterDestinationEndpointType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfoInternal.DeadLetterDestinationEndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestinationEndpointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestinationEndpointType = value; }

        /// <summary>Internal Acessors for DeadLetterDestinationWithResourceIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfoInternal.DeadLetterDestinationWithResourceIdentity { get => (this._deadLetterDestinationWithResourceIdentity = this._deadLetterDestinationWithResourceIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.DeadLetterWithResourceIdentity()); set { {_deadLetterDestinationWithResourceIdentity = value;} } }

        /// <summary>
        /// Internal Acessors for DeadLetterDestinationWithResourceIdentityDeadLetterDestination
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestination Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfoInternal.DeadLetterDestinationWithResourceIdentityDeadLetterDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestination; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).DeadLetterDestination = value; }

        /// <summary>Internal Acessors for DeadLetterDestinationWithResourceIdentityIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionIdentity Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IQueueInfoInternal.DeadLetterDestinationWithResourceIdentityIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentityInternal)DeadLetterDestinationWithResourceIdentity).Identity = value; }

        /// <summary>Backing field for <see cref="ReceiveLockDurationInSecond" /> property.</summary>
        private int? _receiveLockDurationInSecond;

        /// <summary>
        /// Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released
        /// or rejected.
        /// If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed),
        /// released or rejected,
        /// the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds
        /// and maximum is 300 seconds.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public int? ReceiveLockDurationInSecond { get => this._receiveLockDurationInSecond; set => this._receiveLockDurationInSecond = value; }

        /// <summary>Creates an new <see cref="QueueInfo" /> instance.</summary>
        public QueueInfo()
        {

        }
    }
    /// Properties of the Queue info for event subscription.
    public partial interface IQueueInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Type of the endpoint for the dead letter destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the endpoint for the dead letter destination",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(string) })]
        string DeadLetterDestinationEndpointType { get;  }
        /// <summary>
        /// Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time
        /// the message was published.
        /// This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
        /// - (n) is replaced by the value of each time element that follows the (n).
        /// - P is the duration (or Period) designator and is always placed at the beginning of the duration.
        /// - Y is the year designator, and it follows the value for the number of years.
        /// - M is the month designator, and it follows the value for the number of months.
        /// - W is the week designator, and it follows the value for the number of weeks.
        /// - D is the day designator, and it follows the value for the number of days.
        /// - T is the time designator, and it precedes the time components.
        /// - H is the hour designator, and it follows the value for the number of hours.
        /// - M is the minute designator, and it follows the value for the number of minutes.
        /// - S is the second designator, and it follows the value for the number of seconds.
        /// This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its
        /// minimum value is 1 minute, and its maximum is determined
        /// by topic’s EventRetentionInDays value. The followings are examples of valid values:
        /// - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
        /// - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time the message was published.
        This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
            - (n) is replaced by the value of each time element that follows the (n).
            - P is the duration (or Period) designator and is always placed at the beginning of the duration.
            - Y is the year designator, and it follows the value for the number of years.
            - M is the month designator, and it follows the value for the number of months.
            - W is the week designator, and it follows the value for the number of weeks.
            - D is the day designator, and it follows the value for the number of days.
            - T is the time designator, and it precedes the time components.
            - H is the hour designator, and it follows the value for the number of hours.
            - M is the minute designator, and it follows the value for the number of minutes.
            - S is the second designator, and it follows the value for the number of seconds.
        This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its minimum value is 1 minute, and its maximum is determined
        by topic’s EventRetentionInDays value. The followings are examples of valid values:
            - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
            - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.",
        SerializedName = @"eventTimeToLive",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? EventTimeToLive { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The user identity associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The user identity associated with the resource.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityUserAssignedIdentity { get; set; }
        /// <summary>The maximum delivery count of the events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum delivery count of the events.",
        SerializedName = @"maxDeliveryCount",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxDeliveryCount { get; set; }
        /// <summary>
        /// Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released
        /// or rejected.
        /// If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed),
        /// released or rejected,
        /// the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds
        /// and maximum is 300 seconds.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released or rejected.
        If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed), released or rejected,
        the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds and maximum is 300 seconds.",
        SerializedName = @"receiveLockDurationInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ReceiveLockDurationInSecond { get; set; }

    }
    /// Properties of the Queue info for event subscription.
    internal partial interface IQueueInfoInternal

    {
        /// <summary>Type of the endpoint for the dead letter destination</summary>
        string DeadLetterDestinationEndpointType { get; set; }
        /// <summary>
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent
        /// to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (namely, topic) to acquire the authentication tokens being used
        /// during delivery / dead-lettering.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterWithResourceIdentity DeadLetterDestinationWithResourceIdentity { get; set; }
        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
        /// being used during delivery / dead-lettering.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestination DeadLetterDestinationWithResourceIdentityDeadLetterDestination { get; set; }
        /// <summary>The identity to use when dead-lettering events.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionIdentity DeadLetterDestinationWithResourceIdentityIdentity { get; set; }
        /// <summary>
        /// Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time
        /// the message was published.
        /// This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
        /// - (n) is replaced by the value of each time element that follows the (n).
        /// - P is the duration (or Period) designator and is always placed at the beginning of the duration.
        /// - Y is the year designator, and it follows the value for the number of years.
        /// - M is the month designator, and it follows the value for the number of months.
        /// - W is the week designator, and it follows the value for the number of weeks.
        /// - D is the day designator, and it follows the value for the number of days.
        /// - T is the time designator, and it precedes the time components.
        /// - H is the hour designator, and it follows the value for the number of hours.
        /// - M is the minute designator, and it follows the value for the number of minutes.
        /// - S is the second designator, and it follows the value for the number of seconds.
        /// This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its
        /// minimum value is 1 minute, and its maximum is determined
        /// by topic’s EventRetentionInDays value. The followings are examples of valid values:
        /// - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
        /// - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.
        /// </summary>
        global::System.TimeSpan? EventTimeToLive { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identity.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The user identity associated with the resource.</summary>
        string IdentityUserAssignedIdentity { get; set; }
        /// <summary>The maximum delivery count of the events.</summary>
        int? MaxDeliveryCount { get; set; }
        /// <summary>
        /// Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released
        /// or rejected.
        /// If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed),
        /// released or rejected,
        /// the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds
        /// and maximum is 300 seconds.
        /// </summary>
        int? ReceiveLockDurationInSecond { get; set; }

    }
}