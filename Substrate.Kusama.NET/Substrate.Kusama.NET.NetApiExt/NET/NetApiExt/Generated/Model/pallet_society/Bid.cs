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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society
{
    
    
    /// <summary>
    /// >> 651 - Composite[pallet_society.Bid]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Bid : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        /// <summary>
        /// >> kind
        /// </summary>
        private Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.EnumBidKind _kind;
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _value;
        
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.EnumBidKind Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bid";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Kind.Encode());
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Kind = new Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.EnumBidKind();
            Kind.Decode(byteArray, ref p);
            Value = new Substrate.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
