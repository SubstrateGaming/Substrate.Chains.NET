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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class CrowdloanControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo GetTestValue2()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo();
         result.Depositor = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Depositor = this.GetTestValue3();
         result.Verifier = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSigner>();
         result.Verifier.Create(this.GetTestValue4());
         result.Deposit = this.GetTestValueU128();
         result.Raised = this.GetTestValueU128();
         result.End = this.GetTestValueU32();
         result.Cap = this.GetTestValueU128();
         result.LastContribution = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.EnumLastContribution();
         result.LastContribution.Create(this.GetTestValueEnum<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.LastContribution>(), this.GetTestValueBaseVoid());
         result.FirstPeriod = this.GetTestValueU32();
         result.LastPeriod = this.GetTestValueU32();
         result.FundIndex = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSigner GetTestValue4()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSigner result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSigner();
         result.Create(this.GetTestValueEnum<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.MultiSigner>(), this.GetTestValue5());
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.ed25519.Public GetTestValue5()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.ed25519.Public result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.ed25519.Public();
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
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id GetTestValue6()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestFunds()
      {
         // Construct new Mockup client to test with.
         CrowdloanControllerMockupClient mockupClient = new CrowdloanControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CrowdloanControllerClient rpcClient = new CrowdloanControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo mockupValue = this.GetTestValue2();
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeFunds(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetFunds(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo rpcResult = await rpcClient.GetFunds(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> GetTestValue8()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id>();
         result.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id[] {
                  this.GetTestValue9()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id GetTestValue9()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNewRaise()
      {
         // Construct new Mockup client to test with.
         CrowdloanControllerMockupClient mockupClient = new CrowdloanControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CrowdloanControllerClient rpcClient = new CrowdloanControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> mockupValue = this.GetTestValue8();


         Assert.IsTrue(await rpcClient.SubscribeNewRaise());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNewRaise(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id> rpcResult = await rpcClient.GetNewRaise();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestEndingsCount()
      {
         // Construct new Mockup client to test with.
         CrowdloanControllerMockupClient mockupClient = new CrowdloanControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CrowdloanControllerClient rpcClient = new CrowdloanControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeEndingsCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetEndingsCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetEndingsCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNextFundIndex()
      {
         // Construct new Mockup client to test with.
         CrowdloanControllerMockupClient mockupClient = new CrowdloanControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         CrowdloanControllerClient rpcClient = new CrowdloanControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeNextFundIndex());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextFundIndex(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetNextFundIndex();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}