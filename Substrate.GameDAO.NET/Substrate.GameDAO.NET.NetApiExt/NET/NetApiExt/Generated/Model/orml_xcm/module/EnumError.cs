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


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.orml_xcm.module
{
    
    
    /// <summary>
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> Unreachable
        /// The message and destination combination was not recognized as being
        /// reachable.
        /// </summary>
        Unreachable = 0,
        
        /// <summary>
        /// >> SendFailure
        /// The message and destination was recognized as being reachable but
        /// the operation could not be completed.
        /// </summary>
        SendFailure = 1,
        
        /// <summary>
        /// >> BadVersion
        /// The version of the `Versioned` value used is not able to be
        /// interpreted.
        /// </summary>
        BadVersion = 2,
    }
    
    /// <summary>
    /// >> 558 - Variant[orml_xcm.module.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}