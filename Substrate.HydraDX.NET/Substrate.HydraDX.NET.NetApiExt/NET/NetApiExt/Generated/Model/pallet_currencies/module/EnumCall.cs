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


namespace Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_currencies.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> transfer
        /// See [`Pallet::transfer`].
        /// </summary>
        transfer = 0,
        
        /// <summary>
        /// >> transfer_native_currency
        /// See [`Pallet::transfer_native_currency`].
        /// </summary>
        transfer_native_currency = 1,
        
        /// <summary>
        /// >> update_balance
        /// See [`Pallet::update_balance`].
        /// </summary>
        update_balance = 2,
    }
    
    /// <summary>
    /// >> 384 - Variant[pallet_currencies.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.transfer);
				AddTypeDecoder<BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.transfer_native_currency);
				AddTypeDecoder<BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.I128>>(Call.update_balance);
        }
    }
}
