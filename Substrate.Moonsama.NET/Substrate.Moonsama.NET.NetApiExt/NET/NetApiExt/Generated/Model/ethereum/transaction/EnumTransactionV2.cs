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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction
{
    
    
    public enum TransactionV2
    {
        
        Legacy = 0,
        
        EIP2930 = 1,
        
        EIP1559 = 2,
    }
    
    /// <summary>
    /// >> 334 - Variant[ethereum.transaction.TransactionV2]
    /// </summary>
    public sealed class EnumTransactionV2 : BaseEnumExt<TransactionV2, Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.LegacyTransaction, Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.EIP2930Transaction, Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.EIP1559Transaction>
    {
    }
}