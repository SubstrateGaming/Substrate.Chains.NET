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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_moonbeam_orbiters.types
{
    
    
    /// <summary>
    /// >> 249 - Composite[pallet_moonbeam_orbiters.types.CurrentOrbiter]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CurrentOrbiter : BaseType
    {
        
        /// <summary>
        /// >> account_id
        /// </summary>
        private Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 _accountId;
        
        /// <summary>
        /// >> removed
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _removed;
        
        public Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 AccountId
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
        
        public Substrate.NetApi.Model.Types.Primitive.Bool Removed
        {
            get
            {
                return this._removed;
            }
            set
            {
                this._removed = value;
            }
        }
        
        public override string TypeName()
        {
            return "CurrentOrbiter";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AccountId.Encode());
            result.AddRange(Removed.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AccountId = new Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20();
            AccountId.Decode(byteArray, ref p);
            Removed = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Removed.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
