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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_scheduler.pallet
{
    
    
    public enum Error
    {
        
        FailedToSchedule = 0,
        
        NotFound = 1,
        
        TargetBlockNumberInPast = 2,
        
        RescheduleNoChange = 3,
        
        Named = 4,
    }
    
    /// <summary>
    /// >> 296 - Variant[pallet_scheduler.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}