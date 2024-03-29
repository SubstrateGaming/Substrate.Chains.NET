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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm.pallet
{
    
    
    public enum Error
    {
        
        BalanceLow = 0,
        
        FeeOverflow = 1,
        
        PaymentOverflow = 2,
        
        WithdrawFailed = 3,
        
        GasPriceTooLow = 4,
        
        InvalidNonce = 5,
        
        GasLimitTooLow = 6,
        
        GasLimitTooHigh = 7,
        
        Undefined = 8,
        
        Reentrancy = 9,
        
        TransactionMustComeFromEOA = 10,
    }
    
    /// <summary>
    /// >> 331 - Variant[pallet_evm.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
