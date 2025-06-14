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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> ClaimsStorage
    /// </summary>
    public sealed class ClaimsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ClaimsStorage Constructor
        /// </summary>
        public ClaimsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Claims", "Claims"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_claims.traits.EthereumAddress), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
        }
        
        /// <summary>
        /// >> ClaimsParams
        ///  Asset id storage for each shared token
        /// </summary>
        public static string ClaimsParams(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_claims.traits.EthereumAddress key)
        {
            return RequestGenerator.GetStorage("Claims", "Claims", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ClaimsDefault
        /// Default value as hex string
        /// </summary>
        public static string ClaimsDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Claims
        ///  Asset id storage for each shared token
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> Claims(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_claims.traits.EthereumAddress key, string blockhash, CancellationToken token)
        {
            string parameters = ClaimsStorage.ClaimsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ClaimsCalls
    /// </summary>
    public sealed class ClaimsCalls
    {
        
        /// <summary>
        /// >> claim
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Claim(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_claims.traits.EcdsaSignature ethereum_signature)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ethereum_signature.Encode());
            return new Method(53, "Claims", 0, "claim", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ClaimsConstants
    /// </summary>
    public sealed class ClaimsConstants
    {
    }
    
    /// <summary>
    /// >> ClaimsErrors
    /// </summary>
    public enum ClaimsErrors
    {
        
        /// <summary>
        /// >> InvalidEthereumSignature
        /// Ethereum signature is not valid
        /// </summary>
        InvalidEthereumSignature,
        
        /// <summary>
        /// >> NoClaimOrAlreadyClaimed
        /// Claim is not valid
        /// </summary>
        NoClaimOrAlreadyClaimed,
        
        /// <summary>
        /// >> BalanceOverflow
        /// Value reached maximum and cannot be incremented further
        /// </summary>
        BalanceOverflow,
    }
}
