//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base;
   using Substrate.Polkadot.NET.RestClient.Generated.Interfaces;
   
   public sealed class AuctionsControllerClient : BaseClient, IAuctionsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AuctionsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetAuctionCounter()
      {
         return await SendRequestAsync<U32>(_httpClient, "auctions/auctioncounter");
      }
      public async Task<bool> SubscribeAuctionCounter()
      {
         return await _subscriptionClient.SubscribeAsync("Auctions.AuctionCounter");
      }
      public async Task<BaseTuple<U32, U32>> GetAuctionInfo()
      {
         return await SendRequestAsync<BaseTuple<U32, U32>>(_httpClient, "auctions/auctioninfo");
      }
      public async Task<bool> SubscribeAuctionInfo()
      {
         return await _subscriptionClient.SubscribeAsync("Auctions.AuctionInfo");
      }
      public async Task<U128> GetReservedAmounts(BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> key)
      {
         return await SendRequestAsync<U128>(_httpClient, "auctions/reservedamounts", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.AuctionsStorage.ReservedAmountsParams(key));
      }
      public async Task<bool> SubscribeReservedAmounts(BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> key)
      {
         return await _subscriptionClient.SubscribeAsync("Auctions.ReservedAmounts", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.AuctionsStorage.ReservedAmountsParams(key));
      }
      public async Task<Arr36BaseOpt> GetWinning(U32 key)
      {
         return await SendRequestAsync<Arr36BaseOpt>(_httpClient, "auctions/winning", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.AuctionsStorage.WinningParams(key));
      }
      public async Task<bool> SubscribeWinning(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Auctions.Winning", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.AuctionsStorage.WinningParams(key));
      }
   }
}
