//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class RandomnessControllerMockupClient : MockupBaseClient, IRandomnessControllerMockupClient
   {
      private HttpClient _httpClient;
      public RandomnessControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRandomMaterial(BoundedVecT48 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Randomness/RandomMaterial", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.RandomnessStorage.RandomMaterialParams());
      }
   }
}
