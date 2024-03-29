//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Moonsama.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Moonsama.NET.RestClient.Generated.Clients;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet;
   using Substrate.NetApi.Model.Types.Base;
   
   public class AssetManagerControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType GetTestValue2()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType();
         result.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.AssetType>(), this.GetTestValue3());
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation GetTestValue3()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.EnumJunctions();
         result.Interior.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.Junctions>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetIdType()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType mockupValue = this.GetTestValue2();
         Substrate.NetApi.Model.Types.Primitive.U128 mockupKey = this.GetTestValueU128();

         Assert.IsTrue(await rpcClient.SubscribeAssetIdType(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetIdType(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType rpcResult = await rpcClient.GetAssetIdType(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType GetTestValue5()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType();
         result.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.AssetType>(), this.GetTestValue6());
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation GetTestValue6()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.EnumJunctions();
         result.Interior.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.Junctions>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetTypeId()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType mockupKey = this.GetTestValue5();

         Assert.IsTrue(await rpcClient.SubscribeAssetTypeId(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetTypeId(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetAssetTypeId(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType GetTestValue8()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType();
         result.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.AssetType>(), this.GetTestValue9());
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation GetTestValue9()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.EnumJunctions();
         result.Interior.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.Junctions>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetTypeUnitsPerSecond()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType mockupKey = this.GetTestValue8();

         Assert.IsTrue(await rpcClient.SubscribeAssetTypeUnitsPerSecond(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetTypeUnitsPerSecond(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetAssetTypeUnitsPerSecond(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestLocalAssetCounter()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();


         Assert.IsTrue(await rpcClient.SubscribeLocalAssetCounter());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLocalAssetCounter(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetLocalAssetCounter();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo GetTestValue12()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo();
         result.Creator = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20();
         result.Creator = this.GetTestValue13();
         result.Deposit = this.GetTestValueU128();
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 GetTestValue13()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20();
         result.Value = new Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr20U8();
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
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestLocalAssetDeposit()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo mockupValue = this.GetTestValue12();
         Substrate.NetApi.Model.Types.Primitive.U128 mockupKey = this.GetTestValueU128();

         Assert.IsTrue(await rpcClient.SubscribeLocalAssetDeposit(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLocalAssetDeposit(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo rpcResult = await rpcClient.GetLocalAssetDeposit(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType> GetTestValue15()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType>();
         result.Create(new Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType[] {
                  this.GetTestValue16()});
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType GetTestValue16()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType();
         result.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.AssetType>(), this.GetTestValue17());
         return result;
      }
      public Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation GetTestValue17()
      {
         Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation result;
         result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.EnumJunctions();
         result.Interior.Create(this.GetTestValueEnum<Substrate.Moonsama.NET.NetApiExt.Generated.Model.xcm.v3.junctions.Junctions>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSupportedFeePaymentAssets()
      {
         // Construct new Mockup client to test with.
         AssetManagerControllerMockupClient mockupClient = new AssetManagerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetManagerControllerClient rpcClient = new AssetManagerControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType> mockupValue = this.GetTestValue15();


         Assert.IsTrue(await rpcClient.SubscribeSupportedFeePaymentAssets());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSupportedFeePaymentAssets(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType> rpcResult = await rpcClient.GetSupportedFeePaymentAssets();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
