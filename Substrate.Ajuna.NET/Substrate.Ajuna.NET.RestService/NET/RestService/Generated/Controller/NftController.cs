//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Ajuna.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Ajuna.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// NftController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class NftController : ControllerBase
    {
        
        private INftStorage _nftStorage;
        
        /// <summary>
        /// NftController constructor.
        /// </summary>
        public NftController(INftStorage nftStorage)
        {
            _nftStorage = nftStorage;
        }
        
        /// <summary>
        /// >> Collection
        ///  Details of a collection.
        /// </summary>
        [HttpGet("Collection")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.CollectionDetails), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "CollectionParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetCollection(string key)
        {
            return this.Ok(_nftStorage.GetCollection(key));
        }
        
        /// <summary>
        /// >> OwnershipAcceptance
        ///  The collection, if any, of which an account is willing to take ownership.
        /// </summary>
        [HttpGet("OwnershipAcceptance")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "OwnershipAcceptanceParams", typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetOwnershipAcceptance(string key)
        {
            return this.Ok(_nftStorage.GetOwnershipAcceptance(key));
        }
        
        /// <summary>
        /// >> Account
        ///  The items held by any given account; set out this way so that items owned by a single
        ///  account can be enumerated.
        /// </summary>
        [HttpGet("Account")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "AccountParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetAccount(string key)
        {
            return this.Ok(_nftStorage.GetAccount(key));
        }
        
        /// <summary>
        /// >> CollectionAccount
        ///  The collections owned by any given account; set out this way so that collections owned by
        ///  a single account can be enumerated.
        /// </summary>
        [HttpGet("CollectionAccount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "CollectionAccountParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetCollectionAccount(string key)
        {
            return this.Ok(_nftStorage.GetCollectionAccount(key));
        }
        
        /// <summary>
        /// >> CollectionRoleOf
        ///  The items in existence and their ownership details.
        ///  Stores collection roles as per account.
        /// </summary>
        [HttpGet("CollectionRoleOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT3), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "CollectionRoleOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetCollectionRoleOf(string key)
        {
            return this.Ok(_nftStorage.GetCollectionRoleOf(key));
        }
        
        /// <summary>
        /// >> Item
        ///  The items in existence and their ownership details.
        /// </summary>
        [HttpGet("Item")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.ItemDetails), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "ItemParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetItem(string key)
        {
            return this.Ok(_nftStorage.GetItem(key));
        }
        
        /// <summary>
        /// >> CollectionMetadataOf
        ///  Metadata of a collection.
        /// </summary>
        [HttpGet("CollectionMetadataOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.CollectionMetadata), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "CollectionMetadataOfParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetCollectionMetadataOf(string key)
        {
            return this.Ok(_nftStorage.GetCollectionMetadataOf(key));
        }
        
        /// <summary>
        /// >> ItemMetadataOf
        ///  Metadata of an item.
        /// </summary>
        [HttpGet("ItemMetadataOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.ItemMetadata), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "ItemMetadataOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetItemMetadataOf(string key)
        {
            return this.Ok(_nftStorage.GetItemMetadataOf(key));
        }
        
        /// <summary>
        /// >> Attribute
        ///  Attributes of a collection.
        /// </summary>
        [HttpGet("Attribute")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.AttributeDeposit>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "AttributeParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>))]
        public IActionResult GetAttribute(string key)
        {
            return this.Ok(_nftStorage.GetAttribute(key));
        }
        
        /// <summary>
        /// >> ItemPriceOf
        ///  A price of an item.
        /// </summary>
        [HttpGet("ItemPriceOf")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "ItemPriceOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetItemPriceOf(string key)
        {
            return this.Ok(_nftStorage.GetItemPriceOf(key));
        }
        
        /// <summary>
        /// >> ItemAttributesApprovalsOf
        ///  Item attribute approvals.
        /// </summary>
        [HttpGet("ItemAttributesApprovalsOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT2), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "ItemAttributesApprovalsOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetItemAttributesApprovalsOf(string key)
        {
            return this.Ok(_nftStorage.GetItemAttributesApprovalsOf(key));
        }
        
        /// <summary>
        /// >> NextCollectionId
        ///  Stores the `CollectionId` that is going to be used for the next collection.
        ///  This gets incremented whenever a new collection is created.
        /// </summary>
        [HttpGet("NextCollectionId")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "NextCollectionIdParams")]
        public IActionResult GetNextCollectionId()
        {
            return this.Ok(_nftStorage.GetNextCollectionId());
        }
        
        /// <summary>
        /// >> PendingSwapOf
        ///  Handles all the pending swaps.
        /// </summary>
        [HttpGet("PendingSwapOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.PendingSwap), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "PendingSwapOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetPendingSwapOf(string key)
        {
            return this.Ok(_nftStorage.GetPendingSwapOf(key));
        }
        
        /// <summary>
        /// >> CollectionConfigOf
        ///  Config of a collection.
        /// </summary>
        [HttpGet("CollectionConfigOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.CollectionConfig), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "CollectionConfigOfParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetCollectionConfigOf(string key)
        {
            return this.Ok(_nftStorage.GetCollectionConfigOf(key));
        }
        
        /// <summary>
        /// >> ItemConfigOf
        ///  Config of an item.
        /// </summary>
        [HttpGet("ItemConfigOf")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_nfts.types.ItemConfig), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftStorage), "ItemConfigOfParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetItemConfigOf(string key)
        {
            return this.Ok(_nftStorage.GetItemConfigOf(key));
        }
    }
}
