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


namespace Substrate.Gear.NET.NetApiExt.Generated.Model.pallet_gear_voucher.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> FailureToCreateVoucher
        /// </summary>
        FailureToCreateVoucher = 0,
        
        /// <summary>
        /// >> FailureToRedeemVoucher
        /// </summary>
        FailureToRedeemVoucher = 1,
    }
    
    /// <summary>
    /// >> 610 - Variant[pallet_gear_voucher.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}