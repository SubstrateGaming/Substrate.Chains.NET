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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params;
   
   public class ParaSessionInfoControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public> GetTestValue2()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public>();
         result.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public GetTestValue3()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public();
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
      public async System.Threading.Tasks.Task TestAssignmentKeysUnsafe()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public> mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeAssignmentKeysUnsafe());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssignmentKeysUnsafe(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public> rpcResult = await rpcClient.GetAssignmentKeysUnsafe();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestEarliestStoredSession()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeEarliestStoredSession());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetEarliestStoredSession(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetEarliestStoredSession();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo GetTestValue6()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo();
         result.ActiveValidatorIndices = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>();
         result.ActiveValidatorIndices.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex[] {
                  this.GetTestValue7()});
         result.RandomSeed = new Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.RandomSeed.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
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
         result.DisputePeriod = this.GetTestValueU32();
         result.Validators = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT1();
         result.Validators = this.GetTestValue8();
         result.DiscoveryKeys = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public>();
         result.DiscoveryKeys.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public[] {
                  this.GetTestValue10()});
         result.AssignmentKeys = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public>();
         result.AssignmentKeys.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public[] {
                  this.GetTestValue11()});
         result.ValidatorGroups = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT2();
         result.ValidatorGroups = this.GetTestValue12();
         result.NCores = this.GetTestValueU32();
         result.ZerothDelayTrancheWidth = this.GetTestValueU32();
         result.RelayVrfModuloSamples = this.GetTestValueU32();
         result.NDelayTranches = this.GetTestValueU32();
         result.NoShowSlots = this.GetTestValueU32();
         result.NeededApprovals = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex GetTestValue7()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT1 GetTestValue8()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT1 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT1();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public[] {
                  this.GetTestValue9()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public GetTestValue9()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public();
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public GetTestValue10()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public();
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public GetTestValue11()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public();
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT2 GetTestValue12()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT2 result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.IndexedVecT2();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>[] {
                  this.GetTestValue13()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex> GetTestValue13()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>();
         result.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex[] {
                  this.GetTestValue14()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex GetTestValue14()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSessions()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo mockupValue = this.GetTestValue6();
         Substrate.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeSessions(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSessions(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo rpcResult = await rpcClient.GetSessions(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetTestValue16()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
         result.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue17()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue17()
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
      public async System.Threading.Tasks.Task TestAccountKeys()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> mockupValue = this.GetTestValue16();
         Substrate.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeAccountKeys(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAccountKeys(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> rpcResult = await rpcClient.GetAccountKeys(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams GetTestValue19()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam[] {
                  this.GetTestValue20()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam GetTestValue20()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam();
         // NOT IMPLEMENTED >> Initialize Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.EnumExecutorParam
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSessionExecutorParams()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams mockupValue = this.GetTestValue19();
         Substrate.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeSessionExecutorParams(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSessionExecutorParams(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams rpcResult = await rpcClient.GetSessionExecutorParams(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
