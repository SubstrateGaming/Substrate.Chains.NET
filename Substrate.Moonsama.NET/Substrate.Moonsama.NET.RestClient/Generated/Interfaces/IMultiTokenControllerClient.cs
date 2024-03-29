//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_multi_token.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set;
   
   public interface IMultiTokenControllerClient
   {
      Task<CollectionDetails> GetCollection(U128 key);
      Task<bool> SubscribeCollection(U128 key);
      Task<U128> GetOwnershipAcceptance(AccountId20 key);
      Task<bool> SubscribeOwnershipAcceptance(AccountId20 key);
      Task<AccountData> GetAccount(BaseTuple<AccountId20, U128, U128> key);
      Task<bool> SubscribeAccount(BaseTuple<AccountId20, U128, U128> key);
      Task<BoundedVecT29> GetHolds(BaseTuple<AccountId20, U128, U128> key);
      Task<bool> SubscribeHolds(BaseTuple<AccountId20, U128, U128> key);
      Task<AccountId20> GetNftOwners(BaseTuple<U128, U128> key);
      Task<bool> SubscribeNftOwners(BaseTuple<U128, U128> key);
      Task<BaseTuple> GetCollectionAccount(BaseTuple<AccountId20, U128> key);
      Task<bool> SubscribeCollectionAccount(BaseTuple<AccountId20, U128> key);
      Task<BitFlagsT3> GetCollectionRoleOf(BaseTuple<U128, AccountId20> key);
      Task<bool> SubscribeCollectionRoleOf(BaseTuple<U128, AccountId20> key);
      Task<ItemDetails> GetItem(BaseTuple<U128, U128> key);
      Task<bool> SubscribeItem(BaseTuple<U128, U128> key);
      Task<CollectionMetadata> GetCollectionMetadataOf(U128 key);
      Task<bool> SubscribeCollectionMetadataOf(U128 key);
      Task<ItemMetadata> GetItemMetadataOf(BaseTuple<U128, U128> key);
      Task<bool> SubscribeItemMetadataOf(BaseTuple<U128, U128> key);
      Task<BaseTuple<BoundedVecT6, AttributeDeposit>> GetAttribute(BaseTuple<U128, BaseOpt<U128>, EnumAttributeNamespace, BoundedVecT5> key);
      Task<bool> SubscribeAttribute(BaseTuple<U128, BaseOpt<U128>, EnumAttributeNamespace, BoundedVecT5> key);
      Task<BoundedBTreeSet> GetItemAttributesApprovalsOf(BaseTuple<U128, U128> key);
      Task<bool> SubscribeItemAttributesApprovalsOf(BaseTuple<U128, U128> key);
      Task<U128> GetNextCollectionId();
      Task<bool> SubscribeNextCollectionId();
      Task<U128> GetNextItemId(U128 key);
      Task<bool> SubscribeNextItemId(U128 key);
      Task<CollectionConfig> GetCollectionConfigOf(U128 key);
      Task<bool> SubscribeCollectionConfigOf(U128 key);
      Task<ItemConfig> GetItemConfigOf(BaseTuple<U128, U128> key);
      Task<bool> SubscribeItemConfigOf(BaseTuple<U128, U128> key);
      Task<BaseTuple<BaseOpt<U32>, U128>> GetApprovals(BaseTuple<U128, U128, AccountId20, AccountId20> key);
      Task<bool> SubscribeApprovals(BaseTuple<U128, U128, AccountId20, AccountId20> key);
      Task<Bool> GetApprovalsForAll(BaseTuple<AccountId20, AccountId20> key);
      Task<bool> SubscribeApprovalsForAll(BaseTuple<AccountId20, AccountId20> key);
      Task<Bool> GetSoulboundPermissionedDestination(BaseTuple<AccountId20, U128, U128> key);
      Task<bool> SubscribeSoulboundPermissionedDestination(BaseTuple<AccountId20, U128, U128> key);
      Task<AllowedAsSourceOrDest> GetSoulboundGlobalPermissioned(BaseTuple<AccountId20, U128> key);
      Task<bool> SubscribeSoulboundGlobalPermissioned(BaseTuple<AccountId20, U128> key);
   }
}
