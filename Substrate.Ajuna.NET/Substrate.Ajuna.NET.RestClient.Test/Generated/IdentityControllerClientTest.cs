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
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public class IdentityControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration GetTestValue2()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration();
         result.Judgements = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
         result.Judgements = this.GetTestValue3();
         result.Deposit = this.GetTestValueU128();
         result.Info = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo();
         result.Info = this.GetTestValue6();
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 GetTestValue3()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement>>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement>[] {
                  this.GetTestValue4()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement> GetTestValue4()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement>();
         result.Create(this.GetTestValueU32(), this.GetTestValue5());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement GetTestValue5()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement();
         result.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Judgement>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo GetTestValue6()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo();
         result.Additional = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
         result.Additional = this.GetTestValue7();
         result.Display = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Display.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Legal = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Legal.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Web = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Web.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Riot = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Riot.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Email = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Email.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.PgpFingerprint = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr20U8>();
         result.PgpFingerprint.Create(this.GetTestValue11());
         result.Image = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Image.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Twitter = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Twitter.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 GetTestValue7()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>[] {
                  this.GetTestValue8()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> GetTestValue8()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>();
         result.Create(this.GetTestValue9(), this.GetTestValue10());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData GetTestValue9()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData GetTestValue10()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr20U8 GetTestValue11()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr20U8 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr20U8();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
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
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue12()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestIdentityOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration mockupValue = this.GetTestValue2();
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue12();

         Assert.IsTrue(await rpcClient.SubscribeIdentityOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetIdentityOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration rpcResult = await rpcClient.GetIdentityOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> GetTestValue14()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>();
         result.Create(this.GetTestValue15(), this.GetTestValue16());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue15()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData GetTestValue16()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue17()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestSuperOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> mockupValue = this.GetTestValue14();
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeSuperOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSuperOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> rpcResult = await rpcClient.GetSuperOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> GetTestValue19()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>();
         result.Create(this.GetTestValueU128(), this.GetTestValue20());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 GetTestValue20()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
         result.Value.Create(new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue21()});
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue21()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue22()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestSubsOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> mockupValue = this.GetTestValue19();
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue22();

         Assert.IsTrue(await rpcClient.SubscribeSubsOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSubsOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7> rpcResult = await rpcClient.GetSubsOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 GetTestValue24()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo>>();
         result.Value.Create(new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo>[] {
                  this.GetTestValue25()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo> GetTestValue25()
      {
         Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo>();
         result.Create(this.GetTestValue26());
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo GetTestValue26()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.RegistrarInfo();
         result.Account = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Account = this.GetTestValue27();
         result.Fee = this.GetTestValueU128();
         result.Fields = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags();
         result.Fields = this.GetTestValue28();
         return result;
      }
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue27()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8();
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
      public Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags GetTestValue28()
      {
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags result;
         result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags();
         result.Value = this.GetTestValueU64();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRegistrars()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 mockupValue = this.GetTestValue24();


         Assert.IsTrue(await rpcClient.SubscribeRegistrars());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRegistrars(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 rpcResult = await rpcClient.GetRegistrars();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
