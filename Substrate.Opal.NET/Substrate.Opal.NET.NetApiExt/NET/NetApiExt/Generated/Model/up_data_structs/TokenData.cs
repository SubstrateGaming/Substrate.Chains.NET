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


namespace Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 606 - Composite[up_data_structs.TokenData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TokenData : BaseType
    {
        
        /// <summary>
        /// >> properties
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.Property> Properties { get; set; }
        /// <summary>
        /// >> owner
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> Owner { get; set; }
        /// <summary>
        /// >> pieces
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Pieces { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TokenData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Properties.Encode());
            result.AddRange(Owner.Encode());
            result.AddRange(Pieces.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Properties = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.Property>();
            Properties.Decode(byteArray, ref p);
            Owner = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>();
            Owner.Decode(byteArray, ref p);
            Pieces = new Substrate.NetApi.Model.Types.Primitive.U128();
            Pieces.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}