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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_multi_token.types
{
    
    
    public enum CollectionSetting
    {
        
        TransferableItems = 1,
        
        UnlockedMetadata = 2,
        
        UnlockedAttributes = 4,
        
        UnlockedMaxSupply = 8,
        
        DepositRequired = 16,
    }
    
    /// <summary>
    /// >> 436 - Variant[pallet_multi_token.types.CollectionSetting]
    /// </summary>
    public sealed class EnumCollectionSetting : BaseEnum<CollectionSetting>
    {
    }
}