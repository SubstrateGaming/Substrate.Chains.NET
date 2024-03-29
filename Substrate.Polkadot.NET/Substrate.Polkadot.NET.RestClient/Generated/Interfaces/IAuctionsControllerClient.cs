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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base;
   
   public interface IAuctionsControllerClient
   {
      Task<U32> GetAuctionCounter();
      Task<bool> SubscribeAuctionCounter();
      Task<BaseTuple<U32, U32>> GetAuctionInfo();
      Task<bool> SubscribeAuctionInfo();
      Task<U128> GetReservedAmounts(BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> key);
      Task<bool> SubscribeReservedAmounts(BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> key);
      Task<Arr36BaseOpt> GetWinning(U32 key);
      Task<bool> SubscribeWinning(U32 key);
   }
}
