//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.GameDAO.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.GameDAO.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// FlowController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class FlowController : ControllerBase
    {
        
        private IFlowStorage _flowStorage;
        
        /// <summary>
        /// FlowController constructor.
        /// </summary>
        public FlowController(IFlowStorage flowStorage)
        {
            _flowStorage = flowStorage;
        }
        
        /// <summary>
        /// >> CampaignOf
        ///  Campaign by its id.
        /// 
        ///  CampaignOf: map Hash => Campaign
        /// </summary>
        [HttpGet("CampaignOf")]
        [ProducesResponseType(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignOfParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCampaignOf(string key)
        {
            return this.Ok(_flowStorage.GetCampaignOf(key));
        }
        
        /// <summary>
        /// >> CampaignCount
        ///  Total number of campaigns.
        /// 
        ///  CampaignCount: u32
        /// </summary>
        [HttpGet("CampaignCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignCountParams")]
        public IActionResult GetCampaignCount()
        {
            return this.Ok(_flowStorage.GetCampaignCount());
        }
        
        /// <summary>
        /// >> CampaignBalance
        ///  Total contributions balance per campaign.
        /// 
        ///  CampaignBalance: map Hash => Balance
        /// </summary>
        [HttpGet("CampaignBalance")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignBalanceParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCampaignBalance(string key)
        {
            return this.Ok(_flowStorage.GetCampaignBalance(key));
        }
        
        /// <summary>
        /// >> CampaignContribution
        ///  Total contribution made by account id for particular campaign.
        ///  campaign id, account id -> contribution.
        /// 
        ///  CampaignContribution: double map Hash, AccountId => Balance
        /// </summary>
        [HttpGet("CampaignContribution")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignContributionParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetCampaignContribution(string key)
        {
            return this.Ok(_flowStorage.GetCampaignContribution(key));
        }
        
        /// <summary>
        /// >> CampaignStates
        ///  Campaign state by campaign id.
        ///  0 created, 1 activated, 2 paused, ...
        /// 
        ///  CampaignStates: map Hash => CampaignState
        /// </summary>
        [HttpGet("CampaignStates")]
        [ProducesResponseType(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignStatesParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCampaignStates(string key)
        {
            return this.Ok(_flowStorage.GetCampaignStates(key));
        }
        
        /// <summary>
        /// >> CampaignsByBlock
        ///  Campaigns starting/ending in block x.
        /// 
        ///  CampaignsByBlock: double map BlockType, BlockNumber => BoundedVec<Hash>
        /// </summary>
        [HttpGet("CampaignsByBlock")]
        [ProducesResponseType(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignsByBlockParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumBlockType, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetCampaignsByBlock(string key)
        {
            return this.Ok(_flowStorage.GetCampaignsByBlock(key));
        }
        
        /// <summary>
        /// >> CampaignFinalizationQueue
        /// </summary>
        [HttpGet("CampaignFinalizationQueue")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.Campaign, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.types.EnumCampaignState, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignFinalizationQueueParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCampaignFinalizationQueue(string key)
        {
            return this.Ok(_flowStorage.GetCampaignFinalizationQueue(key));
        }
        
        /// <summary>
        /// >> ProcessingOffset
        ///  Offset value - number of processed and sucessfully finalized contributions.
        ///  Used during campaign finalization for processing contributors in batches.
        ///  When MaxContributorsProcessing is achieved, set this offset to save the progress.
        /// 
        ///  ProcessingOffset: map Hash => u32
        /// </summary>
        [HttpGet("ProcessingOffset")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "ProcessingOffsetParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetProcessingOffset(string key)
        {
            return this.Ok(_flowStorage.GetProcessingOffset(key));
        }
        
        /// <summary>
        /// >> CampaignContributorsCount
        ///  Total number of contributors for particular campaign. This is needed for voting
        ///  in order do determine eligible voters for Withdrawal proposal.
        /// 
        ///  CampaignContributors: map Hash => u64
        /// </summary>
        [HttpGet("CampaignContributorsCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.FlowStorage), "CampaignContributorsCountParams", typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCampaignContributorsCount(string key)
        {
            return this.Ok(_flowStorage.GetCampaignContributorsCount(key));
        }
    }
}
