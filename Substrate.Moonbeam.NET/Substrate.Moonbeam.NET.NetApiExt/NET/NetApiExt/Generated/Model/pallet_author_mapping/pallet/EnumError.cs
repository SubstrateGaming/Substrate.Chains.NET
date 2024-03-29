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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet
{
    
    
    public enum Error
    {
        
        AssociationNotFound = 0,
        
        NotYourAssociation = 1,
        
        CannotAffordSecurityDeposit = 2,
        
        AlreadyAssociated = 3,
        
        OldAuthorIdNotFound = 4,
        
        WrongKeySize = 5,
        
        DecodeNimbusFailed = 6,
        
        DecodeKeysFailed = 7,
    }
    
    /// <summary>
    /// >> 246 - Variant[pallet_author_mapping.pallet.Error]
    /// An error that can occur while executing the mapping pallet's logic.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
