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
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net.Specification.CatApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace OpenSearch.Client.Specification.CatApi
{
	///<summary>
	/// Cat APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchClient.Cat"/> property
	/// on <see cref = "IOpenSearchClient"/>.
	///</para>
	///</summary>
	public class CatNamespace : NamespacedClientProxy
	{
		internal CatNamespace(OpenSearchClient client): base(client)
		{
		}

		/// <summary>
		/// <c>GET</c> request to the <c>cat.aliases</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</a>
		/// </summary>
		public CatResponse<CatAliasesRecord> Aliases(Func<CatAliasesDescriptor, ICatAliasesRequest> selector = null) => Aliases(selector.InvokeOrDefault(new CatAliasesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.aliases</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</a>
		/// </summary>
		public Task<CatResponse<CatAliasesRecord>> AliasesAsync(Func<CatAliasesDescriptor, ICatAliasesRequest> selector = null, CancellationToken ct = default) => AliasesAsync(selector.InvokeOrDefault(new CatAliasesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.aliases</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</a>
		/// </summary>
		public CatResponse<CatAliasesRecord> Aliases(ICatAliasesRequest request) => DoCat<ICatAliasesRequest, CatAliasesRequestParameters, CatAliasesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.aliases</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</a>
		/// </summary>
		public Task<CatResponse<CatAliasesRecord>> AliasesAsync(ICatAliasesRequest request, CancellationToken ct = default) => DoCatAsync<ICatAliasesRequest, CatAliasesRequestParameters, CatAliasesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.allocation</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</a>
		/// </summary>
		public CatResponse<CatAllocationRecord> Allocation(Func<CatAllocationDescriptor, ICatAllocationRequest> selector = null) => Allocation(selector.InvokeOrDefault(new CatAllocationDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.allocation</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</a>
		/// </summary>
		public Task<CatResponse<CatAllocationRecord>> AllocationAsync(Func<CatAllocationDescriptor, ICatAllocationRequest> selector = null, CancellationToken ct = default) => AllocationAsync(selector.InvokeOrDefault(new CatAllocationDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.allocation</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</a>
		/// </summary>
		public CatResponse<CatAllocationRecord> Allocation(ICatAllocationRequest request) => DoCat<ICatAllocationRequest, CatAllocationRequestParameters, CatAllocationRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.allocation</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</a>
		/// </summary>
		public Task<CatResponse<CatAllocationRecord>> AllocationAsync(ICatAllocationRequest request, CancellationToken ct = default) => DoCatAsync<ICatAllocationRequest, CatAllocationRequestParameters, CatAllocationRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</a>
		/// </summary>
		public CatResponse<CatCountRecord> Count(Func<CatCountDescriptor, ICatCountRequest> selector = null) => Count(selector.InvokeOrDefault(new CatCountDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</a>
		/// </summary>
		public Task<CatResponse<CatCountRecord>> CountAsync(Func<CatCountDescriptor, ICatCountRequest> selector = null, CancellationToken ct = default) => CountAsync(selector.InvokeOrDefault(new CatCountDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</a>
		/// </summary>
		public CatResponse<CatCountRecord> Count(ICatCountRequest request) => DoCat<ICatCountRequest, CatCountRequestParameters, CatCountRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.count</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</a>
		/// </summary>
		public Task<CatResponse<CatCountRecord>> CountAsync(ICatCountRequest request, CancellationToken ct = default) => DoCatAsync<ICatCountRequest, CatCountRequestParameters, CatCountRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.fielddata</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</a>
		/// </summary>
		public CatResponse<CatFielddataRecord> Fielddata(Func<CatFielddataDescriptor, ICatFielddataRequest> selector = null) => Fielddata(selector.InvokeOrDefault(new CatFielddataDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.fielddata</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</a>
		/// </summary>
		public Task<CatResponse<CatFielddataRecord>> FielddataAsync(Func<CatFielddataDescriptor, ICatFielddataRequest> selector = null, CancellationToken ct = default) => FielddataAsync(selector.InvokeOrDefault(new CatFielddataDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.fielddata</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</a>
		/// </summary>
		public CatResponse<CatFielddataRecord> Fielddata(ICatFielddataRequest request) => DoCat<ICatFielddataRequest, CatFielddataRequestParameters, CatFielddataRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.fielddata</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</a>
		/// </summary>
		public Task<CatResponse<CatFielddataRecord>> FielddataAsync(ICatFielddataRequest request, CancellationToken ct = default) => DoCatAsync<ICatFielddataRequest, CatFielddataRequestParameters, CatFielddataRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.health</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</a>
		/// </summary>
		public CatResponse<CatHealthRecord> Health(Func<CatHealthDescriptor, ICatHealthRequest> selector = null) => Health(selector.InvokeOrDefault(new CatHealthDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.health</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</a>
		/// </summary>
		public Task<CatResponse<CatHealthRecord>> HealthAsync(Func<CatHealthDescriptor, ICatHealthRequest> selector = null, CancellationToken ct = default) => HealthAsync(selector.InvokeOrDefault(new CatHealthDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.health</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</a>
		/// </summary>
		public CatResponse<CatHealthRecord> Health(ICatHealthRequest request) => DoCat<ICatHealthRequest, CatHealthRequestParameters, CatHealthRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.health</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</a>
		/// </summary>
		public Task<CatResponse<CatHealthRecord>> HealthAsync(ICatHealthRequest request, CancellationToken ct = default) => DoCatAsync<ICatHealthRequest, CatHealthRequestParameters, CatHealthRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.help</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</a>
		/// </summary>
		public CatResponse<CatHelpRecord> Help(Func<CatHelpDescriptor, ICatHelpRequest> selector = null) => Help(selector.InvokeOrDefault(new CatHelpDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.help</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</a>
		/// </summary>
		public Task<CatResponse<CatHelpRecord>> HelpAsync(Func<CatHelpDescriptor, ICatHelpRequest> selector = null, CancellationToken ct = default) => HelpAsync(selector.InvokeOrDefault(new CatHelpDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.help</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</a>
		/// </summary>
		public CatResponse<CatHelpRecord> Help(ICatHelpRequest request) => DoCat<ICatHelpRequest, CatHelpRequestParameters, CatHelpRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.help</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</a>
		/// </summary>
		public Task<CatResponse<CatHelpRecord>> HelpAsync(ICatHelpRequest request, CancellationToken ct = default) => DoCatAsync<ICatHelpRequest, CatHelpRequestParameters, CatHelpRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.indices</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</a>
		/// </summary>
		public CatResponse<CatIndicesRecord> Indices(Func<CatIndicesDescriptor, ICatIndicesRequest> selector = null) => Indices(selector.InvokeOrDefault(new CatIndicesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.indices</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</a>
		/// </summary>
		public Task<CatResponse<CatIndicesRecord>> IndicesAsync(Func<CatIndicesDescriptor, ICatIndicesRequest> selector = null, CancellationToken ct = default) => IndicesAsync(selector.InvokeOrDefault(new CatIndicesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.indices</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</a>
		/// </summary>
		public CatResponse<CatIndicesRecord> Indices(ICatIndicesRequest request) => DoCat<ICatIndicesRequest, CatIndicesRequestParameters, CatIndicesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.indices</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</a>
		/// </summary>
		public Task<CatResponse<CatIndicesRecord>> IndicesAsync(ICatIndicesRequest request, CancellationToken ct = default) => DoCatAsync<ICatIndicesRequest, CatIndicesRequestParameters, CatIndicesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.master</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/">https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</a>
		/// <remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManager(Func&lt;CatClusterManagerDescriptor, ICatClusterManagerRequest&gt;)"/> instead</remarks>
		/// </summary>
		public CatResponse<CatMasterRecord> Master(Func<CatMasterDescriptor, ICatMasterRequest> selector = null) => Master(selector.InvokeOrDefault(new CatMasterDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.master</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/">https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</a>
		/// <remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerAsync(Func&lt;CatClusterManagerDescriptor, ICatClusterManagerRequest&gt;, CancellationToken)"/> instead</remarks>
		/// </summary>
		public Task<CatResponse<CatMasterRecord>> MasterAsync(Func<CatMasterDescriptor, ICatMasterRequest> selector = null, CancellationToken ct = default) => MasterAsync(selector.InvokeOrDefault(new CatMasterDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.master</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/">https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</a>
		/// <remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManager(ICatClusterManagerRequest)"/> instead</remarks>
		/// </summary>
		public CatResponse<CatMasterRecord> Master(ICatMasterRequest request) => DoCat<ICatMasterRequest, CatMasterRequestParameters, CatMasterRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.master</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/">https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</a>
		/// <remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerAsync(ICatClusterManagerRequest, CancellationToken)"/> instead</remarks>
		/// </summary>
		public Task<CatResponse<CatMasterRecord>> MasterAsync(ICatMasterRequest request, CancellationToken ct = default) => DoCatAsync<ICatMasterRequest, CatMasterRequestParameters, CatMasterRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.cluster_manager</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/">https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</a>
		/// <remarks>Introduced in OpenSearch 2.0 instead of <see cref="Master(Func&lt;CatMasterDescriptor, ICatMasterRequest&gt;)"/></remarks>
		/// </summary>
		public CatResponse<CatClusterManagerRecord> ClusterManager(Func<CatClusterManagerDescriptor, ICatClusterManagerRequest> selector = null) => ClusterManager(selector.InvokeOrDefault(new CatClusterManagerDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.cluster_manager</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/">https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</a>
		/// <remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterAsync(Func&lt;CatMasterDescriptor, ICatMasterRequest&gt;, CancellationToken)"/></remarks>
		/// </summary>
		public Task<CatResponse<CatClusterManagerRecord>> ClusterManagerAsync(Func<CatClusterManagerDescriptor, ICatClusterManagerRequest> selector = null, CancellationToken ct = default) => ClusterManagerAsync(selector.InvokeOrDefault(new CatClusterManagerDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.cluster_manager</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/">https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</a>
		/// <remarks>Introduced in OpenSearch 2.0 instead of <see cref="Master(ICatMasterRequest)"/></remarks>
		/// </summary>
		public CatResponse<CatClusterManagerRecord> ClusterManager(ICatClusterManagerRequest request) => DoCat<ICatClusterManagerRequest, CatClusterManagerRequestParameters, CatClusterManagerRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.cluster_manager</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/">https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</a>
		/// <remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterAsync(ICatMasterRequest, CancellationToken)"/></remarks>
		/// </summary>
		public Task<CatResponse<CatClusterManagerRecord>> ClusterManagerAsync(ICatClusterManagerRequest request, CancellationToken ct = default) => DoCatAsync<ICatClusterManagerRequest, CatClusterManagerRequestParameters, CatClusterManagerRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodeattrs</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</a>
		/// </summary>
		public CatResponse<CatNodeAttributesRecord> NodeAttributes(Func<CatNodeAttributesDescriptor, ICatNodeAttributesRequest> selector = null) => NodeAttributes(selector.InvokeOrDefault(new CatNodeAttributesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodeattrs</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</a>
		/// </summary>
		public Task<CatResponse<CatNodeAttributesRecord>> NodeAttributesAsync(Func<CatNodeAttributesDescriptor, ICatNodeAttributesRequest> selector = null, CancellationToken ct = default) => NodeAttributesAsync(selector.InvokeOrDefault(new CatNodeAttributesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodeattrs</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</a>
		/// </summary>
		public CatResponse<CatNodeAttributesRecord> NodeAttributes(ICatNodeAttributesRequest request) => DoCat<ICatNodeAttributesRequest, CatNodeAttributesRequestParameters, CatNodeAttributesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodeattrs</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</a>
		/// </summary>
		public Task<CatResponse<CatNodeAttributesRecord>> NodeAttributesAsync(ICatNodeAttributesRequest request, CancellationToken ct = default) => DoCatAsync<ICatNodeAttributesRequest, CatNodeAttributesRequestParameters, CatNodeAttributesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodes</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</a>
		/// </summary>
		public CatResponse<CatNodesRecord> Nodes(Func<CatNodesDescriptor, ICatNodesRequest> selector = null) => Nodes(selector.InvokeOrDefault(new CatNodesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodes</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</a>
		/// </summary>
		public Task<CatResponse<CatNodesRecord>> NodesAsync(Func<CatNodesDescriptor, ICatNodesRequest> selector = null, CancellationToken ct = default) => NodesAsync(selector.InvokeOrDefault(new CatNodesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodes</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</a>
		/// </summary>
		public CatResponse<CatNodesRecord> Nodes(ICatNodesRequest request) => DoCat<ICatNodesRequest, CatNodesRequestParameters, CatNodesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.nodes</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</a>
		/// </summary>
		public Task<CatResponse<CatNodesRecord>> NodesAsync(ICatNodesRequest request, CancellationToken ct = default) => DoCatAsync<ICatNodesRequest, CatNodesRequestParameters, CatNodesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.pending_tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</a>
		/// </summary>
		public CatResponse<CatPendingTasksRecord> PendingTasks(Func<CatPendingTasksDescriptor, ICatPendingTasksRequest> selector = null) => PendingTasks(selector.InvokeOrDefault(new CatPendingTasksDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.pending_tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</a>
		/// </summary>
		public Task<CatResponse<CatPendingTasksRecord>> PendingTasksAsync(Func<CatPendingTasksDescriptor, ICatPendingTasksRequest> selector = null, CancellationToken ct = default) => PendingTasksAsync(selector.InvokeOrDefault(new CatPendingTasksDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.pending_tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</a>
		/// </summary>
		public CatResponse<CatPendingTasksRecord> PendingTasks(ICatPendingTasksRequest request) => DoCat<ICatPendingTasksRequest, CatPendingTasksRequestParameters, CatPendingTasksRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.pending_tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</a>
		/// </summary>
		public Task<CatResponse<CatPendingTasksRecord>> PendingTasksAsync(ICatPendingTasksRequest request, CancellationToken ct = default) => DoCatAsync<ICatPendingTasksRequest, CatPendingTasksRequestParameters, CatPendingTasksRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.plugins</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</a>
		/// </summary>
		public CatResponse<CatPluginsRecord> Plugins(Func<CatPluginsDescriptor, ICatPluginsRequest> selector = null) => Plugins(selector.InvokeOrDefault(new CatPluginsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.plugins</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</a>
		/// </summary>
		public Task<CatResponse<CatPluginsRecord>> PluginsAsync(Func<CatPluginsDescriptor, ICatPluginsRequest> selector = null, CancellationToken ct = default) => PluginsAsync(selector.InvokeOrDefault(new CatPluginsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.plugins</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</a>
		/// </summary>
		public CatResponse<CatPluginsRecord> Plugins(ICatPluginsRequest request) => DoCat<ICatPluginsRequest, CatPluginsRequestParameters, CatPluginsRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.plugins</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</a>
		/// </summary>
		public Task<CatResponse<CatPluginsRecord>> PluginsAsync(ICatPluginsRequest request, CancellationToken ct = default) => DoCatAsync<ICatPluginsRequest, CatPluginsRequestParameters, CatPluginsRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.recovery</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</a>
		/// </summary>
		public CatResponse<CatRecoveryRecord> Recovery(Func<CatRecoveryDescriptor, ICatRecoveryRequest> selector = null) => Recovery(selector.InvokeOrDefault(new CatRecoveryDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.recovery</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</a>
		/// </summary>
		public Task<CatResponse<CatRecoveryRecord>> RecoveryAsync(Func<CatRecoveryDescriptor, ICatRecoveryRequest> selector = null, CancellationToken ct = default) => RecoveryAsync(selector.InvokeOrDefault(new CatRecoveryDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.recovery</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</a>
		/// </summary>
		public CatResponse<CatRecoveryRecord> Recovery(ICatRecoveryRequest request) => DoCat<ICatRecoveryRequest, CatRecoveryRequestParameters, CatRecoveryRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.recovery</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</a>
		/// </summary>
		public Task<CatResponse<CatRecoveryRecord>> RecoveryAsync(ICatRecoveryRequest request, CancellationToken ct = default) => DoCatAsync<ICatRecoveryRequest, CatRecoveryRequestParameters, CatRecoveryRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.repositories</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</a>
		/// </summary>
		public CatResponse<CatRepositoriesRecord> Repositories(Func<CatRepositoriesDescriptor, ICatRepositoriesRequest> selector = null) => Repositories(selector.InvokeOrDefault(new CatRepositoriesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.repositories</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</a>
		/// </summary>
		public Task<CatResponse<CatRepositoriesRecord>> RepositoriesAsync(Func<CatRepositoriesDescriptor, ICatRepositoriesRequest> selector = null, CancellationToken ct = default) => RepositoriesAsync(selector.InvokeOrDefault(new CatRepositoriesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.repositories</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</a>
		/// </summary>
		public CatResponse<CatRepositoriesRecord> Repositories(ICatRepositoriesRequest request) => DoCat<ICatRepositoriesRequest, CatRepositoriesRequestParameters, CatRepositoriesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.repositories</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</a>
		/// </summary>
		public Task<CatResponse<CatRepositoriesRecord>> RepositoriesAsync(ICatRepositoriesRequest request, CancellationToken ct = default) => DoCatAsync<ICatRepositoriesRequest, CatRepositoriesRequestParameters, CatRepositoriesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.segments</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</a>
		/// </summary>
		public CatResponse<CatSegmentsRecord> Segments(Func<CatSegmentsDescriptor, ICatSegmentsRequest> selector = null) => Segments(selector.InvokeOrDefault(new CatSegmentsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.segments</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</a>
		/// </summary>
		public Task<CatResponse<CatSegmentsRecord>> SegmentsAsync(Func<CatSegmentsDescriptor, ICatSegmentsRequest> selector = null, CancellationToken ct = default) => SegmentsAsync(selector.InvokeOrDefault(new CatSegmentsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.segments</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</a>
		/// </summary>
		public CatResponse<CatSegmentsRecord> Segments(ICatSegmentsRequest request) => DoCat<ICatSegmentsRequest, CatSegmentsRequestParameters, CatSegmentsRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.segments</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</a>
		/// </summary>
		public Task<CatResponse<CatSegmentsRecord>> SegmentsAsync(ICatSegmentsRequest request, CancellationToken ct = default) => DoCatAsync<ICatSegmentsRequest, CatSegmentsRequestParameters, CatSegmentsRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</a>
		/// </summary>
		public CatResponse<CatShardsRecord> Shards(Func<CatShardsDescriptor, ICatShardsRequest> selector = null) => Shards(selector.InvokeOrDefault(new CatShardsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</a>
		/// </summary>
		public Task<CatResponse<CatShardsRecord>> ShardsAsync(Func<CatShardsDescriptor, ICatShardsRequest> selector = null, CancellationToken ct = default) => ShardsAsync(selector.InvokeOrDefault(new CatShardsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</a>
		/// </summary>
		public CatResponse<CatShardsRecord> Shards(ICatShardsRequest request) => DoCat<ICatShardsRequest, CatShardsRequestParameters, CatShardsRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.shards</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</a>
		/// </summary>
		public Task<CatResponse<CatShardsRecord>> ShardsAsync(ICatShardsRequest request, CancellationToken ct = default) => DoCatAsync<ICatShardsRequest, CatShardsRequestParameters, CatShardsRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.snapshots</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CatResponse<CatSnapshotsRecord> Snapshots(Func<CatSnapshotsDescriptor, ICatSnapshotsRequest> selector = null) => Snapshots(selector.InvokeOrDefault(new CatSnapshotsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.snapshots</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CatResponse<CatSnapshotsRecord>> SnapshotsAsync(Func<CatSnapshotsDescriptor, ICatSnapshotsRequest> selector = null, CancellationToken ct = default) => SnapshotsAsync(selector.InvokeOrDefault(new CatSnapshotsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.snapshots</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CatResponse<CatSnapshotsRecord> Snapshots(ICatSnapshotsRequest request) => DoCat<ICatSnapshotsRequest, CatSnapshotsRequestParameters, CatSnapshotsRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.snapshots</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CatResponse<CatSnapshotsRecord>> SnapshotsAsync(ICatSnapshotsRequest request, CancellationToken ct = default) => DoCatAsync<ICatSnapshotsRequest, CatSnapshotsRequestParameters, CatSnapshotsRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</a>
		/// </summary>
		public CatResponse<CatTasksRecord> Tasks(Func<CatTasksDescriptor, ICatTasksRequest> selector = null) => Tasks(selector.InvokeOrDefault(new CatTasksDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</a>
		/// </summary>
		public Task<CatResponse<CatTasksRecord>> TasksAsync(Func<CatTasksDescriptor, ICatTasksRequest> selector = null, CancellationToken ct = default) => TasksAsync(selector.InvokeOrDefault(new CatTasksDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</a>
		/// </summary>
		public CatResponse<CatTasksRecord> Tasks(ICatTasksRequest request) => DoCat<ICatTasksRequest, CatTasksRequestParameters, CatTasksRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.tasks</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</a>
		/// </summary>
		public Task<CatResponse<CatTasksRecord>> TasksAsync(ICatTasksRequest request, CancellationToken ct = default) => DoCatAsync<ICatTasksRequest, CatTasksRequestParameters, CatTasksRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.templates</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</a>
		/// </summary>
		public CatResponse<CatTemplatesRecord> Templates(Func<CatTemplatesDescriptor, ICatTemplatesRequest> selector = null) => Templates(selector.InvokeOrDefault(new CatTemplatesDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.templates</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</a>
		/// </summary>
		public Task<CatResponse<CatTemplatesRecord>> TemplatesAsync(Func<CatTemplatesDescriptor, ICatTemplatesRequest> selector = null, CancellationToken ct = default) => TemplatesAsync(selector.InvokeOrDefault(new CatTemplatesDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.templates</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</a>
		/// </summary>
		public CatResponse<CatTemplatesRecord> Templates(ICatTemplatesRequest request) => DoCat<ICatTemplatesRequest, CatTemplatesRequestParameters, CatTemplatesRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.templates</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</a>
		/// </summary>
		public Task<CatResponse<CatTemplatesRecord>> TemplatesAsync(ICatTemplatesRequest request, CancellationToken ct = default) => DoCatAsync<ICatTemplatesRequest, CatTemplatesRequestParameters, CatTemplatesRecord>(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.thread_pool</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</a>
		/// </summary>
		public CatResponse<CatThreadPoolRecord> ThreadPool(Func<CatThreadPoolDescriptor, ICatThreadPoolRequest> selector = null) => ThreadPool(selector.InvokeOrDefault(new CatThreadPoolDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>cat.thread_pool</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</a>
		/// </summary>
		public Task<CatResponse<CatThreadPoolRecord>> ThreadPoolAsync(Func<CatThreadPoolDescriptor, ICatThreadPoolRequest> selector = null, CancellationToken ct = default) => ThreadPoolAsync(selector.InvokeOrDefault(new CatThreadPoolDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.thread_pool</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</a>
		/// </summary>
		public CatResponse<CatThreadPoolRecord> ThreadPool(ICatThreadPoolRequest request) => DoCat<ICatThreadPoolRequest, CatThreadPoolRequestParameters, CatThreadPoolRecord>(request);
		/// <summary>
		/// <c>GET</c> request to the <c>cat.thread_pool</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</a>
		/// </summary>
		public Task<CatResponse<CatThreadPoolRecord>> ThreadPoolAsync(ICatThreadPoolRequest request, CancellationToken ct = default) => DoCatAsync<ICatThreadPoolRequest, CatThreadPoolRequestParameters, CatThreadPoolRecord>(request, ct);
	}
}
