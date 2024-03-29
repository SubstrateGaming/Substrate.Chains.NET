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


namespace Substrate.KILT.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class CtypeStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public CtypeStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ctype", "Ctypes"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.ctype_entry.CtypeEntry)));
        }
        
        /// <summary>
        /// >> CtypesParams
        ///  CTypes stored on chain.
        /// 
        ///  It maps from a CType hash to its creator and block number in which it
        ///  was created.
        /// </summary>
        public static string CtypesParams(Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Ctype", "Ctypes", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CtypesDefault
        /// Default value as hex string
        /// </summary>
        public static string CtypesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Ctypes
        ///  CTypes stored on chain.
        /// 
        ///  It maps from a CType hash to its creator and block number in which it
        ///  was created.
        /// </summary>
        public async Task<Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.ctype_entry.CtypeEntry> Ctypes(Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = CtypeStorage.CtypesParams(key);
            var result = await _client.GetStorageAsync<Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.ctype_entry.CtypeEntry>(parameters, token);
            return result;
        }
    }
    
    public sealed class CtypeCalls
    {
        
        /// <summary>
        /// >> add
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Add(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> ctype)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ctype.Encode());
            return new Method(61, "Ctype", 0, "add", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_block_number
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetBlockNumber(Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256 ctype_hash, Substrate.NetApi.Model.Types.Primitive.U64 block_number)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ctype_hash.Encode());
            byteArray.AddRange(block_number.Encode());
            return new Method(61, "Ctype", 1, "set_block_number", byteArray.ToArray());
        }
    }
    
    public sealed class CtypeConstants
    {
    }
    
    public enum CtypeErrors
    {
        
        /// <summary>
        /// >> NotFound
        /// There is no CType with the given hash.
        /// </summary>
        NotFound,
        
        /// <summary>
        /// >> AlreadyExists
        /// The CType already exists.
        /// </summary>
        AlreadyExists,
        
        /// <summary>
        /// >> UnableToPayFees
        /// The paying account was unable to pay the fees for creating a ctype.
        /// </summary>
        UnableToPayFees,
    }
}
