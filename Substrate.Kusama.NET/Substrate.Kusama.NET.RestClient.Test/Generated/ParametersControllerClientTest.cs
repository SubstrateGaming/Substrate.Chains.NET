//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Kusama.NET.RestClient.Generated.Clients;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime;
   
   public class ParametersControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue GetTestValue2()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue();
         // NOT IMPLEMENTED >> Initialize Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersKey GetTestValue3()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersKey result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersKey();
         // NOT IMPLEMENTED >> Initialize Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersKey
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestParameters()
      {
         // Construct new Mockup client to test with.
         ParametersControllerMockupClient mockupClient = new ParametersControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParametersControllerClient rpcClient = new ParametersControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue mockupValue = this.GetTestValue2();
         Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersKey mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribeParameters(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetParameters(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime.EnumRuntimeParametersValue rpcResult = await rpcClient.GetParameters(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}