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


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.subzero_runtime
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
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 1,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 4,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 5,
        
        /// <summary>
        /// >> Council
        /// </summary>
        Council = 6,
        
        /// <summary>
        /// >> TechnicalCommittee
        /// </summary>
        TechnicalCommittee = 7,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 8,
        
        /// <summary>
        /// >> Bounties
        /// </summary>
        Bounties = 9,
        
        /// <summary>
        /// >> ChildBounties
        /// </summary>
        ChildBounties = 10,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 11,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 12,
        
        /// <summary>
        /// >> Sudo
        /// </summary>
        Sudo = 13,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 14,
        
        /// <summary>
        /// >> Democracy
        /// </summary>
        Democracy = 15,
        
        /// <summary>
        /// >> Elections
        /// </summary>
        Elections = 16,
        
        /// <summary>
        /// >> TechnicalMembership
        /// </summary>
        TechnicalMembership = 17,
        
        /// <summary>
        /// >> Contracts
        /// </summary>
        Contracts = 19,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 20,
        
        /// <summary>
        /// >> Tips
        /// </summary>
        Tips = 21,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 22,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 23,
        
        /// <summary>
        /// >> Nfts
        /// </summary>
        Nfts = 34,
        
        /// <summary>
        /// >> CollatorSelection
        /// </summary>
        CollatorSelection = 41,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 42,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 50,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 51,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 52,
        
        /// <summary>
        /// >> DmpQueue
        /// </summary>
        DmpQueue = 53,
        
        /// <summary>
        /// >> AssetRegistry
        /// </summary>
        AssetRegistry = 60,
        
        /// <summary>
        /// >> OrmlXcm
        /// </summary>
        OrmlXcm = 62,
        
        /// <summary>
        /// >> Tokens
        /// </summary>
        Tokens = 63,
        
        /// <summary>
        /// >> UnknownTokens
        /// </summary>
        UnknownTokens = 64,
        
        /// <summary>
        /// >> XTokens
        /// </summary>
        XTokens = 65,
        
        /// <summary>
        /// >> Flow
        /// </summary>
        Flow = 70,
        
        /// <summary>
        /// >> Sense
        /// </summary>
        Sense = 71,
        
        /// <summary>
        /// >> Control
        /// </summary>
        Control = 72,
        
        /// <summary>
        /// >> Signal
        /// </summary>
        Signal = 73,
        
        /// <summary>
        /// >> Battlepass
        /// </summary>
        Battlepass = 74,
    }
    
    /// <summary>
    /// >> 19 - Variant[subzero_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumExt<RuntimeEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumEvent, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_utility.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_multisig.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_collective.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_collective.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_identity.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_bounties.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_child_bounties.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_scheduler.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_proxy.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_democracy.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_elections_phragmen.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_membership.pallet.EnumEvent, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_contracts.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_treasury.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_tips.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_transaction_payment.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_nfts.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_session.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.cumulus_pallet_xcm.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_asset_registry.module.EnumEvent, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_xcm.module.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_tokens.module.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_unknown_tokens.module.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_xtokens.module.EnumEvent, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_control.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_signal.pallet.EnumEvent, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_battlepass.pallet.EnumEvent>
    {
    }
}