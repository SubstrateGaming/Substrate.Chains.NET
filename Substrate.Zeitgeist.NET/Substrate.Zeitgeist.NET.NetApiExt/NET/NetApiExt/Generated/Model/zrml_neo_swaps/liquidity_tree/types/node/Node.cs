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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_neo_swaps.liquidity_tree.types.node
{
    
    
    /// <summary>
    /// >> 553 - Composite[zrml_neo_swaps.liquidity_tree.types.node.Node]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Node : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Account { get; set; }
        /// <summary>
        /// >> stake
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Stake { get; set; }
        /// <summary>
        /// >> fees
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Fees { get; set; }
        /// <summary>
        /// >> descendant_stake
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DescendantStake { get; set; }
        /// <summary>
        /// >> lazy_fees
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 LazyFees { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Node";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Stake.Encode());
            result.AddRange(Fees.Encode());
            result.AddRange(DescendantStake.Encode());
            result.AddRange(LazyFees.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Account.Decode(byteArray, ref p);
            Stake = new Substrate.NetApi.Model.Types.Primitive.U128();
            Stake.Decode(byteArray, ref p);
            Fees = new Substrate.NetApi.Model.Types.Primitive.U128();
            Fees.Decode(byteArray, ref p);
            DescendantStake = new Substrate.NetApi.Model.Types.Primitive.U128();
            DescendantStake.Decode(byteArray, ref p);
            LazyFees = new Substrate.NetApi.Model.Types.Primitive.U128();
            LazyFees.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
