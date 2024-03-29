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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_neo_swaps.types.pool
{
    
    
    /// <summary>
    /// >> 550 - Composite[zrml_neo_swaps.types.pool.Pool]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Pool : BaseType
    {
        
        /// <summary>
        /// >> account_id
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 AccountId { get; set; }
        /// <summary>
        /// >> reserves
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Types.Base.BTreeMapT1 Reserves { get; set; }
        /// <summary>
        /// >> collateral
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset Collateral { get; set; }
        /// <summary>
        /// >> liquidity_parameter
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 LiquidityParameter { get; set; }
        /// <summary>
        /// >> liquidity_shares_manager
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_neo_swaps.liquidity_tree.types.liquidity_tree.LiquidityTree LiquiditySharesManager { get; set; }
        /// <summary>
        /// >> swap_fee
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SwapFee { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Pool";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AccountId.Encode());
            result.AddRange(Reserves.Encode());
            result.AddRange(Collateral.Encode());
            result.AddRange(LiquidityParameter.Encode());
            result.AddRange(LiquiditySharesManager.Encode());
            result.AddRange(SwapFee.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AccountId = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            AccountId.Decode(byteArray, ref p);
            Reserves = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Types.Base.BTreeMapT1();
            Reserves.Decode(byteArray, ref p);
            Collateral = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset();
            Collateral.Decode(byteArray, ref p);
            LiquidityParameter = new Substrate.NetApi.Model.Types.Primitive.U128();
            LiquidityParameter.Decode(byteArray, ref p);
            LiquiditySharesManager = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_neo_swaps.liquidity_tree.types.liquidity_tree.LiquidityTree();
            LiquiditySharesManager.Decode(byteArray, ref p);
            SwapFee = new Substrate.NetApi.Model.Types.Primitive.U128();
            SwapFee.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
