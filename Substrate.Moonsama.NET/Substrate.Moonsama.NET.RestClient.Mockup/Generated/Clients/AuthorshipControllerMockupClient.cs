//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account;
   using Substrate.Moonsama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuthorshipControllerMockupClient : MockupBaseClient, IAuthorshipControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuthorshipControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthor(AccountId20 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Authorship/Author", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.AuthorshipStorage.AuthorParams());
      }
   }
}