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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_runtime
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
        /// >> Scheduler
        /// </summary>
        Scheduler = 3,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 4,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 10,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 11,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 12,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 13,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 14,
        
        /// <summary>
        /// >> Bounties
        /// </summary>
        Bounties = 15,
        
        /// <summary>
        /// >> AssetTxPayment
        /// </summary>
        AssetTxPayment = 16,
        
        /// <summary>
        /// >> Democracy
        /// </summary>
        Democracy = 20,
        
        /// <summary>
        /// >> AdvisoryCommittee
        /// </summary>
        AdvisoryCommittee = 21,
        
        /// <summary>
        /// >> AdvisoryCommitteeMembership
        /// </summary>
        AdvisoryCommitteeMembership = 22,
        
        /// <summary>
        /// >> Council
        /// </summary>
        Council = 23,
        
        /// <summary>
        /// >> CouncilMembership
        /// </summary>
        CouncilMembership = 24,
        
        /// <summary>
        /// >> TechnicalCommittee
        /// </summary>
        TechnicalCommittee = 25,
        
        /// <summary>
        /// >> TechnicalCommitteeMembership
        /// </summary>
        TechnicalCommitteeMembership = 26,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 30,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 31,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 32,
        
        /// <summary>
        /// >> Contracts
        /// </summary>
        Contracts = 33,
        
        /// <summary>
        /// >> Tokens
        /// </summary>
        Tokens = 41,
        
        /// <summary>
        /// >> Authorized
        /// </summary>
        Authorized = 51,
        
        /// <summary>
        /// >> Court
        /// </summary>
        Court = 52,
        
        /// <summary>
        /// >> LiquidityMining
        /// </summary>
        LiquidityMining = 53,
        
        /// <summary>
        /// >> SimpleDisputes
        /// </summary>
        SimpleDisputes = 55,
        
        /// <summary>
        /// >> Swaps
        /// </summary>
        Swaps = 56,
        
        /// <summary>
        /// >> PredictionMarkets
        /// </summary>
        PredictionMarkets = 57,
        
        /// <summary>
        /// >> Styx
        /// </summary>
        Styx = 58,
        
        /// <summary>
        /// >> GlobalDisputes
        /// </summary>
        GlobalDisputes = 59,
        
        /// <summary>
        /// >> NeoSwaps
        /// </summary>
        NeoSwaps = 60,
        
        /// <summary>
        /// >> Orderbook
        /// </summary>
        Orderbook = 61,
        
        /// <summary>
        /// >> Parimutuel
        /// </summary>
        Parimutuel = 62,
        
        /// <summary>
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 100,
        
        /// <summary>
        /// >> ParachainStaking
        /// </summary>
        ParachainStaking = 110,
        
        /// <summary>
        /// >> AuthorFilter
        /// </summary>
        AuthorFilter = 112,
        
        /// <summary>
        /// >> AuthorMapping
        /// </summary>
        AuthorMapping = 113,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 120,
        
        /// <summary>
        /// >> DmpQueue
        /// </summary>
        DmpQueue = 121,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 122,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 123,
        
        /// <summary>
        /// >> AssetRegistry
        /// </summary>
        AssetRegistry = 124,
        
        /// <summary>
        /// >> UnknownTokens
        /// </summary>
        UnknownTokens = 125,
        
        /// <summary>
        /// >> XTokens
        /// </summary>
        XTokens = 126,
    }
    
    /// <summary>
    /// >> 19 - Variant[zeitgeist_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumExt<RuntimeEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_scheduler.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_transaction_payment.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_treasury.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_vesting.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_multisig.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_bounties.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_asset_tx_payment.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_democracy.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_collective.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_membership.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_collective.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_membership.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_collective.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_membership.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_identity.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_utility.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_proxy.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_contracts.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_tokens.module.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_authorized.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_liquidity_mining.pallet.EnumEvent, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_simple_disputes.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_swaps.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_prediction_markets.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_styx.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_neo_swaps.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_orderbook.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_parimutuel.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_parachain_staking.pallet.EnumEvent, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_slot_filter.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.cumulus_pallet_xcm.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_asset_registry.module.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_unknown_tokens.module.EnumEvent, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_xtokens.module.EnumEvent>
    {
    }
}