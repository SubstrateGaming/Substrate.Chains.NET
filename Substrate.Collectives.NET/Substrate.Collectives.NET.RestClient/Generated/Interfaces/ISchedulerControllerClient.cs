//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Collectives.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   
   public interface ISchedulerControllerClient
   {
      Task<U32> GetIncompleteSince();
      Task<bool> SubscribeIncompleteSince();
      Task<BoundedVecT18> GetAgenda(U32 key);
      Task<bool> SubscribeAgenda(U32 key);
      Task<BaseTuple<U32, U32>> GetLookup(Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr32U8 key);
      Task<bool> SubscribeLookup(Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr32U8 key);
   }
}