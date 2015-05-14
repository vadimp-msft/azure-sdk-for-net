// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights
{
    public static partial class EventOperationsExtensions
    {
        /// <summary>
        /// The List Digest Event Values operation lists the digest events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string
        /// </param>
        /// <param name='selectedProperties'>
        /// Optional. The list of property names to be returned. You can save
        /// bandwith by selecting only the properties you need.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static EventDataListResponse ListDigestEvents(this IEventOperations operations, string filterString, string selectedProperties)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListDigestEventsAsync(filterString, selectedProperties);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Digest Event Values operation lists the digest events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string
        /// </param>
        /// <param name='selectedProperties'>
        /// Optional. The list of property names to be returned. You can save
        /// bandwith by selecting only the properties you need.
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static Task<EventDataListResponse> ListDigestEventsAsync(this IEventOperations operations, string filterString, string selectedProperties)
        {
            return operations.ListDigestEventsAsync(filterString, selectedProperties, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Digest Event Next operation lists the next set of digest
        /// events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The next link
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static EventDataListResponse ListDigestEventsNext(this IEventOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListDigestEventsNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Digest Event Next operation lists the next set of digest
        /// events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The next link
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static Task<EventDataListResponse> ListDigestEventsNextAsync(this IEventOperations operations, string nextLink)
        {
            return operations.ListDigestEventsNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Event Values operation lists the events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string should be generated using
        /// Microsoft.WindowsAzure.Common.OData.FilterStringHere is an
        /// example:var filterString =
        /// FilterString.Generate<GetCountSummaryParameters> (p =>
        /// (p.StartTime == startTime) && p.EndTime == endTime);
        /// </param>
        /// <param name='selectedProperties'>
        /// Optional. The list of property names to be returned. You can save
        /// bandwidth by selecting only the properties you need.Here is an
        /// example:string selectedProperties = "EventDataId, EventTimestamp,
        /// ResourceUri"
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static EventDataListResponse ListEvents(this IEventOperations operations, string filterString, string selectedProperties)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListEventsAsync(filterString, selectedProperties);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Event Values operation lists the events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string should be generated using
        /// Microsoft.WindowsAzure.Common.OData.FilterStringHere is an
        /// example:var filterString =
        /// FilterString.Generate<GetCountSummaryParameters> (p =>
        /// (p.StartTime == startTime) && p.EndTime == endTime);
        /// </param>
        /// <param name='selectedProperties'>
        /// Optional. The list of property names to be returned. You can save
        /// bandwidth by selecting only the properties you need.Here is an
        /// example:string selectedProperties = "EventDataId, EventTimestamp,
        /// ResourceUri"
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static Task<EventDataListResponse> ListEventsAsync(this IEventOperations operations, string filterString, string selectedProperties)
        {
            return operations.ListEventsAsync(filterString, selectedProperties, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Event Next operation lists the next set of events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The next link works as a continuation token when all of
        /// the events are not returned in the response and a second call is
        /// required
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static EventDataListResponse ListEventsNext(this IEventOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListEventsNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Event Next operation lists the next set of events.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The next link works as a continuation token when all of
        /// the events are not returned in the response and a second call is
        /// required
        /// </param>
        /// <returns>
        /// The List Events operation response.
        /// </returns>
        public static Task<EventDataListResponse> ListEventsNextAsync(this IEventOperations operations, string nextLink)
        {
            return operations.ListEventsNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The status count of events in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string.
        /// </param>
        /// <returns>
        /// The List event status count summary operation response.
        /// </returns>
        public static EventStatusCountSummaryListResponse ListEventStatusCountSummaryItems(this IEventOperations operations, string filterString)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListEventStatusCountSummaryItemsAsync(filterString);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The status count of events in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IEventOperations.
        /// </param>
        /// <param name='filterString'>
        /// Required. The filter string.
        /// </param>
        /// <returns>
        /// The List event status count summary operation response.
        /// </returns>
        public static Task<EventStatusCountSummaryListResponse> ListEventStatusCountSummaryItemsAsync(this IEventOperations operations, string filterString)
        {
            return operations.ListEventStatusCountSummaryItemsAsync(filterString, CancellationToken.None);
        }
    }
}