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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_treasury;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface ITreasuryControllerClient
   {
      Task<U32> GetProposalCount();
      Task<bool> SubscribeProposalCount();
      Task<Proposal> GetProposals(U32 key);
      Task<bool> SubscribeProposals(U32 key);
      Task<U128> GetDeactivated();
      Task<bool> SubscribeDeactivated();
      Task<BoundedVecT24> GetApprovals();
      Task<bool> SubscribeApprovals();
   }
}