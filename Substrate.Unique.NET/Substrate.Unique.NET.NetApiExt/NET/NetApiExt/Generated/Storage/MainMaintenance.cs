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


namespace Substrate.Unique.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class MaintenanceStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public MaintenanceStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Maintenance", "Enabled"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> EnabledParams
        /// </summary>
        public static string EnabledParams()
        {
            return RequestGenerator.GetStorage("Maintenance", "Enabled", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EnabledDefault
        /// Default value as hex string
        /// </summary>
        public static string EnabledDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Enabled
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> Enabled(CancellationToken token)
        {
            string parameters = MaintenanceStorage.EnabledParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
    }
    
    public sealed class MaintenanceCalls
    {
        
        /// <summary>
        /// >> enable
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Enable()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(154, "Maintenance", 0, "enable", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> disable
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Disable()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(154, "Maintenance", 1, "disable", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> execute_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ExecutePreimage(Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256 hash, Substrate.Unique.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight weight_bound)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            byteArray.AddRange(weight_bound.Encode());
            return new Method(154, "Maintenance", 2, "execute_preimage", byteArray.ToArray());
        }
    }
    
    public sealed class MaintenanceConstants
    {
    }
    
    public enum MaintenanceErrors
    {
    }
}