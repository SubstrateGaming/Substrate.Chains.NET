//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar;
   
   public interface IRegistrarControllerMockupClient
   {
      Task<bool> SetPendingSwap(Id value, Id key);
      Task<bool> SetParas(ParaInfo value, Id key);
      Task<bool> SetNextFreeParaId(Id value);
   }
}
