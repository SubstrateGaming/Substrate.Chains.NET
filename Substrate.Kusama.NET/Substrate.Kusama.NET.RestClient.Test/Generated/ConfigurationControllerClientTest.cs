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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class ConfigurationControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration GetTestValue2()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration();
         result.MaxCodeSize = this.GetTestValueU32();
         result.MaxHeadDataSize = this.GetTestValueU32();
         result.MaxUpwardQueueCount = this.GetTestValueU32();
         result.MaxUpwardQueueSize = this.GetTestValueU32();
         result.MaxUpwardMessageSize = this.GetTestValueU32();
         result.MaxUpwardMessageNumPerCandidate = this.GetTestValueU32();
         result.HrmpMaxMessageNumPerCandidate = this.GetTestValueU32();
         result.ValidationUpgradeCooldown = this.GetTestValueU32();
         result.ValidationUpgradeDelay = this.GetTestValueU32();
         result.AsyncBackingParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams();
         result.AsyncBackingParams = this.GetTestValue3();
         result.MaxPovSize = this.GetTestValueU32();
         result.MaxDownwardMessageSize = this.GetTestValueU32();
         result.HrmpMaxParachainOutboundChannels = this.GetTestValueU32();
         result.HrmpSenderDeposit = this.GetTestValueU128();
         result.HrmpRecipientDeposit = this.GetTestValueU128();
         result.HrmpChannelMaxCapacity = this.GetTestValueU32();
         result.HrmpChannelMaxTotalSize = this.GetTestValueU32();
         result.HrmpMaxParachainInboundChannels = this.GetTestValueU32();
         result.HrmpChannelMaxMessageSize = this.GetTestValueU32();
         result.ExecutorParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams();
         result.ExecutorParams = this.GetTestValue4();
         result.CodeRetentionPeriod = this.GetTestValueU32();
         result.CoretimeCores = this.GetTestValueU32();
         result.OnDemandRetries = this.GetTestValueU32();
         result.OnDemandQueueMaxSize = this.GetTestValueU32();
         result.OnDemandTargetQueueUtilization = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.OnDemandTargetQueueUtilization = this.GetTestValue6();
         result.OnDemandFeeVariability = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.OnDemandFeeVariability = this.GetTestValue7();
         result.OnDemandBaseFee = this.GetTestValueU128();
         result.OnDemandTtl = this.GetTestValueU32();
         result.GroupRotationFrequency = this.GetTestValueU32();
         result.ParasAvailabilityPeriod = this.GetTestValueU32();
         result.SchedulingLookahead = this.GetTestValueU32();
         result.MaxValidatorsPerCore = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.MaxValidatorsPerCore.Create(this.GetTestValueU32());
         result.MaxValidators = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.MaxValidators.Create(this.GetTestValueU32());
         result.DisputePeriod = this.GetTestValueU32();
         result.DisputePostConclusionAcceptancePeriod = this.GetTestValueU32();
         result.NoShowSlots = this.GetTestValueU32();
         result.NDelayTranches = this.GetTestValueU32();
         result.ZerothDelayTrancheWidth = this.GetTestValueU32();
         result.NeededApprovals = this.GetTestValueU32();
         result.RelayVrfModuloSamples = this.GetTestValueU32();
         result.PvfVotingTtl = this.GetTestValueU32();
         result.MinimumValidationUpgradeDelay = this.GetTestValueU32();
         result.MinimumBackingVotes = this.GetTestValueU32();
         result.NodeFeatures = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.NodeFeatures = this.GetTestValue8();
         result.ApprovalVotingParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams();
         result.ApprovalVotingParams = this.GetTestValue9();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams GetTestValue3()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams();
         result.MaxCandidateDepth = this.GetTestValueU32();
         result.AllowedAncestryLen = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams GetTestValue4()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam[] {
                  this.GetTestValue5()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam GetTestValue5()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam();
         result.Create(this.GetTestValueEnum<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParam>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue6()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue7()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue8()
      {
         Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Substrate.NetApi.Model.Types.Base.BaseBitSeq`2[[Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi, Version=0.9.22.0, Culture=neutral, PublicKeyToken=null],[Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0, Substrate.Kusama.NET.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams GetTestValue9()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams();
         result.MaxApprovalCoalesceCount = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestActiveConfig()
      {
         // Construct new Mockup client to test with.
         ConfigurationControllerMockupClient mockupClient = new ConfigurationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ConfigurationControllerClient rpcClient = new ConfigurationControllerClient(_httpClient, subscriptionClient);
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeActiveConfig());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetActiveConfig(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration rpcResult = await rpcClient.GetActiveConfig();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>> GetTestValue11()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>>();
         result.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>[] {
                  this.GetTestValue12()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration> GetTestValue12()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>();
         result.Create(this.GetTestValueU32(), this.GetTestValue13());
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration GetTestValue13()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration();
         result.MaxCodeSize = this.GetTestValueU32();
         result.MaxHeadDataSize = this.GetTestValueU32();
         result.MaxUpwardQueueCount = this.GetTestValueU32();
         result.MaxUpwardQueueSize = this.GetTestValueU32();
         result.MaxUpwardMessageSize = this.GetTestValueU32();
         result.MaxUpwardMessageNumPerCandidate = this.GetTestValueU32();
         result.HrmpMaxMessageNumPerCandidate = this.GetTestValueU32();
         result.ValidationUpgradeCooldown = this.GetTestValueU32();
         result.ValidationUpgradeDelay = this.GetTestValueU32();
         result.AsyncBackingParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams();
         result.AsyncBackingParams = this.GetTestValue14();
         result.MaxPovSize = this.GetTestValueU32();
         result.MaxDownwardMessageSize = this.GetTestValueU32();
         result.HrmpMaxParachainOutboundChannels = this.GetTestValueU32();
         result.HrmpSenderDeposit = this.GetTestValueU128();
         result.HrmpRecipientDeposit = this.GetTestValueU128();
         result.HrmpChannelMaxCapacity = this.GetTestValueU32();
         result.HrmpChannelMaxTotalSize = this.GetTestValueU32();
         result.HrmpMaxParachainInboundChannels = this.GetTestValueU32();
         result.HrmpChannelMaxMessageSize = this.GetTestValueU32();
         result.ExecutorParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams();
         result.ExecutorParams = this.GetTestValue15();
         result.CodeRetentionPeriod = this.GetTestValueU32();
         result.CoretimeCores = this.GetTestValueU32();
         result.OnDemandRetries = this.GetTestValueU32();
         result.OnDemandQueueMaxSize = this.GetTestValueU32();
         result.OnDemandTargetQueueUtilization = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.OnDemandTargetQueueUtilization = this.GetTestValue17();
         result.OnDemandFeeVariability = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.OnDemandFeeVariability = this.GetTestValue18();
         result.OnDemandBaseFee = this.GetTestValueU128();
         result.OnDemandTtl = this.GetTestValueU32();
         result.GroupRotationFrequency = this.GetTestValueU32();
         result.ParasAvailabilityPeriod = this.GetTestValueU32();
         result.SchedulingLookahead = this.GetTestValueU32();
         result.MaxValidatorsPerCore = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.MaxValidatorsPerCore.Create(this.GetTestValueU32());
         result.MaxValidators = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
         result.MaxValidators.Create(this.GetTestValueU32());
         result.DisputePeriod = this.GetTestValueU32();
         result.DisputePostConclusionAcceptancePeriod = this.GetTestValueU32();
         result.NoShowSlots = this.GetTestValueU32();
         result.NDelayTranches = this.GetTestValueU32();
         result.ZerothDelayTrancheWidth = this.GetTestValueU32();
         result.NeededApprovals = this.GetTestValueU32();
         result.RelayVrfModuloSamples = this.GetTestValueU32();
         result.PvfVotingTtl = this.GetTestValueU32();
         result.MinimumValidationUpgradeDelay = this.GetTestValueU32();
         result.MinimumBackingVotes = this.GetTestValueU32();
         result.NodeFeatures = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.NodeFeatures = this.GetTestValue19();
         result.ApprovalVotingParams = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams();
         result.ApprovalVotingParams = this.GetTestValue20();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams GetTestValue14()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams();
         result.MaxCandidateDepth = this.GetTestValueU32();
         result.AllowedAncestryLen = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams GetTestValue15()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam>();
         result.Value.Create(new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam[] {
                  this.GetTestValue16()});
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam GetTestValue16()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.EnumExecutorParam();
         result.Create(this.GetTestValueEnum<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParam>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue17()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue18()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue19()
      {
         Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Substrate.NetApi.Model.Types.Base.BaseBitSeq`2[[Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi, Version=0.9.22.0, Culture=neutral, PublicKeyToken=null],[Substrate.Kusama.NET.NetApiExt.Generated.Model.bitvec.order.Lsb0, Substrate.Kusama.NET.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams GetTestValue20()
      {
         Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams result;
         result = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams();
         result.MaxApprovalCoalesceCount = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPendingConfigs()
      {
         // Construct new Mockup client to test with.
         ConfigurationControllerMockupClient mockupClient = new ConfigurationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ConfigurationControllerClient rpcClient = new ConfigurationControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>> mockupValue = this.GetTestValue11();


         Assert.IsTrue(await rpcClient.SubscribePendingConfigs());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPendingConfigs(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>> rpcResult = await rpcClient.GetPendingConfigs();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestBypassConsistencyCheck()
      {
         // Construct new Mockup client to test with.
         ConfigurationControllerMockupClient mockupClient = new ConfigurationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ConfigurationControllerClient rpcClient = new ConfigurationControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.Bool mockupValue = this.GetTestValueBool();


         Assert.IsTrue(await rpcClient.SubscribeBypassConsistencyCheck());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBypassConsistencyCheck(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.Bool rpcResult = await rpcClient.GetBypassConsistencyCheck();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}