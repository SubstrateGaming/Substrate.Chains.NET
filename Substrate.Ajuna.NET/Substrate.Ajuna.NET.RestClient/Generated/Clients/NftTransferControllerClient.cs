//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_transfer.pallet;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class NftTransferControllerClient : BaseClient, INftTransferControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public NftTransferControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<EnumNftStatus> GetNftStatuses(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256> key)
      {
         return await SendRequestAsync<EnumNftStatus>(_httpClient, "nfttransfer/nftstatuses", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftTransferStorage.NftStatusesParams(key));
      }
      public async Task<bool> SubscribeNftStatuses(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256> key)
      {
         return await _subscriptionClient.SubscribeAsync("NftTransfer.NftStatuses", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.NftTransferStorage.NftStatusesParams(key));
      }
   }
}