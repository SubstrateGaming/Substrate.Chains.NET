//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Astar.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public interface IAuraControllerMockupClient
   {
      Task<bool> SetAuthorities(BoundedVecT10 value);
      Task<bool> SetCurrentSlot(Slot value);
   }
}
