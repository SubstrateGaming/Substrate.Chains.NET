//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> BridgeRelayersStorage
    /// </summary>
    public sealed class BridgeRelayersStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> BridgeRelayersStorage Constructor
        /// </summary>
        public BridgeRelayersStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("BridgeRelayers", "RelayerRewards"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("BridgeRelayers", "RegisteredRelayers"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration)));
        }
        
        /// <summary>
        /// >> RelayerRewardsParams
        ///  Map of the relayer => accumulated reward.
        /// </summary>
        public static string RelayerRewardsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams> key)
        {
            return RequestGenerator.GetStorage("BridgeRelayers", "RelayerRewards", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> RelayerRewardsDefault
        /// Default value as hex string
        /// </summary>
        public static string RelayerRewardsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> RelayerRewards
        ///  Map of the relayer => accumulated reward.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> RelayerRewards(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams> key, string blockhash, CancellationToken token)
        {
            string parameters = BridgeRelayersStorage.RelayerRewardsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> RegisteredRelayersParams
        ///  Relayers that have reserved some of their balance to get free priority boost
        ///  for their message delivery transactions.
        /// 
        ///  Other relayers may submit transactions as well, but they will have default
        ///  priority and will be rejected (without significant tip) in case if registered
        ///  relayer is present.
        /// </summary>
        public static string RegisteredRelayersParams(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("BridgeRelayers", "RegisteredRelayers", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> RegisteredRelayersDefault
        /// Default value as hex string
        /// </summary>
        public static string RegisteredRelayersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> RegisteredRelayers
        ///  Relayers that have reserved some of their balance to get free priority boost
        ///  for their message delivery transactions.
        /// 
        ///  Other relayers may submit transactions as well, but they will have default
        ///  priority and will be rejected (without significant tip) in case if registered
        ///  relayer is present.
        /// </summary>
        public async Task<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration> RegisteredRelayers(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = BridgeRelayersStorage.RegisteredRelayersParams(key);
            var result = await _client.GetStorageAsync<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.registration.Registration>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> BridgeRelayersCalls
    /// </summary>
    public sealed class BridgeRelayersCalls
    {
        
        /// <summary>
        /// >> claim_rewards
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClaimRewards(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_relayers.RewardsAccountParams rewards_account_params)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(rewards_account_params.Encode());
            return new Method(50, "BridgeRelayers", 0, "claim_rewards", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> register
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Register(Substrate.NetApi.Model.Types.Primitive.U32 valid_till)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(valid_till.Encode());
            return new Method(50, "BridgeRelayers", 1, "register", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> deregister
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Deregister()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(50, "BridgeRelayers", 2, "deregister", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> BridgeRelayersConstants
    /// </summary>
    public sealed class BridgeRelayersConstants
    {
    }
    
    /// <summary>
    /// >> BridgeRelayersErrors
    /// </summary>
    public enum BridgeRelayersErrors
    {
        
        /// <summary>
        /// >> NoRewardForRelayer
        /// No reward can be claimed by given relayer.
        /// </summary>
        NoRewardForRelayer,
        
        /// <summary>
        /// >> FailedToPayReward
        /// Reward payment procedure has failed.
        /// </summary>
        FailedToPayReward,
        
        /// <summary>
        /// >> InvalidRegistrationLease
        /// The relayer has tried to register for past block or registration lease
        /// is too short.
        /// </summary>
        InvalidRegistrationLease,
        
        /// <summary>
        /// >> CannotReduceRegistrationLease
        /// New registration lease is less than the previous one.
        /// </summary>
        CannotReduceRegistrationLease,
        
        /// <summary>
        /// >> FailedToReserve
        /// Failed to reserve enough funds on relayer account.
        /// </summary>
        FailedToReserve,
        
        /// <summary>
        /// >> FailedToUnreserve
        /// Failed to `unreserve` enough funds on relayer account.
        /// </summary>
        FailedToUnreserve,
        
        /// <summary>
        /// >> NotRegistered
        /// Cannot `deregister` if not registered.
        /// </summary>
        NotRegistered,
        
        /// <summary>
        /// >> RegistrationIsStillActive
        /// Failed to `deregister` relayer, because lease is still active.
        /// </summary>
        RegistrationIsStillActive,
    }
}