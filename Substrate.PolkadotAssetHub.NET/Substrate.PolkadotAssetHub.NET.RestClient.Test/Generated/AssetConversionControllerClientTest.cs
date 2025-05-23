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
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class AssetConversionControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types.PoolInfo GetTestValue2()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types.PoolInfo result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types.PoolInfo();
         result.LpToken = this.GetTestValueU32();
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location> GetTestValue3()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location>();
         result.Create(this.GetTestValue4(), this.GetTestValue6());
         return result;
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location GetTestValue4()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         result.Interior = this.GetTestValue5();
         return result;
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions GetTestValue5()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         // NOT IMPLEMENTED >> Initialize Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions
         return result;
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location GetTestValue6()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         result.Interior = this.GetTestValue7();
         return result;
      }
      public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions GetTestValue7()
      {
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions result;
         result = new Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         // NOT IMPLEMENTED >> Initialize Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPools()
      {
         // Construct new Mockup client to test with.
         AssetConversionControllerMockupClient mockupClient = new AssetConversionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetConversionControllerClient rpcClient = new AssetConversionControllerClient(_httpClient, subscriptionClient);
         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types.PoolInfo mockupValue = this.GetTestValue2();
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location> mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribePools(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPools(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types.PoolInfo rpcResult = await rpcClient.GetPools(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNextPoolAssetId()
      {
         // Construct new Mockup client to test with.
         AssetConversionControllerMockupClient mockupClient = new AssetConversionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetConversionControllerClient rpcClient = new AssetConversionControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeNextPoolAssetId());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextPoolAssetId(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetNextPoolAssetId();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
