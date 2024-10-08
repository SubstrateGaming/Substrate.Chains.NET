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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_fast_unstake.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> register_fast_unstake
        /// See [`Pallet::register_fast_unstake`].
        /// </summary>
        register_fast_unstake = 0,
        
        /// <summary>
        /// >> deregister
        /// See [`Pallet::deregister`].
        /// </summary>
        deregister = 1,
        
        /// <summary>
        /// >> control
        /// See [`Pallet::control`].
        /// </summary>
        control = 2,
    }
    
    /// <summary>
    /// >> 319 - Variant[pallet_fast_unstake.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.register_fast_unstake);
				AddTypeDecoder<BaseVoid>(Call.deregister);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.control);
        }
    }
}
