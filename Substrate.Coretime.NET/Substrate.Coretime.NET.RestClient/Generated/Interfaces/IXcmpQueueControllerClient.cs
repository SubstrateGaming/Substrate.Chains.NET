//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Coretime.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   
   public interface IXcmpQueueControllerClient
   {
      Task<BoundedBTreeSet> GetInboundXcmpSuspended();
      Task<bool> SubscribeInboundXcmpSuspended();
      Task<BoundedVecT11> GetOutboundXcmpStatus();
      Task<bool> SubscribeOutboundXcmpStatus();
      Task<WeakBoundedVecT3> GetOutboundXcmpMessages(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, U16> key);
      Task<bool> SubscribeOutboundXcmpMessages(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, U16> key);
      Task<WeakBoundedVecT3> GetSignalMessages(Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SubscribeSignalMessages(Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<QueueConfigData> GetQueueConfig();
      Task<bool> SubscribeQueueConfig();
      Task<Bool> GetQueueSuspended();
      Task<bool> SubscribeQueueSuspended();
      Task<FixedU128> GetDeliveryFeeFactor(Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SubscribeDeliveryFeeFactor(Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
   }
}