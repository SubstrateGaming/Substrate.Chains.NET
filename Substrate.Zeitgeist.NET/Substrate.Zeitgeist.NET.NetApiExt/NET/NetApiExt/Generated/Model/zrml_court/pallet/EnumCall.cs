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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> join_court
        /// Join to become a juror, who is able to get randomly selected
        /// for court cases according to the provided stake.
        /// If the juror is already part of the court,
        /// the `amount` needs to be higher than the previous amount to update the juror stake.
        /// If the juror gets selected for a court case, the juror has to vote and reveal the vote.
        /// If the juror does not vote or reveal the vote, the juror gets slashed
        /// by the selected multiple of `MinJurorStake` for the court.
        /// The risked amount depends on the juror random selection algorithm,
        /// but is at most (`MaxSelectedDraws` / 2) mulitplied by the `MinJurorStake`
        /// for all jurors and delegators in one court.
        /// Assume you get randomly selected on one of these `MinJurorStake`'s.
        /// Then you risk at most `MinJurorStake` for this court.
        /// The probability to get selected is higher the more funds are staked.
        /// The `amount` of this call represents the total stake of the juror.
        /// If the pool is full, the lowest staked court participant is removed from the court pool.
        /// If the `amount` is lower than the lowest staked court participant, the call fails.
        /// 
        /// # Arguments
        /// 
        /// - `amount`: The total stake associated with the joining juror.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of jurors in the stake-weighted pool.
        /// </summary>
        join_court = 0,
        
        /// <summary>
        /// >> delegate
        /// Join the court to become a delegator.
        /// If the random selection algorithm chooses a delegators stake,
        /// the caller delegates the vote power to the drawn delegated juror.
        /// The delegator gets slashed or rewarded according to the delegated juror's decisions.
        /// If the delegator is already part of the court,
        /// the `amount` needs to be higher than the previous amount to update the delegators stake.
        /// The `amount` of this call represents the total stake of the delegator.
        /// If the pool is full, the lowest staked court participant is removed from the court pool.
        /// If the `amount` is lower than the lowest staked court participant, the call fails.
        /// 
        /// # Arguments
        /// 
        /// - `amount`: The total stake associated with the joining delegator.
        /// - `delegations`: The list of jurors to delegate the vote power to.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of jurors in the stake-weighted pool.
        /// </summary>
        @delegate = 1,
        
        /// <summary>
        /// >> prepare_exit_court
        /// Prepare as a court participant (juror or delegator) to exit the court.
        /// When this is called the court participant is not anymore able to get drawn for new cases.
        /// The court participant gets removed from the stake-weighted pool.
        /// After that the court participant can exit the court.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of jurors in the stake-weighted pool.
        /// </summary>
        prepare_exit_court = 2,
        
        /// <summary>
        /// >> exit_court
        /// Exit the court.
        /// The stake which is not locked by any court case is unlocked.
        /// `prepare_exit_court` must be called before
        /// to remove the court participant (juror or delegator) from the stake-weighted pool.
        /// 
        /// # Arguments
        /// 
        /// - `court_participant`: The court participant,
        /// who is assumed not to be part of the pool anymore.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of jurors in the stake-weighted pool.
        /// </summary>
        exit_court = 3,
        
        /// <summary>
        /// >> vote
        /// Vote as a randomly selected juror for a specific court case.
        /// 
        /// # Arguments
        /// 
        /// - `court_id`: The identifier of the court.
        /// - `commitment_vote`: A hash which consists of `juror ++ vote_item ++ salt`.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of participants
        /// in the list of random selections (draws).
        /// </summary>
        vote = 4,
        
        /// <summary>
        /// >> denounce_vote
        /// Denounce a juror during the voting period for which the commitment vote is known.
        /// This is useful to punish the behaviour that jurors reveal
        /// their commitments to others before the voting period ends.
        /// A check of `commitment_hash == hash(juror ++ vote_item ++ salt)`
        /// is performed for validation.
        /// 
        /// # Arguments
        /// 
        /// - `court_id`: The identifier of the court.
        /// - `juror`: The juror whose commitment vote might be known.
        /// - `vote_item`: The raw vote item which should match with the commitment of the juror.
        /// - `salt`: The hash which is used to proof that the juror did reveal
        /// her vote during the voting period.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of selected draws
        /// in the specified court.
        /// </summary>
        denounce_vote = 5,
        
        /// <summary>
        /// >> reveal_vote
        /// Reveal the commitment vote of the caller, who is a selected juror.
        /// A check of `commitment_hash == hash(juror ++ vote_item ++ salt)`
        /// is performed for validation.
        /// 
        /// # Arguments
        /// 
        /// - `court_id`: The identifier of the court.
        /// - `vote_item`: The raw vote item which should match with the commitment of the juror.
        /// - `salt`: The hash which is used for the validation.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(log(n))`, where `n` is the number of selected draws
        /// in the specified court.
        /// </summary>
        reveal_vote = 6,
        
        /// <summary>
        /// >> appeal
        /// Initiate an appeal for a court
        /// if the presumptive winner of the last vote round is believed to be incorrect.
        /// The last appeal does not trigger a new court round
        /// but instead it marks the court mechanism for this market as failed.
        /// If the court failed, the prediction markets pallet takes over the dispute resolution.
        /// The prediction markets pallet might allow to trigger a global token holder vote.
        /// 
        /// # Arguments
        /// 
        /// - `court_id`: The identifier of the court.
        /// 
        /// # Weight
        /// 
        /// Complexity: It depends heavily on the complexity of `select_participants`.
        /// </summary>
        appeal = 7,
        
        /// <summary>
        /// >> reassign_court_stakes
        /// Reassign the stakes of the jurors and delegators
        /// for the selected draws of the specified court.
        /// The losing jurors and delegators get slashed and
        /// pay for the winning jurors and delegators.
        /// The tardy (juror did not reveal or did not vote) or denounced jurors
        /// and associated delegators get slashed and reward the winners.
        /// 
        /// # Arguments
        /// 
        /// - `court_id`: The identifier of the court.
        /// 
        /// # Weight
        /// 
        /// Complexity: O(N + M), with `N` being the number of draws and `M` being the total number of valid winners and losers.
        /// </summary>
        reassign_court_stakes = 8,
        
        /// <summary>
        /// >> set_inflation
        /// Set the yearly inflation rate of the court system.
        /// This is only allowed to be called by the `MonetaryGovernanceOrigin`.
        /// 
        /// # Arguments
        /// 
        /// - `inflation`: The desired yearly inflation rate.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(1)`
        /// </summary>
        set_inflation = 9,
    }
    
    /// <summary>
    /// >> 316 - Variant[zrml_court.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Primitive.U128, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.types.EnumVoteItem, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.types.EnumVoteItem, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>
    {
    }
}
