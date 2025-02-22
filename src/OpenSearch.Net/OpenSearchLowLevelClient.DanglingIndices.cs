/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net;
using static OpenSearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace OpenSearch.Net.Specification.DanglingIndicesApi
{
	///<summary>
	/// Dangling Indices APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchLowLevelClient.DanglingIndices"/> property
	/// on <see cref = "IOpenSearchLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelDanglingIndicesNamespace : NamespacedClientProxy
	{
		internal LowLevelDanglingIndicesNamespace(OpenSearchLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_dangling/{index_uuid} <para></para></summary>
		///<param name = "indexUuid">The UUID of the dangling index</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteDanglingIndex<TResponse>(string indexUuid, DeleteDanglingIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_dangling/{indexUuid:indexUuid}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_dangling/{index_uuid} <para></para></summary>
		///<param name = "indexUuid">The UUID of the dangling index</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("dangling_indices.delete_dangling_index", "index_uuid")]
		public Task<TResponse> DeleteDanglingIndexAsync<TResponse>(string indexUuid, DeleteDanglingIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_dangling/{indexUuid:indexUuid}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_dangling/{index_uuid} <para></para></summary>
		///<param name = "indexUuid">The UUID of the dangling index</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ImportDanglingIndex<TResponse>(string indexUuid, ImportDanglingIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"_dangling/{indexUuid:indexUuid}"), null, RequestParams(requestParameters));
		///<summary>POST on /_dangling/{index_uuid} <para></para></summary>
		///<param name = "indexUuid">The UUID of the dangling index</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("dangling_indices.import_dangling_index", "index_uuid")]
		public Task<TResponse> ImportDanglingIndexAsync<TResponse>(string indexUuid, ImportDanglingIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_dangling/{indexUuid:indexUuid}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_dangling <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse List<TResponse>(ListDanglingIndicesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_dangling", null, RequestParams(requestParameters));
		///<summary>GET on /_dangling <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("dangling_indices.list_dangling_indices", "")]
		public Task<TResponse> ListAsync<TResponse>(ListDanglingIndicesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_dangling", ctx, null, RequestParams(requestParameters));
	}
}
