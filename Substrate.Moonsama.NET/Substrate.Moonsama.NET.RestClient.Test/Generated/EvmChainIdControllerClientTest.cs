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
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class EvmChainIdControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestChainId()
      {
         // Construct new Mockup client to test with.
         EvmChainIdControllerMockupClient mockupClient = new EvmChainIdControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         EvmChainIdControllerClient rpcClient = new EvmChainIdControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeChainId());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetChainId(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetChainId();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}