//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Coretime.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Coretime.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Coretime.NET.RestClient.Generated.Clients;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class AuraExtControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 GetTestValue2()
      {
         Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 result;
         result = new Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public>();
         result.Value.Create(new Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public GetTestValue3()
      {
         Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public result;
         result = new Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Value = new Substrate.Coretime.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestAuthorities()
      {
         // Construct new Mockup client to test with.
         AuraExtControllerMockupClient mockupClient = new AuraExtControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuraExtControllerClient rpcClient = new AuraExtControllerClient(_httpClient, subscriptionClient);
         Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeAuthorities());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAuthorities(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 rpcResult = await rpcClient.GetAuthorities();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> GetTestValue5()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue6(), this.GetTestValueU32());
         return result;
      }
      public Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot GetTestValue6()
      {
         Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot result;
         result = new Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot();
         result.Value = this.GetTestValueU64();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSlotInfo()
      {
         // Construct new Mockup client to test with.
         AuraExtControllerMockupClient mockupClient = new AuraExtControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuraExtControllerClient rpcClient = new AuraExtControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue5();


         Assert.IsTrue(await rpcClient.SubscribeSlotInfo());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSlotInfo(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetSlotInfo();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}