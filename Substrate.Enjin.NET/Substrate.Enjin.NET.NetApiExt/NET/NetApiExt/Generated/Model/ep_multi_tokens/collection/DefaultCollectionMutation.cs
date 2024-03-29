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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection
{
    
    
    /// <summary>
    /// >> 178 - Composite[ep_multi_tokens.collection.DefaultCollectionMutation]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DefaultCollectionMutation : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Owner { get; set; }
        /// <summary>
        /// >> royalty
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.types.EnumShouldMutate Royalty { get; set; }
        /// <summary>
        /// >> explicit_royalty_currencies
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5> ExplicitRoyaltyCurrencies { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DefaultCollectionMutation";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Royalty.Encode());
            result.AddRange(ExplicitRoyaltyCurrencies.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Owner.Decode(byteArray, ref p);
            Royalty = new Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.types.EnumShouldMutate();
            Royalty.Decode(byteArray, ref p);
            ExplicitRoyaltyCurrencies = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>();
            ExplicitRoyaltyCurrencies.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
