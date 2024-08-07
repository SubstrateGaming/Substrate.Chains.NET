//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_nomination_pools;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface INominationPoolsControllerClient
   {
      Task<U128> GetTotalValueLocked();
      Task<bool> SubscribeTotalValueLocked();
      Task<U128> GetMinJoinBond();
      Task<bool> SubscribeMinJoinBond();
      Task<U128> GetMinCreateBond();
      Task<bool> SubscribeMinCreateBond();
      Task<U32> GetMaxPools();
      Task<bool> SubscribeMaxPools();
      Task<U32> GetMaxPoolMembers();
      Task<bool> SubscribeMaxPoolMembers();
      Task<U32> GetMaxPoolMembersPerPool();
      Task<bool> SubscribeMaxPoolMembersPerPool();
      Task<Perbill> GetGlobalMaxCommission();
      Task<bool> SubscribeGlobalMaxCommission();
      Task<PoolMember> GetPoolMembers(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribePoolMembers(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<U32> GetCounterForPoolMembers();
      Task<bool> SubscribeCounterForPoolMembers();
      Task<BondedPoolInner> GetBondedPools(U32 key);
      Task<bool> SubscribeBondedPools(U32 key);
      Task<U32> GetCounterForBondedPools();
      Task<bool> SubscribeCounterForBondedPools();
      Task<RewardPool> GetRewardPools(U32 key);
      Task<bool> SubscribeRewardPools(U32 key);
      Task<U32> GetCounterForRewardPools();
      Task<bool> SubscribeCounterForRewardPools();
      Task<SubPools> GetSubPoolsStorage(U32 key);
      Task<bool> SubscribeSubPoolsStorage(U32 key);
      Task<U32> GetCounterForSubPoolsStorage();
      Task<bool> SubscribeCounterForSubPoolsStorage();
      Task<BoundedVecT41> GetMetadata(U32 key);
      Task<bool> SubscribeMetadata(U32 key);
      Task<U32> GetCounterForMetadata();
      Task<bool> SubscribeCounterForMetadata();
      Task<U32> GetLastPoolId();
      Task<bool> SubscribeLastPoolId();
      Task<U32> GetReversePoolIdLookup(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeReversePoolIdLookup(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<U32> GetCounterForReversePoolIdLookup();
      Task<bool> SubscribeCounterForReversePoolIdLookup();
      Task<EnumClaimPermission> GetClaimPermissions(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeClaimPermissions(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
