//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Statemine.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.pallet_uniques.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IUniquesControllerClient
   {
      Task<CollectionDetails> GetClass(U32 key);
      Task<bool> SubscribeClass(U32 key);
      Task<U32> GetOwnershipAcceptance(Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeOwnershipAcceptance(Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BaseTuple> GetAccount(BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32, U32> key);
      Task<bool> SubscribeAccount(BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32, U32> key);
      Task<BaseTuple> GetClassAccount(BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32> key);
      Task<bool> SubscribeClassAccount(BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U32> key);
      Task<ItemDetails> GetAsset(BaseTuple<U32, U32> key);
      Task<bool> SubscribeAsset(BaseTuple<U32, U32> key);
      Task<CollectionMetadata> GetClassMetadataOf(U32 key);
      Task<bool> SubscribeClassMetadataOf(U32 key);
      Task<ItemMetadata> GetInstanceMetadataOf(BaseTuple<U32, U32> key);
      Task<bool> SubscribeInstanceMetadataOf(BaseTuple<U32, U32> key);
      Task<BaseTuple<BoundedVecT3, U128>> GetAttribute(BaseTuple<U32, BaseOpt<U32>, BoundedVecT2> key);
      Task<bool> SubscribeAttribute(BaseTuple<U32, BaseOpt<U32>, BoundedVecT2> key);
      Task<BaseTuple<U128, BaseOpt<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>> GetItemPriceOf(BaseTuple<U32, U32> key);
      Task<bool> SubscribeItemPriceOf(BaseTuple<U32, U32> key);
      Task<U32> GetCollectionMaxSupply(U32 key);
      Task<bool> SubscribeCollectionMaxSupply(U32 key);
   }
}