//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types
{
    
    
    /// <summary>
    /// >> 262 - Composite[sp_avn_common.event_types.Validator]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Validator : BaseType
    {
        
        /// <summary>
        /// >> account_id
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _accountId;
        
        /// <summary>
        /// >> key
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn.sr25519.app_sr25519.Public _key;
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 AccountId
        {
            get
            {
                return this._accountId;
            }
            set
            {
                this._accountId = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn.sr25519.app_sr25519.Public Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        
        public override string TypeName()
        {
            return "Validator";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AccountId.Encode());
            result.AddRange(Key.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AccountId = new Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            AccountId.Decode(byteArray, ref p);
            Key = new Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn.sr25519.app_sr25519.Public();
            Key.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}