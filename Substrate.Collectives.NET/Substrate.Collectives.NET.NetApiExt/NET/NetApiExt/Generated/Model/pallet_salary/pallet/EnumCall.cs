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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_salary.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> init
        /// See [`Pallet::init`].
        /// </summary>
        init = 0,
        
        /// <summary>
        /// >> bump
        /// See [`Pallet::bump`].
        /// </summary>
        bump = 1,
        
        /// <summary>
        /// >> induct
        /// See [`Pallet::induct`].
        /// </summary>
        induct = 2,
        
        /// <summary>
        /// >> register
        /// See [`Pallet::register`].
        /// </summary>
        register = 3,
        
        /// <summary>
        /// >> payout
        /// See [`Pallet::payout`].
        /// </summary>
        payout = 4,
        
        /// <summary>
        /// >> payout_other
        /// See [`Pallet::payout_other`].
        /// </summary>
        payout_other = 5,
        
        /// <summary>
        /// >> check_payment
        /// See [`Pallet::check_payment`].
        /// </summary>
        check_payment = 6,
    }
    
    /// <summary>
    /// >> 259 - Variant[pallet_salary.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.init);
				AddTypeDecoder<BaseVoid>(Call.bump);
				AddTypeDecoder<BaseVoid>(Call.induct);
				AddTypeDecoder<BaseVoid>(Call.register);
				AddTypeDecoder<BaseVoid>(Call.payout);
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(Call.payout_other);
				AddTypeDecoder<BaseVoid>(Call.check_payment);
        }
    }
}
