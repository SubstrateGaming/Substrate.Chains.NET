//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Moonsama.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Moonsama.NET.RestClient.Generated.Clients;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types;
   
   public class RolesManagementControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types.BitFlags GetTestValue2()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types.BitFlags result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types.BitFlags();
         result.Value = this.GetTestValueU8();
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 GetTestValue3()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20();
         result.Value = new Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr20U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRoleOf()
      {
         // Construct new Mockup client to test with.
         RolesManagementControllerMockupClient mockupClient = new RolesManagementControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RolesManagementControllerClient rpcClient = new RolesManagementControllerClient(_httpClient, subscriptionClient);
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types.BitFlags mockupValue = this.GetTestValue2();
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribeRoleOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRoleOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types.BitFlags rpcResult = await rpcClient.GetRoleOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
