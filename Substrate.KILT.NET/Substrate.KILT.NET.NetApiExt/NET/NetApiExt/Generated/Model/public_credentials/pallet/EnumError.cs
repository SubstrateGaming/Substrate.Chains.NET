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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.pallet
{
    
    
    public enum Error
    {
        
        AlreadyAttested = 0,
        
        NotFound = 1,
        
        UnableToPayFees = 2,
        
        InvalidInput = 3,
        
        NotAuthorized = 4,
        
        Internal = 5,
    }
    
    /// <summary>
    /// >> 444 - Variant[public_credentials.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
