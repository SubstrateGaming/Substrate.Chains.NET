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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_conviction_voting.vote
{
    
    
    /// <summary>
    /// >> AccountVote
    /// </summary>
    public enum AccountVote
    {
        
        /// <summary>
        /// >> Standard
        /// </summary>
        Standard = 0,
        
        /// <summary>
        /// >> Split
        /// </summary>
        Split = 1,
        
        /// <summary>
        /// >> SplitAbstain
        /// </summary>
        SplitAbstain = 2,
    }
    
    /// <summary>
    /// >> 589 - Variant[pallet_conviction_voting.vote.AccountVote]
    /// </summary>
    public sealed class EnumAccountVote : BaseEnumExt<AccountVote, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_conviction_voting.vote.Vote, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}