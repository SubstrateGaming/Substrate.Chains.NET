//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> proposal
        /// </summary>
        proposal = 0,
        
        /// <summary>
        /// >> vote
        /// </summary>
        vote = 1,
    }
    
    /// <summary>
    /// >> 364 - Variant[gamedao_signal.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.types.EnumProposalType, Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.types.EnumMajority, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.types.EnumUnit, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.types.EnumScale, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.zero_primitives.currency.EnumCurrencyId>>, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>>
    {
    }
}
