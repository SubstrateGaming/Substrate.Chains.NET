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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.ctype_entry
{
    
    
    /// <summary>
    /// >> 414 - Composite[ctype.ctype_entry.CtypeEntry]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CtypeEntry : BaseType
    {
        
        /// <summary>
        /// >> creator
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _creator;
        
        /// <summary>
        /// >> created_at
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _createdAt;
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Creator
        {
            get
            {
                return this._creator;
            }
            set
            {
                this._creator = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 CreatedAt
        {
            get
            {
                return this._createdAt;
            }
            set
            {
                this._createdAt = value;
            }
        }
        
        public override string TypeName()
        {
            return "CtypeEntry";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Creator.Encode());
            result.AddRange(CreatedAt.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Creator = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Creator.Decode(byteArray, ref p);
            CreatedAt = new Substrate.NetApi.Model.Types.Primitive.U64();
            CreatedAt.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}