//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.People.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.People.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.People.NET.RestClient.Generated.Clients;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime;
   
   public class SessionControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetTestValue2()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
         result.Create(new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestValidators()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeValidators());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetValidators(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> rpcResult = await rpcClient.GetValidators();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCurrentIndex()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeCurrentIndex());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCurrentIndex(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetCurrentIndex();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestQueuedChanged()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.Bool mockupValue = this.GetTestValueBool();


         Assert.IsTrue(await rpcClient.SubscribeQueuedChanged());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueuedChanged(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.Bool rpcResult = await rpcClient.GetQueuedChanged();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>> GetTestValue7()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>>();
         result.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>[] {
                  this.GetTestValue8()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys> GetTestValue8()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>();
         result.Create(this.GetTestValue9(), this.GetTestValue10());
         return result;
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue9()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys GetTestValue10()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys();
         result.Aura = new Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Aura = this.GetTestValue11();
         return result;
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public GetTestValue11()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestQueuedKeys()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>> mockupValue = this.GetTestValue7();


         Assert.IsTrue(await rpcClient.SubscribeQueuedKeys());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueuedKeys(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys>> rpcResult = await rpcClient.GetQueuedKeys();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> GetTestValue13()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U32[] {
                  this.GetTestValueU32()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDisabledValidators()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue13();


         Assert.IsTrue(await rpcClient.SubscribeDisabledValidators());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDisabledValidators(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetDisabledValidators();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys GetTestValue15()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys();
         result.Aura = new Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Aura = this.GetTestValue16();
         return result;
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public GetTestValue16()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue17()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys mockupValue = this.GetTestValue15();
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeNextKeys(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextKeys(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.People.NET.NetApiExt.Generated.Model.people_polkadot_runtime.SessionKeys rpcResult = await rpcClient.GetNextKeys(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue19()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetTestValue20()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>();
         result.Create(this.GetTestValue21(), this.GetTestValue22());
         return result;
      }
      public Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId GetTestValue21()
      {
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId result;
         result = new Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId();
         result.Value = new Substrate.People.NET.NetApiExt.Generated.Types.Base.Arr4U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetTestValue22()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestKeyOwner()
      {
         // Construct new Mockup client to test with.
         SessionControllerMockupClient mockupClient = new SessionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         SessionControllerClient rpcClient = new SessionControllerClient(_httpClient, subscriptionClient);
         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupValue = this.GetTestValue19();
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> mockupKey = this.GetTestValue20();

         Assert.IsTrue(await rpcClient.SubscribeKeyOwner(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetKeyOwner(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 rpcResult = await rpcClient.GetKeyOwner(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
