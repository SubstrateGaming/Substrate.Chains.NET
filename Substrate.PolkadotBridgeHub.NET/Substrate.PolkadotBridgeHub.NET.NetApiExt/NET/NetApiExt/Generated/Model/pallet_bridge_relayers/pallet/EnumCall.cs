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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.pallet_bridge_relayers.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> claim_rewards
        /// See [`Pallet::claim_rewards`].
        /// </summary>
        claim_rewards = 0,
        
        /// <summary>
        /// >> register
        /// See [`Pallet::register`].
        /// </summary>
        register = 1,
        
        /// <summary>
        /// >> deregister
        /// See [`Pallet::deregister`].
        /// </summary>
        deregister = 2,
    }
    
    /// <summary>
    /// >> 355 - Variant[pallet_bridge_relayers.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams>(Call.claim_rewards);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.register);
				AddTypeDecoder<BaseVoid>(Call.deregister);
        }
    }
}