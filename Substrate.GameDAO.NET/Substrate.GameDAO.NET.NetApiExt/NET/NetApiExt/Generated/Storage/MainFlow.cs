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


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> FlowStorage
    /// </summary>
    public sealed class FlowStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> FlowStorage Constructor
        /// </summary>
        public FlowStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignBalance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignContribution"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignStates"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignsByBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumBlockType, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignFinalizationQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "ProcessingOffset"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Flow", "CampaignContributorsCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
        }
        
        /// <summary>
        /// >> CampaignOfParams
        ///  Campaign by its id.
        /// 
        ///  CampaignOf: map Hash => Campaign
        /// </summary>
        public static string CampaignOfParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CampaignOfDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CampaignOf
        ///  Campaign by its id.
        /// 
        ///  CampaignOf: map Hash => Campaign
        /// </summary>
        public async Task<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign> CampaignOf(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignCountParams
        ///  Total number of campaigns.
        /// 
        ///  CampaignCount: u32
        /// </summary>
        public static string CampaignCountParams()
        {
            return RequestGenerator.GetStorage("Flow", "CampaignCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CampaignCountDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CampaignCount
        ///  Total number of campaigns.
        /// 
        ///  CampaignCount: u32
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CampaignCount(string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignBalanceParams
        ///  Total contributions balance per campaign.
        /// 
        ///  CampaignBalance: map Hash => Balance
        /// </summary>
        public static string CampaignBalanceParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignBalance", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CampaignBalanceDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignBalanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> CampaignBalance
        ///  Total contributions balance per campaign.
        /// 
        ///  CampaignBalance: map Hash => Balance
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> CampaignBalance(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignBalanceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignContributionParams
        ///  Total contribution made by account id for particular campaign.
        ///  campaign id, account id -> contribution.
        /// 
        ///  CampaignContribution: double map Hash, AccountId => Balance
        /// </summary>
        public static string CampaignContributionParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignContribution", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> CampaignContributionDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignContributionDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> CampaignContribution
        ///  Total contribution made by account id for particular campaign.
        ///  campaign id, account id -> contribution.
        /// 
        ///  CampaignContribution: double map Hash, AccountId => Balance
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> CampaignContribution(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignContributionParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignStatesParams
        ///  Campaign state by campaign id.
        ///  0 created, 1 activated, 2 paused, ...
        /// 
        ///  CampaignStates: map Hash => CampaignState
        /// </summary>
        public static string CampaignStatesParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignStates", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CampaignStatesDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignStatesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CampaignStates
        ///  Campaign state by campaign id.
        ///  0 created, 1 activated, 2 paused, ...
        /// 
        ///  CampaignStates: map Hash => CampaignState
        /// </summary>
        public async Task<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState> CampaignStates(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignStatesParams(key);
            var result = await _client.GetStorageAsync<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignsByBlockParams
        ///  Campaigns starting/ending in block x.
        /// 
        ///  CampaignsByBlock: double map BlockType, BlockNumber => BoundedVec<Hash>
        /// </summary>
        public static string CampaignsByBlockParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumBlockType, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignsByBlock", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> CampaignsByBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignsByBlockDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CampaignsByBlock
        ///  Campaigns starting/ending in block x.
        /// 
        ///  CampaignsByBlock: double map BlockType, BlockNumber => BoundedVec<Hash>
        /// </summary>
        public async Task<Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> CampaignsByBlock(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumBlockType, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignsByBlockParams(key);
            var result = await _client.GetStorageAsync<Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignFinalizationQueueParams
        /// </summary>
        public static string CampaignFinalizationQueueParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignFinalizationQueue", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CampaignFinalizationQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignFinalizationQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CampaignFinalizationQueue
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>> CampaignFinalizationQueue(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignFinalizationQueueParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ProcessingOffsetParams
        ///  Offset value - number of processed and sucessfully finalized contributions.
        ///  Used during campaign finalization for processing contributors in batches.
        ///  When MaxContributorsProcessing is achieved, set this offset to save the progress.
        /// 
        ///  ProcessingOffset: map Hash => u32
        /// </summary>
        public static string ProcessingOffsetParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "ProcessingOffset", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ProcessingOffsetDefault
        /// Default value as hex string
        /// </summary>
        public static string ProcessingOffsetDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> ProcessingOffset
        ///  Offset value - number of processed and sucessfully finalized contributions.
        ///  Used during campaign finalization for processing contributors in batches.
        ///  When MaxContributorsProcessing is achieved, set this offset to save the progress.
        /// 
        ///  ProcessingOffset: map Hash => u32
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> ProcessingOffset(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.ProcessingOffsetParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CampaignContributorsCountParams
        ///  Total number of contributors for particular campaign. This is needed for voting
        ///  in order do determine eligible voters for Withdrawal proposal.
        /// 
        ///  CampaignContributors: map Hash => u64
        /// </summary>
        public static string CampaignContributorsCountParams(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Flow", "CampaignContributorsCount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CampaignContributorsCountDefault
        /// Default value as hex string
        /// </summary>
        public static string CampaignContributorsCountDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> CampaignContributorsCount
        ///  Total number of contributors for particular campaign. This is needed for voting
        ///  in order do determine eligible voters for Withdrawal proposal.
        /// 
        ///  CampaignContributors: map Hash => u64
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> CampaignContributorsCount(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = FlowStorage.CampaignContributorsCountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> FlowCalls
    /// </summary>
    public sealed class FlowCalls
    {
        
        /// <summary>
        /// >> create_campaign
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateCampaign(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 org_id, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 admin_id, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1 name, Substrate.NetApi.Model.Types.Primitive.U128 target, Substrate.NetApi.Model.Types.Primitive.U128 deposit, Substrate.NetApi.Model.Types.Primitive.U32 expiry, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumFlowProtocol protocol, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumFlowGovernance governance, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1 cid, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> start, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> token_symbol, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> token_name)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(org_id.Encode());
            byteArray.AddRange(admin_id.Encode());
            byteArray.AddRange(name.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(deposit.Encode());
            byteArray.AddRange(expiry.Encode());
            byteArray.AddRange(protocol.Encode());
            byteArray.AddRange(governance.Encode());
            byteArray.AddRange(cid.Encode());
            byteArray.AddRange(start.Encode());
            byteArray.AddRange(token_symbol.Encode());
            byteArray.AddRange(token_name.Encode());
            return new Method(70, "Flow", 0, "create_campaign", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> contribute
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Contribute(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256 campaign_id, Substrate.NetApi.Model.Types.Primitive.U128 contribution)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(campaign_id.Encode());
            byteArray.AddRange(contribution.Encode());
            return new Method(70, "Flow", 1, "contribute", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> FlowConstants
    /// </summary>
    public sealed class FlowConstants
    {
        
        /// <summary>
        /// >> GameDAOTreasury
        ///  The GameDAO Treasury AccountId.
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GameDAOTreasury()
        {
            var result = new Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            result.Create("0x6D6F646C67642F67647472730000000000000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MinNameLength
        ///  The min length of a campaign name.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MinNameLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x04000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCampaignsPerBlock
        ///  The max number of campaigns per one block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCampaignsPerBlock()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x0A000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCampaignContributors
        ///  The max number of contributors per one Campaign.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCampaignContributors()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x10270000");
            return result;
        }
        
        /// <summary>
        /// >> MaxContributorsProcessing
        ///  The max number of contributors for processing in one block (batch size)
        ///  during Campaign finalization.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxContributorsProcessing()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MinContribution
        ///  The min contribution amount in payment tokens
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinContribution()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E40B54020000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MinCampaignDeposit
        ///  The min campaign deposit - fraction of a target, default 10%
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill MinCampaignDeposit()
        {
            var result = new Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill();
            result.Create("0xA0860100");
            return result;
        }
        
        /// <summary>
        /// >> ProtocolTokenId
        ///  The CurrencyId which is used as a protokol token.
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.zero_primitives.currency.EnumCurrencyId ProtocolTokenId()
        {
            var result = new Substrate.GameDAO.NET.NetApiExt.Generated.Model.zero_primitives.currency.EnumCurrencyId();
            result.Create("0x0002");
            return result;
        }
        
        /// <summary>
        /// >> PaymentTokenId
        ///  The CurrencyId which is used as a payment token.
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.zero_primitives.currency.EnumCurrencyId PaymentTokenId()
        {
            var result = new Substrate.GameDAO.NET.NetApiExt.Generated.Model.zero_primitives.currency.EnumCurrencyId();
            result.Create("0x0001");
            return result;
        }
        
        /// <summary>
        /// >> CampaignFee
        ///  The amount of comission to be paid from the Org treasury to GameDAO treasury
        ///  after successfull Campaign finalization
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill CampaignFee()
        {
            var result = new Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill();
            result.Create("0xB80B0000");
            return result;
        }
        
        /// <summary>
        /// >> StringLimit
        ///  The maximum length of a name or symbol stored on-chain.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 StringLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x40000000");
            return result;
        }
        
        /// <summary>
        /// >> CampaignDurationLimits
        ///  Default time limit for a campaign in blocks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> CampaignDurationLimits()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>();
            result.Create("0x201C000080970600");
            return result;
        }
    }
    
    /// <summary>
    /// >> FlowErrors
    /// </summary>
    public enum FlowErrors
    {
        
        /// <summary>
        /// >> AuthorizationError
        /// </summary>
        AuthorizationError,
        
        /// <summary>
        /// >> BalanceLow
        /// </summary>
        BalanceLow,
        
        /// <summary>
        /// >> CampaignExpired
        /// </summary>
        CampaignExpired,
        
        /// <summary>
        /// >> CampaignsPerBlockExceeded
        /// </summary>
        CampaignsPerBlockExceeded,
        
        /// <summary>
        /// >> CampaignUnknown
        /// </summary>
        CampaignUnknown,
        
        /// <summary>
        /// >> ContributionInsufficient
        /// </summary>
        ContributionInsufficient,
        
        /// <summary>
        /// >> DepositInsufficient
        /// </summary>
        DepositInsufficient,
        
        /// <summary>
        /// >> DepositTooHigh
        /// Deposit exceeds the campaign target.
        /// </summary>
        DepositTooHigh,
        
        /// <summary>
        /// >> NameTooShort
        /// </summary>
        NameTooShort,
        
        /// <summary>
        /// >> NoContributionsAllowed
        /// </summary>
        NoContributionsAllowed,
        
        /// <summary>
        /// >> NoContributionToOwnCampaign
        /// </summary>
        NoContributionToOwnCampaign,
        
        /// <summary>
        /// >> OrgPrimeUnknown
        /// </summary>
        OrgPrimeUnknown,
        
        /// <summary>
        /// >> OutOfBounds
        /// Campaign starts/expires validation failed.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> TreasuryBalanceLow
        /// </summary>
        TreasuryBalanceLow,
        
        /// <summary>
        /// >> TreasuryNotExist
        /// </summary>
        TreasuryNotExist,
    }
}
