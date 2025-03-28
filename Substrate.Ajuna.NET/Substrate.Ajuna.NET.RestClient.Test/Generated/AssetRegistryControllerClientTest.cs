//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Ajuna.NET.RestClient.Generated.Clients;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class AssetRegistryControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location GetTestValue2()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         result.Interior = this.GetTestValue3();
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions GetTestValue3()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         // NOT IMPLEMENTED >> Initialize Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetIdLocation()
      {
         // Construct new Mockup client to test with.
         AssetRegistryControllerMockupClient mockupClient = new AssetRegistryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetRegistryControllerClient rpcClient = new AssetRegistryControllerClient(_httpClient, subscriptionClient);
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location mockupValue = this.GetTestValue2();
         Substrate.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeAssetIdLocation(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetIdLocation(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location rpcResult = await rpcClient.GetAssetIdLocation(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location GetTestValue5()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location();
         result.Parents = this.GetTestValueU8();
         result.Interior = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         result.Interior = this.GetTestValue6();
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions GetTestValue6()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions();
         // NOT IMPLEMENTED >> Initialize Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.junctions.EnumJunctions
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetLocationId()
      {
         // Construct new Mockup client to test with.
         AssetRegistryControllerMockupClient mockupClient = new AssetRegistryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AssetRegistryControllerClient rpcClient = new AssetRegistryControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location mockupKey = this.GetTestValue5();

         Assert.IsTrue(await rpcClient.SubscribeAssetLocationId(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetLocationId(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetAssetLocationId(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
