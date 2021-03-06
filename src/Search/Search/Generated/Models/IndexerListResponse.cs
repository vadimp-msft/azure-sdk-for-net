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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Response from a List Indexers request. If successful, it includes the
    /// full definitions of all indexers.
    /// </summary>
    public partial class IndexerListResponse : AzureOperationResponse, IEnumerable<Indexer>
    {
        private IList<Indexer> _indexers;
        
        /// <summary>
        /// Optional. Gets the indexers in the Search service.
        /// </summary>
        public IList<Indexer> Indexers
        {
            get { return this._indexers; }
            set { this._indexers = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IndexerListResponse class.
        /// </summary>
        public IndexerListResponse()
        {
            this.Indexers = new LazyList<Indexer>();
        }
        
        /// <summary>
        /// Gets the sequence of Indexers.
        /// </summary>
        public IEnumerator<Indexer> GetEnumerator()
        {
            return this.Indexers.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Indexers.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
