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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime
{
    
    
    /// <summary>
    /// >> RuntimeEvent
    /// </summary>
    public enum RuntimeEvent
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> Indices
        /// </summary>
        Indices = 3,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 4,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 33,
        
        /// <summary>
        /// >> Staking
        /// </summary>
        Staking = 6,
        
        /// <summary>
        /// >> Offences
        /// </summary>
        Offences = 7,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 8,
        
        /// <summary>
        /// >> Grandpa
        /// </summary>
        Grandpa = 10,
        
        /// <summary>
        /// >> ImOnline
        /// </summary>
        ImOnline = 11,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 18,
        
        /// <summary>
        /// >> ConvictionVoting
        /// </summary>
        ConvictionVoting = 20,
        
        /// <summary>
        /// >> Referenda
        /// </summary>
        Referenda = 21,
        
        /// <summary>
        /// >> FellowshipCollective
        /// </summary>
        FellowshipCollective = 22,
        
        /// <summary>
        /// >> FellowshipReferenda
        /// </summary>
        FellowshipReferenda = 23,
        
        /// <summary>
        /// >> Whitelist
        /// </summary>
        Whitelist = 44,
        
        /// <summary>
        /// >> Claims
        /// </summary>
        Claims = 19,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 24,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 25,
        
        /// <summary>
        /// >> Society
        /// </summary>
        Society = 26,
        
        /// <summary>
        /// >> Recovery
        /// </summary>
        Recovery = 27,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 28,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 29,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 30,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 31,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 32,
        
        /// <summary>
        /// >> Bounties
        /// </summary>
        Bounties = 35,
        
        /// <summary>
        /// >> ChildBounties
        /// </summary>
        ChildBounties = 40,
        
        /// <summary>
        /// >> ElectionProviderMultiPhase
        /// </summary>
        ElectionProviderMultiPhase = 37,
        
        /// <summary>
        /// >> Nis
        /// </summary>
        Nis = 38,
        
        /// <summary>
        /// >> NisCounterpartBalances
        /// </summary>
        NisCounterpartBalances = 45,
        
        /// <summary>
        /// >> VoterList
        /// </summary>
        VoterList = 39,
        
        /// <summary>
        /// >> NominationPools
        /// </summary>
        NominationPools = 41,
        
        /// <summary>
        /// >> FastUnstake
        /// </summary>
        FastUnstake = 42,
        
        /// <summary>
        /// >> ParaInclusion
        /// </summary>
        ParaInclusion = 53,
        
        /// <summary>
        /// >> Paras
        /// </summary>
        Paras = 56,
        
        /// <summary>
        /// >> Hrmp
        /// </summary>
        Hrmp = 60,
        
        /// <summary>
        /// >> ParasDisputes
        /// </summary>
        ParasDisputes = 62,
        
        /// <summary>
        /// >> Registrar
        /// </summary>
        Registrar = 70,
        
        /// <summary>
        /// >> Slots
        /// </summary>
        Slots = 71,
        
        /// <summary>
        /// >> Auctions
        /// </summary>
        Auctions = 72,
        
        /// <summary>
        /// >> Crowdloan
        /// </summary>
        Crowdloan = 73,
        
        /// <summary>
        /// >> StateTrieMigration
        /// </summary>
        StateTrieMigration = 98,
        
        /// <summary>
        /// >> XcmPallet
        /// </summary>
        XcmPallet = 99,
        
        /// <summary>
        /// >> MessageQueue
        /// </summary>
        MessageQueue = 100,
    }
    
    /// <summary>
    /// >> 20 - Variant[staging_kusama_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumExt<RuntimeEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_indices.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_staking.pallet.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_offences.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_session.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_grandpa.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_im_online.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_treasury.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.claims.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_conviction_voting.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_referenda.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_ranked_collective.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_referenda.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_utility.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_identity.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_recovery.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_vesting.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_scheduler.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_proxy.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_multisig.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_transaction_payment.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_bounties.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_nis.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_bags_list.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_child_bounties.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_nomination_pools.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_whitelist.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.pallet.EnumEvent, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.pallet.EnumEvent, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.slots.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.auctions.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumEvent, Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_message_queue.pallet.EnumEvent>
    {
    }
}