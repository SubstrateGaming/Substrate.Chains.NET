//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Enjin.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> MarketplaceStorage
    /// </summary>
    public sealed class MarketplaceStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> MarketplaceStorage Constructor
        /// </summary>
        public MarketplaceStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Marketplace", "Info"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.types.MarketPlaceInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Marketplace", "Listings"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.features.listing.Listing)));
        }
        
        /// <summary>
        /// >> InfoParams
        ///  Stores information about the marketplace
        /// </summary>
        public static string InfoParams()
        {
            return RequestGenerator.GetStorage("Marketplace", "Info", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InfoDefault
        /// Default value as hex string
        /// </summary>
        public static string InfoDefault()
        {
            return "0x02E1F505";
        }
        
        /// <summary>
        /// >> Info
        ///  Stores information about the marketplace
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.types.MarketPlaceInfo> Info(string blockhash, CancellationToken token)
        {
            string parameters = MarketplaceStorage.InfoParams();
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.types.MarketPlaceInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ListingsParams
        ///  Listings by ID
        /// </summary>
        public static string ListingsParams(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Marketplace", "Listings", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ListingsDefault
        /// Default value as hex string
        /// </summary>
        public static string ListingsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Listings
        ///  Listings by ID
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.features.listing.Listing> Listings(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = MarketplaceStorage.ListingsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.features.listing.Listing>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> MarketplaceCalls
    /// </summary>
    public sealed class MarketplaceCalls
    {
        
        /// <summary>
        /// >> create_listing
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateListing(Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId make_asset_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId take_asset_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> price, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 salt, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.features.auction.AuctionData> auction_data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(make_asset_id.Encode());
            byteArray.AddRange(take_asset_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(price.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(auction_data.Encode());
            return new Method(249, "Marketplace", 0, "create_listing", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_listing
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CancelListing(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 listing_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(listing_id.Encode());
            return new Method(249, "Marketplace", 1, "cancel_listing", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> fill_listing
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FillListing(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 listing_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(listing_id.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(249, "Marketplace", 2, "fill_listing", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> place_bid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PlaceBid(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 listing_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> price)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(listing_id.Encode());
            byteArray.AddRange(price.Encode());
            return new Method(249, "Marketplace", 3, "place_bid", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> finalize_auction
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FinalizeAuction(Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 listing_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(listing_id.Encode());
            return new Method(249, "Marketplace", 4, "finalize_auction", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_protocol_fee
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetProtocolFee(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill protocol_fee)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(protocol_fee.Encode());
            return new Method(249, "Marketplace", 5, "set_protocol_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_create_listing
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCreateListing(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress seller, Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId make_asset_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId take_asset_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> price, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 salt, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_marketplace.features.auction.AuctionData> auction_data, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress> deposit_backer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(seller.Encode());
            byteArray.AddRange(make_asset_id.Encode());
            byteArray.AddRange(take_asset_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(price.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(auction_data.Encode());
            byteArray.AddRange(deposit_backer.Encode());
            return new Method(249, "Marketplace", 6, "force_create_listing", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_place_bid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForcePlaceBid(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress bidder, Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256 listing_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> price, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress> funds_backer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(bidder.Encode());
            byteArray.AddRange(listing_id.Encode());
            byteArray.AddRange(price.Encode());
            byteArray.AddRange(funds_backer.Encode());
            return new Method(249, "Marketplace", 7, "force_place_bid", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> MarketplaceConstants
    /// </summary>
    public sealed class MarketplaceConstants
    {
        
        /// <summary>
        /// >> MinimumBidIncreasePercentage
        ///  The percentage the minimum bid in an auction must increase by
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill MinimumBidIncreasePercentage()
        {
            var result = new Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            result.Create("0x80F0FA02");
            return result;
        }
        
        /// <summary>
        /// >> ReserveIdentifier
        ///  ID used by the pallet for making reservations
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8 ReserveIdentifier()
        {
            var result = new Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8();
            result.Create("0x6D61726B74706C63");
            return result;
        }
        
        /// <summary>
        /// >> ListingDeposit
        ///  The deposit for creating a listing
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 ListingDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x009060B6DA2E07070000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ListingActiveDelay
        ///  The delay before a listing is considered active
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ListingActiveDelay()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x05000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxRoundingError
        ///  The max amount that can be lost due to rounding before failing
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MaxRoundingError()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0xE8030000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxSaltLength
        ///  Max length of salt used when creating listings and bids
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxSaltLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x20000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> MarketplaceErrors
    /// </summary>
    public enum MarketplaceErrors
    {
        
        /// <summary>
        /// >> UnableToFill
        /// the order cannot be filled
        /// </summary>
        UnableToFill,
        
        /// <summary>
        /// >> ListingNotFound
        /// The listing does not exist
        /// </summary>
        ListingNotFound,
        
        /// <summary>
        /// >> NoPermission
        /// The caller does not have permission for this operation
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> MaxRoundingErrorExceeded
        /// The max rounding error was exceeded
        /// </summary>
        MaxRoundingErrorExceeded,
        
        /// <summary>
        /// >> LowBaseCurrencyBalance
        /// The base currency balance is too low
        /// </summary>
        LowBaseCurrencyBalance,
        
        /// <summary>
        /// >> LowTokenBalance
        /// The token balance is too low
        /// </summary>
        LowTokenBalance,
        
        /// <summary>
        /// >> TransferParamCreationFailed
        /// Transfer params could not be created
        /// </summary>
        TransferParamCreationFailed,
        
        /// <summary>
        /// >> TakeValueUnderMinimum
        /// The take value is under the minimum requirement
        /// </summary>
        TakeValueUnderMinimum,
        
        /// <summary>
        /// >> ListingAlreadyExists
        /// A listing with this id already exists
        /// </summary>
        ListingAlreadyExists,
        
        /// <summary>
        /// >> InvalidAuctionStart
        /// The start time of the auction must be greater than the current block plus the
        /// minimum requirement
        /// </summary>
        InvalidAuctionStart,
        
        /// <summary>
        /// >> InvalidAuctionEnd
        /// The end time of the auction must be after the start
        /// </summary>
        InvalidAuctionEnd,
        
        /// <summary>
        /// >> InactiveAuction
        /// Cannot bid on an auction that has not started or is over
        /// </summary>
        InactiveAuction,
        
        /// <summary>
        /// >> AuctionNotOver
        /// Cannot finalize an auction that is not over
        /// </summary>
        AuctionNotOver,
        
        /// <summary>
        /// >> ListingIsWrongType
        /// An action was taken that is not compatible with the listing's type.
        /// </summary>
        ListingIsWrongType,
        
        /// <summary>
        /// >> InvalidAmount
        /// The amount is invalid
        /// </summary>
        InvalidAmount,
        
        /// <summary>
        /// >> InvalidPrice
        /// The price is invalid
        /// </summary>
        InvalidPrice,
        
        /// <summary>
        /// >> ListingForbidden
        /// Listing is forbidden for this token
        /// </summary>
        ListingForbidden,
        
        /// <summary>
        /// >> NoCurrency
        /// Neither the make side or the take side of the listing is considered a currency
        /// </summary>
        NoCurrency,
        
        /// <summary>
        /// >> ListingNotActive
        /// The listing has not crossed the mandatory delay before its considered active
        /// </summary>
        ListingNotActive,
        
        /// <summary>
        /// >> CurrencyNotAllowedAsRoyalty
        /// The currency is not allowed to be used as a royalty payment
        /// </summary>
        CurrencyNotAllowedAsRoyalty,
        
        /// <summary>
        /// >> BuyerIsSeller
        /// The seller is not allowed to buy their own listing
        /// </summary>
        BuyerIsSeller,
        
        /// <summary>
        /// >> MakeAssetFrozen
        /// Make asset is frozen
        /// </summary>
        MakeAssetFrozen,
        
        /// <summary>
        /// >> TakeAssetFrozen
        /// Take asset is frozen
        /// </summary>
        TakeAssetFrozen,
    }
}