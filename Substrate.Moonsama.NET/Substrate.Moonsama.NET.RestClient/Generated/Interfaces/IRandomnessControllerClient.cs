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
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_randomness.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types;
   
   public interface IRandomnessControllerClient
   {
      Task<RequestState> GetRequests(U64 key);
      Task<bool> SubscribeRequests(U64 key);
      Task<U64> GetRequestCount();
      Task<bool> SubscribeRequestCount();
      Task<BaseOpt<H256>> GetLocalVrfOutput();
      Task<bool> SubscribeLocalVrfOutput();
      Task<U64> GetRelayEpoch();
      Task<bool> SubscribeRelayEpoch();
      Task<BaseTuple> GetInherentIncluded();
      Task<bool> SubscribeInherentIncluded();
      Task<BaseTuple> GetNotFirstBlock();
      Task<bool> SubscribeNotFirstBlock();
      Task<RandomnessResult> GetRandomnessResults(EnumRequestType key);
      Task<bool> SubscribeRandomnessResults(EnumRequestType key);
      Task<H256> GetPreviousLocalVrfOutput();
      Task<bool> SubscribePreviousLocalVrfOutput();
   }
}
