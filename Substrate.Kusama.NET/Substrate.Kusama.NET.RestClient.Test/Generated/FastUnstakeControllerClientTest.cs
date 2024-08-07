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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class FastUnstakeControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest GetTestValue2()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest();
         result.Stashes = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42();
         result.Stashes = this.GetTestValue3();
         result.Checked = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43();
         result.Checked = this.GetTestValue6();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42 GetTestValue3()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>[] {
                  this.GetTestValue4()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128> GetTestValue4()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>();
         result.Create(this.GetTestValue5(), this.GetTestValueU128());
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue5()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 GetTestValue6()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U32[] {
                  this.GetTestValueU32()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestHead()
      {
         // Construct new Mockup client to test with.
         FastUnstakeControllerMockupClient mockupClient = new FastUnstakeControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         FastUnstakeControllerClient rpcClient = new FastUnstakeControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeHead());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetHead(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest rpcResult = await rpcClient.GetHead();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue8()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
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
      public async System.Threading.Tasks.Task TestQueue()
      {
         // Construct new Mockup client to test with.
         FastUnstakeControllerMockupClient mockupClient = new FastUnstakeControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         FastUnstakeControllerClient rpcClient = new FastUnstakeControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue8();

         Assert.IsTrue(await rpcClient.SubscribeQueue(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueue(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetQueue(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCounterForQueue()
      {
         // Construct new Mockup client to test with.
         FastUnstakeControllerMockupClient mockupClient = new FastUnstakeControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         FastUnstakeControllerClient rpcClient = new FastUnstakeControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeCounterForQueue());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCounterForQueue(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetCounterForQueue();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestErasToCheckPerBlock()
      {
         // Construct new Mockup client to test with.
         FastUnstakeControllerMockupClient mockupClient = new FastUnstakeControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         FastUnstakeControllerClient rpcClient = new FastUnstakeControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeErasToCheckPerBlock());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetErasToCheckPerBlock(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetErasToCheckPerBlock();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
