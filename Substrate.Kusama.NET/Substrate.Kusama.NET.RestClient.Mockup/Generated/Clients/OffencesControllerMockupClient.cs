//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_staking.offence;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class OffencesControllerMockupClient : MockupBaseClient, IOffencesControllerMockupClient
   {
      private HttpClient _httpClient;
      public OffencesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetReports(OffenceDetails value, H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Offences/Reports", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OffencesStorage.ReportsParams(key));
      }
      public async Task<bool> SetConcurrentReportsIndex(BaseVec<H256> value, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.Arr16U8, BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Offences/ConcurrentReportsIndex", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OffencesStorage.ConcurrentReportsIndexParams(key));
      }
   }
}