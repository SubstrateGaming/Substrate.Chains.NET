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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class EvmChainIdStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public EvmChainIdStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmChainId", "ChainId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
        }
        
        /// <summary>
        /// >> ChainIdParams
        ///  The EVM chain ID.
        /// </summary>
        public static string ChainIdParams()
        {
            return RequestGenerator.GetStorage("EvmChainId", "ChainId", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ChainIdDefault
        /// Default value as hex string
        /// </summary>
        public static string ChainIdDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> ChainId
        ///  The EVM chain ID.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> ChainId(CancellationToken token)
        {
            string parameters = EvmChainIdStorage.ChainIdParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
    }
    
    public sealed class EvmChainIdCalls
    {
    }
    
    public sealed class EvmChainIdConstants
    {
    }
}