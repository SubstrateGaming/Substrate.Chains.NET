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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> ValidatorManagerStorage
    /// </summary>
    public sealed class ValidatorManagerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ValidatorManagerStorage Constructor
        /// </summary>
        public ValidatorManagerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ValidatorManager", "ValidatorsToRetire"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ValidatorManager", "ValidatorsToAdd"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>)));
        }
        
        /// <summary>
        /// >> ValidatorsToRetireParams
        ///  Validators that should be retired, because their Parachain was deregistered.
        /// </summary>
        public static string ValidatorsToRetireParams()
        {
            return RequestGenerator.GetStorage("ValidatorManager", "ValidatorsToRetire", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ValidatorsToRetireDefault
        /// Default value as hex string
        /// </summary>
        public static string ValidatorsToRetireDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ValidatorsToRetire
        ///  Validators that should be retired, because their Parachain was deregistered.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> ValidatorsToRetire(string blockhash, CancellationToken token)
        {
            string parameters = ValidatorManagerStorage.ValidatorsToRetireParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ValidatorsToAddParams
        ///  Validators that should be added.
        /// </summary>
        public static string ValidatorsToAddParams()
        {
            return RequestGenerator.GetStorage("ValidatorManager", "ValidatorsToAdd", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ValidatorsToAddDefault
        /// Default value as hex string
        /// </summary>
        public static string ValidatorsToAddDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ValidatorsToAdd
        ///  Validators that should be added.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> ValidatorsToAdd(string blockhash, CancellationToken token)
        {
            string parameters = ValidatorManagerStorage.ValidatorsToAddParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ValidatorManagerCalls
    /// </summary>
    public sealed class ValidatorManagerCalls
    {
        
        /// <summary>
        /// >> register_validators
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterValidators(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> validators)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(validators.Encode());
            return new Method(252, "ValidatorManager", 0, "register_validators", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> deregister_validators
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DeregisterValidators(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> validators)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(validators.Encode());
            return new Method(252, "ValidatorManager", 1, "deregister_validators", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ValidatorManagerConstants
    /// </summary>
    public sealed class ValidatorManagerConstants
    {
    }
}
