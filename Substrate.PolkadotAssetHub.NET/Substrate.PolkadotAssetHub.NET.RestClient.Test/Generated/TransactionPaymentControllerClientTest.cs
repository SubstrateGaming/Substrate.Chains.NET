//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotAssetHub.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotAssetHub.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.PolkadotAssetHub.NET.RestClient.Generated.Clients;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment;
   
   public class TransactionPaymentControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 GetTestValue2()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
         result.Value = this.GetTestValueU128();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNextFeeMultiplier()
      {
         // Construct new Mockup client to test with.
         TransactionPaymentControllerMockupClient mockupClient = new TransactionPaymentControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TransactionPaymentControllerClient rpcClient = new TransactionPaymentControllerClient(_httpClient, subscriptionClient);
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeNextFeeMultiplier());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextFeeMultiplier(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 rpcResult = await rpcClient.GetNextFeeMultiplier();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases GetTestValue4()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases();
         result.Create(this.GetTestValueEnum<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.Releases>());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestStorageVersion()
      {
         // Construct new Mockup client to test with.
         TransactionPaymentControllerMockupClient mockupClient = new TransactionPaymentControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TransactionPaymentControllerClient rpcClient = new TransactionPaymentControllerClient(_httpClient, subscriptionClient);
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases mockupValue = this.GetTestValue4();


         Assert.IsTrue(await rpcClient.SubscribeStorageVersion());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetStorageVersion(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases rpcResult = await rpcClient.GetStorageVersion();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}