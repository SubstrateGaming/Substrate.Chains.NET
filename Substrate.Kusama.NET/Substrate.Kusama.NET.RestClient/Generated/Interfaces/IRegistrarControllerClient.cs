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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar;
   
   public interface IRegistrarControllerClient
   {
      Task<Id> GetPendingSwap(Id key);
      Task<bool> SubscribePendingSwap(Id key);
      Task<ParaInfo> GetParas(Id key);
      Task<bool> SubscribeParas(Id key);
      Task<Id> GetNextFreeParaId();
      Task<bool> SubscribeNextFreeParaId();
   }
}