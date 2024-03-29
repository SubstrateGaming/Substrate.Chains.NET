//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   
   public interface IDmpControllerClient
   {
      Task<BaseVec<InboundDownwardMessage>> GetDownwardMessageQueues(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SubscribeDownwardMessageQueues(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<H256> GetDownwardMessageQueueHeads(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SubscribeDownwardMessageQueueHeads(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<FixedU128> GetDeliveryFeeFactor(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
      Task<bool> SubscribeDeliveryFeeFactor(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key);
   }
}
