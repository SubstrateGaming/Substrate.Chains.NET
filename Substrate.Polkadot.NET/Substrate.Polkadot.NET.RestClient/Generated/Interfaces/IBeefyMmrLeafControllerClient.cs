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
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_beefy.mmr;
   
   public interface IBeefyMmrLeafControllerClient
   {
      Task<BeefyAuthoritySet> GetBeefyAuthorities();
      Task<bool> SubscribeBeefyAuthorities();
      Task<BeefyAuthoritySet> GetBeefyNextAuthorities();
      Task<bool> SubscribeBeefyNextAuthorities();
   }
}
