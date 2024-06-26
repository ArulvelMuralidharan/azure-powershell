// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Admin approval request resource properties</summary>
    public partial class AdminRequestApprovalProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject into a new instance of <see cref="AdminRequestApprovalProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AdminRequestApprovalProperties(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_offerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("offerId"), out var __jsonOfferId) ? (string)__jsonOfferId : (string)_offerId;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_publisherId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("publisherId"), out var __jsonPublisherId) ? (string)__jsonPublisherId : (string)_publisherId;}
            {_adminAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("adminAction"), out var __jsonAdminAction) ? (string)__jsonAdminAction : (string)_adminAction;}
            {_approvedPlan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray>("approvedPlans"), out var __jsonApprovedPlans) ? If( __jsonApprovedPlans as Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _approvedPlan;}
            {_comment = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("comment"), out var __jsonComment) ? (string)__jsonComment : (string)_comment;}
            {_administrator = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("administrator"), out var __jsonAdministrator) ? (string)__jsonAdministrator : (string)_administrator;}
            {_plan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray>("plans"), out var __jsonPlans) ? If( __jsonPlans as Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanRequesterDetails>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanRequesterDetails) (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PlanRequesterDetails.FromJson(__p) )) ))() : null : _plan;}
            {_collectionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray>("collectionIds"), out var __jsonCollectionIds) ? If( __jsonCollectionIds as Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : _collectionId;}
            {_icon = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString>("icon"), out var __jsonIcon) ? (string)__jsonIcon : (string)_icon;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAdminRequestApprovalProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAdminRequestApprovalProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAdminRequestApprovalProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject json ? new AdminRequestApprovalProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AdminRequestApprovalProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AdminRequestApprovalProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._offerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._offerId.ToString()) : null, "offerId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            }
            AddIf( null != (((object)this._publisherId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._publisherId.ToString()) : null, "publisherId" ,container.Add );
            AddIf( null != (((object)this._adminAction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._adminAction.ToString()) : null, "adminAction" ,container.Add );
            if (null != this._approvedPlan)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.XNodeArray();
                foreach( var __x in this._approvedPlan )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("approvedPlans",__w);
            }
            AddIf( null != (((object)this._comment)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._comment.ToString()) : null, "comment" ,container.Add );
            AddIf( null != (((object)this._administrator)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._administrator.ToString()) : null, "administrator" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._plan)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.XNodeArray();
                    foreach( var __s in this._plan )
                    {
                        AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                    }
                    container.Add("plans",__r);
                }
            }
            if (null != this._collectionId)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.XNodeArray();
                foreach( var __n in this._collectionId )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("collectionIds",__m);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._icon)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonString(this._icon.ToString()) : null, "icon" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}