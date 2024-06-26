//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Polkadot.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Polkadot.NET.RestClient.Generated.Clients;
   using Substrate.NetApi.Model.Types.Base;
   
   public class WhitelistControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple GetTestValue2()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple();
         return result;
      }
      public Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue3()
      {
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 result;
         result = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = new Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestWhitelistedCall()
      {
         // Construct new Mockup client to test with.
         WhitelistControllerMockupClient mockupClient = new WhitelistControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         WhitelistControllerClient rpcClient = new WhitelistControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseTuple mockupValue = this.GetTestValue2();
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribeWhitelistedCall(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetWhitelistedCall(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseTuple rpcResult = await rpcClient.GetWhitelistedCall(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
