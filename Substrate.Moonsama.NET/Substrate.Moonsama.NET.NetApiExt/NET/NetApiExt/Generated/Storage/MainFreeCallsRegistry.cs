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
    
    
    public sealed class FreeCallsRegistryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public FreeCallsRegistryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FreeCallsRegistry", "FreeCallsRegistry"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCall), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FreeCallsRegistry", "RequestExpiryDate"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FreeCallsRegistry", "FreeCallsAvailable"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20), typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter)));
        }
        
        /// <summary>
        /// >> FreeCallsRegistryParams
        ///  A map of EVM call signatures to empty values that indicates whether a given signature is registered as a free call.
        /// </summary>
        public static string FreeCallsRegistryParams(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCall key)
        {
            return RequestGenerator.GetStorage("FreeCallsRegistry", "FreeCallsRegistry", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> FreeCallsRegistryDefault
        /// Default value as hex string
        /// </summary>
        public static string FreeCallsRegistryDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> FreeCallsRegistry
        ///  A map of EVM call signatures to empty values that indicates whether a given signature is registered as a free call.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple> FreeCallsRegistry(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCall key, CancellationToken token)
        {
            string parameters = FreeCallsRegistryStorage.FreeCallsRegistryParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> RequestExpiryDateParams
        ///  A map of senders to empty that indicates that indicates whether a sender can request free calls for some EVM account.
        /// </summary>
        public static string RequestExpiryDateParams(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
        {
            return RequestGenerator.GetStorage("FreeCallsRegistry", "RequestExpiryDate", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> RequestExpiryDateDefault
        /// Default value as hex string
        /// </summary>
        public static string RequestExpiryDateDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> RequestExpiryDate
        ///  A map of senders to empty that indicates that indicates whether a sender can request free calls for some EVM account.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> RequestExpiryDate(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key, CancellationToken token)
        {
            string parameters = FreeCallsRegistryStorage.RequestExpiryDateParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> FreeCallsAvailableParams
        ///  A map of senders to EvmCallCounter structs that indicates how many free calls the sender has available and when they expire.
        /// </summary>
        public static string FreeCallsAvailableParams(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
        {
            return RequestGenerator.GetStorage("FreeCallsRegistry", "FreeCallsAvailable", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> FreeCallsAvailableDefault
        /// Default value as hex string
        /// </summary>
        public static string FreeCallsAvailableDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> FreeCallsAvailable
        ///  A map of senders to EvmCallCounter structs that indicates how many free calls the sender has available and when they expire.
        /// </summary>
        public async Task<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter> FreeCallsAvailable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key, CancellationToken token)
        {
            string parameters = FreeCallsRegistryStorage.FreeCallsAvailableParams(key);
            var result = await _client.GetStorageAsync<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter>(parameters, token);
            return result;
        }
    }
    
    public sealed class FreeCallsRegistryCalls
    {
        
        /// <summary>
        /// >> register_free_call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterFreeCall(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 target, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr4U8 selector, Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EnumFreeCallType call_type)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(selector.Encode());
            byteArray.AddRange(call_type.Encode());
            return new Method(43, "FreeCallsRegistry", 0, "register_free_call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unregister_free_call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnregisterFreeCall(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 target, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr4U8 selector, Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EnumFreeCallType call_type)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(selector.Encode());
            byteArray.AddRange(call_type.Encode());
            return new Method(43, "FreeCallsRegistry", 1, "unregister_free_call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> request_free_calls
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RequestFreeCalls()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(43, "FreeCallsRegistry", 2, "request_free_calls", byteArray.ToArray());
        }
    }
    
    public sealed class FreeCallsRegistryConstants
    {
        
        /// <summary>
        /// >> FreeCallsNumber
        ///  Number of free call, which user can request
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 FreeCallsNumber()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> ExpiryPeriod
        ///  Expiry period of requested free calls
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ExpiryPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xE0C40000");
            return result;
        }
    }
    
    public enum FreeCallsRegistryErrors
    {
        
        /// <summary>
        /// >> AlreadyRequested
        /// </summary>
        AlreadyRequested,
        
        /// <summary>
        /// >> AlreadyRegistered
        /// </summary>
        AlreadyRegistered,
    }
}
