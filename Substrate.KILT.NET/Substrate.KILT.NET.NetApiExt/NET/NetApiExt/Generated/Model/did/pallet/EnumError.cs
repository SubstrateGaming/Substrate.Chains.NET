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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.did.pallet
{
    
    
    public enum Error
    {
        
        InvalidSignatureFormat = 0,
        
        InvalidSignature = 1,
        
        AlreadyExists = 2,
        
        NotFound = 3,
        
        VerificationKeyNotFound = 4,
        
        InvalidNonce = 5,
        
        UnsupportedDidAuthorizationCall = 6,
        
        InvalidDidAuthorizationCall = 7,
        
        MaxNewKeyAgreementKeysLimitExceeded = 8,
        
        MaxPublicKeysExceeded = 9,
        
        MaxKeyAgreementKeysExceeded = 10,
        
        BadDidOrigin = 11,
        
        TransactionExpired = 12,
        
        AlreadyDeleted = 13,
        
        NotOwnerOfDeposit = 14,
        
        UnableToPayFees = 15,
        
        MaxNumberOfServicesExceeded = 16,
        
        MaxServiceIdLengthExceeded = 17,
        
        MaxServiceTypeLengthExceeded = 18,
        
        MaxNumberOfTypesPerServiceExceeded = 19,
        
        MaxServiceUrlLengthExceeded = 20,
        
        MaxNumberOfUrlsPerServiceExceeded = 21,
        
        ServiceAlreadyExists = 22,
        
        ServiceNotFound = 23,
        
        InvalidServiceEncoding = 24,
        
        MaxStoredEndpointsCountExceeded = 25,
        
        Internal = 26,
    }
    
    /// <summary>
    /// >> 436 - Variant[did.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
