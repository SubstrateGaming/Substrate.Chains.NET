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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   
   public class AuthorityDiscoveryControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetTestValue2()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public GetTestValue3()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public();
         result.Value = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue4();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue4()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = new Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestKeys()
      {
         // Construct new Mockup client to test with.
         AuthorityDiscoveryControllerMockupClient mockupClient = new AuthorityDiscoveryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuthorityDiscoveryControllerClient rpcClient = new AuthorityDiscoveryControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeKeys());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetKeys(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 rpcResult = await rpcClient.GetKeys();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetTestValue6()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public[] {
                  this.GetTestValue7()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public GetTestValue7()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public();
         result.Value = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue8();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue8()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = new Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestNextKeys()
      {
         // Construct new Mockup client to test with.
         AuthorityDiscoveryControllerMockupClient mockupClient = new AuthorityDiscoveryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuthorityDiscoveryControllerClient rpcClient = new AuthorityDiscoveryControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 mockupValue = this.GetTestValue6();


         Assert.IsTrue(await rpcClient.SubscribeNextKeys());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextKeys(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 rpcResult = await rpcClient.GetNextKeys();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}