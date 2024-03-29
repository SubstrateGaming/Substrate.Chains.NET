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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet
{
    
    
    public enum Error
    {
        
        ErrorCreatingAsset = 0,
        
        AssetAlreadyExists = 1,
        
        AssetDoesNotExist = 2,
        
        TooLowNumAssetsWeightHint = 3,
        
        LocalAssetLimitReached = 4,
        
        ErrorDestroyingAsset = 5,
        
        NotSufficientDeposit = 6,
        
        NonExistentLocalAsset = 7,
    }
    
    /// <summary>
    /// >> 314 - Variant[pallet_asset_manager.pallet.Error]
    /// An error that can occur while executing the mapping pallet's logic.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
