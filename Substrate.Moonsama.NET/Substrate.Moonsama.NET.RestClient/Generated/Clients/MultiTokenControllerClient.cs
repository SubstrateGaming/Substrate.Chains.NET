//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_multi_token.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set;
   using Substrate.Moonsama.NET.RestClient.Generated.Interfaces;
   
   public sealed class MultiTokenControllerClient : BaseClient, IMultiTokenControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public MultiTokenControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<CollectionDetails> GetCollection(U128 key)
      {
         return await SendRequestAsync<CollectionDetails>(_httpClient, "multitoken/collection", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionParams(key));
      }
      public async Task<bool> SubscribeCollection(U128 key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Collection", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionParams(key));
      }
      public async Task<U128> GetOwnershipAcceptance(AccountId20 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "multitoken/ownershipacceptance", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.OwnershipAcceptanceParams(key));
      }
      public async Task<bool> SubscribeOwnershipAcceptance(AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.OwnershipAcceptance", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.OwnershipAcceptanceParams(key));
      }
      public async Task<AccountData> GetAccount(BaseTuple<AccountId20, U128, U128> key)
      {
         return await SendRequestAsync<AccountData>(_httpClient, "multitoken/account", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(BaseTuple<AccountId20, U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Account", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.AccountParams(key));
      }
      public async Task<BoundedVecT29> GetHolds(BaseTuple<AccountId20, U128, U128> key)
      {
         return await SendRequestAsync<BoundedVecT29>(_httpClient, "multitoken/holds", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.HoldsParams(key));
      }
      public async Task<bool> SubscribeHolds(BaseTuple<AccountId20, U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Holds", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.HoldsParams(key));
      }
      public async Task<AccountId20> GetNftOwners(BaseTuple<U128, U128> key)
      {
         return await SendRequestAsync<AccountId20>(_httpClient, "multitoken/nftowners", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.NftOwnersParams(key));
      }
      public async Task<bool> SubscribeNftOwners(BaseTuple<U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.NftOwners", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.NftOwnersParams(key));
      }
      public async Task<BaseTuple> GetCollectionAccount(BaseTuple<AccountId20, U128> key)
      {
         return await SendRequestAsync<BaseTuple>(_httpClient, "multitoken/collectionaccount", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionAccountParams(key));
      }
      public async Task<bool> SubscribeCollectionAccount(BaseTuple<AccountId20, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.CollectionAccount", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionAccountParams(key));
      }
      public async Task<BitFlagsT3> GetCollectionRoleOf(BaseTuple<U128, AccountId20> key)
      {
         return await SendRequestAsync<BitFlagsT3>(_httpClient, "multitoken/collectionroleof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionRoleOfParams(key));
      }
      public async Task<bool> SubscribeCollectionRoleOf(BaseTuple<U128, AccountId20> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.CollectionRoleOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionRoleOfParams(key));
      }
      public async Task<ItemDetails> GetItem(BaseTuple<U128, U128> key)
      {
         return await SendRequestAsync<ItemDetails>(_httpClient, "multitoken/item", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemParams(key));
      }
      public async Task<bool> SubscribeItem(BaseTuple<U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Item", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemParams(key));
      }
      public async Task<CollectionMetadata> GetCollectionMetadataOf(U128 key)
      {
         return await SendRequestAsync<CollectionMetadata>(_httpClient, "multitoken/collectionmetadataof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionMetadataOfParams(key));
      }
      public async Task<bool> SubscribeCollectionMetadataOf(U128 key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.CollectionMetadataOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionMetadataOfParams(key));
      }
      public async Task<ItemMetadata> GetItemMetadataOf(BaseTuple<U128, U128> key)
      {
         return await SendRequestAsync<ItemMetadata>(_httpClient, "multitoken/itemmetadataof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemMetadataOfParams(key));
      }
      public async Task<bool> SubscribeItemMetadataOf(BaseTuple<U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.ItemMetadataOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemMetadataOfParams(key));
      }
      public async Task<BaseTuple<BoundedVecT6, AttributeDeposit>> GetAttribute(BaseTuple<U128, BaseOpt<U128>, EnumAttributeNamespace, BoundedVecT5> key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT6, AttributeDeposit>>(_httpClient, "multitoken/attribute", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.AttributeParams(key));
      }
      public async Task<bool> SubscribeAttribute(BaseTuple<U128, BaseOpt<U128>, EnumAttributeNamespace, BoundedVecT5> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Attribute", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.AttributeParams(key));
      }
      public async Task<BoundedBTreeSet> GetItemAttributesApprovalsOf(BaseTuple<U128, U128> key)
      {
         return await SendRequestAsync<BoundedBTreeSet>(_httpClient, "multitoken/itemattributesapprovalsof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemAttributesApprovalsOfParams(key));
      }
      public async Task<bool> SubscribeItemAttributesApprovalsOf(BaseTuple<U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.ItemAttributesApprovalsOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemAttributesApprovalsOfParams(key));
      }
      public async Task<U128> GetNextCollectionId()
      {
         return await SendRequestAsync<U128>(_httpClient, "multitoken/nextcollectionid");
      }
      public async Task<bool> SubscribeNextCollectionId()
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.NextCollectionId");
      }
      public async Task<U128> GetNextItemId(U128 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "multitoken/nextitemid", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.NextItemIdParams(key));
      }
      public async Task<bool> SubscribeNextItemId(U128 key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.NextItemId", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.NextItemIdParams(key));
      }
      public async Task<CollectionConfig> GetCollectionConfigOf(U128 key)
      {
         return await SendRequestAsync<CollectionConfig>(_httpClient, "multitoken/collectionconfigof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionConfigOfParams(key));
      }
      public async Task<bool> SubscribeCollectionConfigOf(U128 key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.CollectionConfigOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.CollectionConfigOfParams(key));
      }
      public async Task<ItemConfig> GetItemConfigOf(BaseTuple<U128, U128> key)
      {
         return await SendRequestAsync<ItemConfig>(_httpClient, "multitoken/itemconfigof", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemConfigOfParams(key));
      }
      public async Task<bool> SubscribeItemConfigOf(BaseTuple<U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.ItemConfigOf", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ItemConfigOfParams(key));
      }
      public async Task<BaseTuple<BaseOpt<U32>, U128>> GetApprovals(BaseTuple<U128, U128, AccountId20, AccountId20> key)
      {
         return await SendRequestAsync<BaseTuple<BaseOpt<U32>, U128>>(_httpClient, "multitoken/approvals", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ApprovalsParams(key));
      }
      public async Task<bool> SubscribeApprovals(BaseTuple<U128, U128, AccountId20, AccountId20> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.Approvals", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ApprovalsParams(key));
      }
      public async Task<Bool> GetApprovalsForAll(BaseTuple<AccountId20, AccountId20> key)
      {
         return await SendRequestAsync<Bool>(_httpClient, "multitoken/approvalsforall", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ApprovalsForAllParams(key));
      }
      public async Task<bool> SubscribeApprovalsForAll(BaseTuple<AccountId20, AccountId20> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.ApprovalsForAll", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.ApprovalsForAllParams(key));
      }
      public async Task<Bool> GetSoulboundPermissionedDestination(BaseTuple<AccountId20, U128, U128> key)
      {
         return await SendRequestAsync<Bool>(_httpClient, "multitoken/soulboundpermissioneddestination", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.SoulboundPermissionedDestinationParams(key));
      }
      public async Task<bool> SubscribeSoulboundPermissionedDestination(BaseTuple<AccountId20, U128, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.SoulboundPermissionedDestination", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.SoulboundPermissionedDestinationParams(key));
      }
      public async Task<AllowedAsSourceOrDest> GetSoulboundGlobalPermissioned(BaseTuple<AccountId20, U128> key)
      {
         return await SendRequestAsync<AllowedAsSourceOrDest>(_httpClient, "multitoken/soulboundglobalpermissioned", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.SoulboundGlobalPermissionedParams(key));
      }
      public async Task<bool> SubscribeSoulboundGlobalPermissioned(BaseTuple<AccountId20, U128> key)
      {
         return await _subscriptionClient.SubscribeAsync("MultiToken.SoulboundGlobalPermissioned", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.MultiTokenStorage.SoulboundGlobalPermissionedParams(key));
      }
   }
}
