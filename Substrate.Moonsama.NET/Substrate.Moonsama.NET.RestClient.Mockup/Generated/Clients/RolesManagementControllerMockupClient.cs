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
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types;
   using Substrate.Moonsama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class RolesManagementControllerMockupClient : MockupBaseClient, IRolesManagementControllerMockupClient
   {
      private HttpClient _httpClient;
      public RolesManagementControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRoleOf(BitFlags value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "RolesManagement/RoleOf", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.RolesManagementStorage.RoleOfParams(key));
      }
   }
}