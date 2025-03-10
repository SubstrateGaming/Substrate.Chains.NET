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


namespace Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_referrals.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> register_code
        /// See [`Pallet::register_code`].
        /// </summary>
        register_code = 0,
        
        /// <summary>
        /// >> link_code
        /// See [`Pallet::link_code`].
        /// </summary>
        link_code = 1,
        
        /// <summary>
        /// >> convert
        /// See [`Pallet::convert`].
        /// </summary>
        convert = 2,
        
        /// <summary>
        /// >> claim_rewards
        /// See [`Pallet::claim_rewards`].
        /// </summary>
        claim_rewards = 3,
        
        /// <summary>
        /// >> set_reward_percentage
        /// See [`Pallet::set_reward_percentage`].
        /// </summary>
        set_reward_percentage = 4,
    }
    
    /// <summary>
    /// >> 382 - Variant[pallet_referrals.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6>(Call.register_code);
				AddTypeDecoder<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6>(Call.link_code);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.convert);
				AddTypeDecoder<BaseVoid>(Call.claim_rewards);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_referrals.EnumLevel, Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_referrals.FeeDistribution>>(Call.set_reward_percentage);
        }
    }
}
