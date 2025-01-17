#nullable disable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Gear.Api.Generated.Storage
{
    
    
    /// <summary>
    /// >> AuthorityDiscoveryStorage
    /// </summary>
    public sealed class AuthorityDiscoveryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AuthorityDiscoveryStorage Constructor
        /// </summary>
        public AuthorityDiscoveryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuthorityDiscovery", "Keys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuthorityDiscovery", "NextKeys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4)));
        }
        
        /// <summary>
        /// >> KeysParams
        ///  Keys of the current authority set.
        /// </summary>
        public static string KeysParams()
        {
            return RequestGenerator.GetStorage("AuthorityDiscovery", "Keys", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> KeysDefault
        /// Default value as hex string
        /// </summary>
        public static string KeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Keys
        ///  Keys of the current authority set.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4> Keys(string blockhash, CancellationToken token)
        {
            string parameters = AuthorityDiscoveryStorage.KeysParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NextKeysParams
        ///  Keys of the next authority set.
        /// </summary>
        public static string NextKeysParams()
        {
            return RequestGenerator.GetStorage("AuthorityDiscovery", "NextKeys", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextKeysDefault
        /// Default value as hex string
        /// </summary>
        public static string NextKeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> NextKeys
        ///  Keys of the next authority set.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4> NextKeys(string blockhash, CancellationToken token)
        {
            string parameters = AuthorityDiscoveryStorage.NextKeysParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT4>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AuthorityDiscoveryCalls
    /// </summary>
    public sealed class AuthorityDiscoveryCalls
    {
    }
    
    /// <summary>
    /// >> AuthorityDiscoveryConstants
    /// </summary>
    public sealed class AuthorityDiscoveryConstants
    {
    }
}
