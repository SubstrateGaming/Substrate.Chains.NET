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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> bid
        /// See [`Pallet::bid`].
        /// </summary>
        bid = 0,
        
        /// <summary>
        /// >> unbid
        /// See [`Pallet::unbid`].
        /// </summary>
        unbid = 1,
        
        /// <summary>
        /// >> vouch
        /// See [`Pallet::vouch`].
        /// </summary>
        vouch = 2,
        
        /// <summary>
        /// >> unvouch
        /// See [`Pallet::unvouch`].
        /// </summary>
        unvouch = 3,
        
        /// <summary>
        /// >> vote
        /// See [`Pallet::vote`].
        /// </summary>
        vote = 4,
        
        /// <summary>
        /// >> defender_vote
        /// See [`Pallet::defender_vote`].
        /// </summary>
        defender_vote = 5,
        
        /// <summary>
        /// >> payout
        /// See [`Pallet::payout`].
        /// </summary>
        payout = 6,
        
        /// <summary>
        /// >> waive_repay
        /// See [`Pallet::waive_repay`].
        /// </summary>
        waive_repay = 7,
        
        /// <summary>
        /// >> found_society
        /// See [`Pallet::found_society`].
        /// </summary>
        found_society = 8,
        
        /// <summary>
        /// >> dissolve
        /// See [`Pallet::dissolve`].
        /// </summary>
        dissolve = 9,
        
        /// <summary>
        /// >> judge_suspended_member
        /// See [`Pallet::judge_suspended_member`].
        /// </summary>
        judge_suspended_member = 10,
        
        /// <summary>
        /// >> set_parameters
        /// See [`Pallet::set_parameters`].
        /// </summary>
        set_parameters = 11,
        
        /// <summary>
        /// >> punish_skeptic
        /// See [`Pallet::punish_skeptic`].
        /// </summary>
        punish_skeptic = 12,
        
        /// <summary>
        /// >> claim_membership
        /// See [`Pallet::claim_membership`].
        /// </summary>
        claim_membership = 13,
        
        /// <summary>
        /// >> bestow_membership
        /// See [`Pallet::bestow_membership`].
        /// </summary>
        bestow_membership = 14,
        
        /// <summary>
        /// >> kick_candidate
        /// See [`Pallet::kick_candidate`].
        /// </summary>
        kick_candidate = 15,
        
        /// <summary>
        /// >> resign_candidacy
        /// See [`Pallet::resign_candidacy`].
        /// </summary>
        resign_candidacy = 16,
        
        /// <summary>
        /// >> drop_candidate
        /// See [`Pallet::drop_candidate`].
        /// </summary>
        drop_candidate = 17,
        
        /// <summary>
        /// >> cleanup_candidacy
        /// See [`Pallet::cleanup_candidacy`].
        /// </summary>
        cleanup_candidacy = 18,
        
        /// <summary>
        /// >> cleanup_challenge
        /// See [`Pallet::cleanup_challenge`].
        /// </summary>
        cleanup_challenge = 19,
    }
    
    /// <summary>
    /// >> 183 - Variant[pallet_society.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Primitive.U128, BaseVoid, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Primitive.Bool, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U128, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseVoid, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
