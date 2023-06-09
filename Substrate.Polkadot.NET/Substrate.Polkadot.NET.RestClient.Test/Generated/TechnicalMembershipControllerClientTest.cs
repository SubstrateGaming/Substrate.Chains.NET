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
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto;
   
   public class TechnicalMembershipControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT16 GetTestValue2()
      {
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT16 result;
         result = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT16();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
         result.Value.Create(new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
      {
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
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
      public async System.Threading.Tasks.Task TestMembers()
      {
         // Construct new Mockup client to test with.
         TechnicalMembershipControllerMockupClient mockupClient = new TechnicalMembershipControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TechnicalMembershipControllerClient rpcClient = new TechnicalMembershipControllerClient(_httpClient, subscriptionClient);
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT16 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeMembers());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetMembers(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT16 rpcResult = await rpcClient.GetMembers();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue5()
      {
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
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
      public async System.Threading.Tasks.Task TestPrime()
      {
         // Construct new Mockup client to test with.
         TechnicalMembershipControllerMockupClient mockupClient = new TechnicalMembershipControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TechnicalMembershipControllerClient rpcClient = new TechnicalMembershipControllerClient(_httpClient, subscriptionClient);
         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupValue = this.GetTestValue5();


         Assert.IsTrue(await rpcClient.SubscribePrime());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPrime(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 rpcResult = await rpcClient.GetPrime();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
