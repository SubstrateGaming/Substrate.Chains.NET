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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> propose
        /// Add a new proposal to be voted on.
        /// 
        /// Must be called by a Fellow.
        /// </summary>
        propose = 0,
        
        /// <summary>
        /// >> vote
        /// Add an aye or nay vote for the sender to the given proposal.
        /// 
        /// Must be called by a Fellow.
        /// </summary>
        vote = 1,
        
        /// <summary>
        /// >> init_members
        /// Initialize the Alliance, onboard fellows and allies.
        /// 
        /// The Alliance must be empty, and the call must provide some founding members.
        /// 
        /// Must be called by the Root origin.
        /// </summary>
        init_members = 3,
        
        /// <summary>
        /// >> disband
        /// Disband the Alliance, remove all active members and unreserve deposits.
        /// 
        /// Witness data must be set.
        /// </summary>
        disband = 4,
        
        /// <summary>
        /// >> set_rule
        /// Set a new IPFS CID to the alliance rule.
        /// </summary>
        set_rule = 5,
        
        /// <summary>
        /// >> announce
        /// Make an announcement of a new IPFS CID about alliance issues.
        /// </summary>
        announce = 6,
        
        /// <summary>
        /// >> remove_announcement
        /// Remove an announcement.
        /// </summary>
        remove_announcement = 7,
        
        /// <summary>
        /// >> join_alliance
        /// Submit oneself for candidacy. A fixed deposit is reserved.
        /// </summary>
        join_alliance = 8,
        
        /// <summary>
        /// >> nominate_ally
        /// A Fellow can nominate someone to join the alliance as an Ally. There is no deposit
        /// required from the nominator or nominee.
        /// </summary>
        nominate_ally = 9,
        
        /// <summary>
        /// >> elevate_ally
        /// Elevate an Ally to Fellow.
        /// </summary>
        elevate_ally = 10,
        
        /// <summary>
        /// >> give_retirement_notice
        /// As a member, give a retirement notice and start a retirement period required to pass in
        /// order to retire.
        /// </summary>
        give_retirement_notice = 11,
        
        /// <summary>
        /// >> retire
        /// As a member, retire from the Alliance and unreserve the deposit.
        /// 
        /// This can only be done once you have called `give_retirement_notice` and the
        /// `RetirementPeriod` has passed.
        /// </summary>
        retire = 12,
        
        /// <summary>
        /// >> kick_member
        /// Kick a member from the Alliance and slash its deposit.
        /// </summary>
        kick_member = 13,
        
        /// <summary>
        /// >> add_unscrupulous_items
        /// Add accounts or websites to the list of unscrupulous items.
        /// </summary>
        add_unscrupulous_items = 14,
        
        /// <summary>
        /// >> remove_unscrupulous_items
        /// Deem some items no longer unscrupulous.
        /// </summary>
        remove_unscrupulous_items = 15,
        
        /// <summary>
        /// >> close
        /// Close a vote that is either approved, disapproved, or whose voting period has ended.
        /// 
        /// Must be called by a Fellow.
        /// </summary>
        close = 16,
        
        /// <summary>
        /// >> abdicate_fellow_status
        /// Abdicate one's position as a voting member and just be an Ally. May be used by Fellows
        /// who do not want to leave the Alliance but do not have the capacity to participate
        /// operationally for some time.
        /// </summary>
        abdicate_fellow_status = 17,
    }
    
    /// <summary>
    /// >> 241 - Variant[pallet_alliance.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Collectives.NET.NetApiExt.Generated.Model.collectives_polkadot_runtime.EnumRuntimeCall, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.propose);
				AddTypeDecoder<BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.vote);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Call.init_members);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.DisbandWitness>(Call.disband);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid>(Call.set_rule);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid>(Call.announce);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid>(Call.remove_announcement);
				AddTypeDecoder<BaseVoid>(Call.join_alliance);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.nominate_ally);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.elevate_ally);
				AddTypeDecoder<BaseVoid>(Call.give_retirement_notice);
				AddTypeDecoder<BaseVoid>(Call.retire);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.kick_member);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.EnumUnscrupulousItem>>(Call.add_unscrupulous_items);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.EnumUnscrupulousItem>>(Call.remove_unscrupulous_items);
				AddTypeDecoder<BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.close);
				AddTypeDecoder<BaseVoid>(Call.abdicate_fellow_status);
        }
    }
}
