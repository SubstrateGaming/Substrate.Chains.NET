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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.pallet
{
    
    
    public enum Error
    {
        
        NftAlreadyExists = 0,
        
        RoyaltyRateIsNotValid = 1,
        
        TotalRoyaltyRateIsNotValid = 2,
        
        T1AuthorityIsMandatory = 3,
        
        ExternalRefIsMandatory = 4,
        
        ExternalRefIsAlreadyInUse = 5,
        
        NftInfoMissing = 6,
        
        NftIdDoesNotExist = 7,
        
        UnsupportedMarket = 8,
        
        SenderIsNotSigner = 9,
        
        SenderIsNotOwner = 10,
        
        NftAlreadyListed = 11,
        
        NftIsLocked = 12,
        
        NftNotListedForSale = 13,
        
        NftNotListedForEthereumSale = 14,
        
        NftNotListedForFiatSale = 15,
        
        NoTier1EventForNftOperation = 16,
        
        NftNonceMismatch = 17,
        
        UnauthorizedTransaction = 18,
        
        UnauthorizedProxyTransaction = 19,
        
        UnauthorizedSignedLiftNftOpenForSaleTransaction = 20,
        
        UnauthorizedSignedMintSingleNftTransaction = 21,
        
        UnauthorizedSignedTransferFiatNftTransaction = 22,
        
        UnauthorizedSignedCancelListFiatNftTransaction = 23,
        
        TransactionNotSupported = 24,
        
        TransferToIsMandatory = 25,
        
        UnauthorizedSignedCreateBatchTransaction = 26,
        
        BatchAlreadyExists = 27,
        
        TotalSupplyZero = 28,
        
        UnauthorizedSignedMintBatchNftTransaction = 29,
        
        BatchIdIsMandatory = 30,
        
        BatchDoesNotExist = 31,
        
        SenderIsNotBatchCreator = 32,
        
        TotalSupplyExceeded = 33,
        
        UnauthorizedSignedListBatchForSaleTransaction = 34,
        
        BatchAlreadyListed = 35,
        
        NoNftsToSell = 36,
        
        BatchNotListed = 37,
        
        UnauthorizedSignedEndBatchSaleTransaction = 38,
        
        BatchNotListedForFiatSale = 39,
        
        BatchNotListedForEthereumSale = 40,
    }
    
    /// <summary>
    /// >> 408 - Variant[pallet_nft_manager.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}