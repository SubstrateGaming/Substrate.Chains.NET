//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_coretime;
   
   public interface ICoretimeAssignmentProviderControllerMockupClient
   {
      Task<bool> SetCoreSchedules(Schedule value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.CoreIndex> key);
      Task<bool> SetCoreDescriptors(CoreDescriptor value, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.CoreIndex key);
   }
}