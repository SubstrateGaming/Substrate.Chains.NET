//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Aventus.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Aventus.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ParachainStakingController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParachainStakingController : ControllerBase
    {
        
        private IParachainStakingStorage _parachainStakingStorage;
        
        /// <summary>
        /// ParachainStakingController constructor.
        /// </summary>
        public ParachainStakingController(IParachainStakingStorage parachainStakingStorage)
        {
            _parachainStakingStorage = parachainStakingStorage;
        }
        
        /// <summary>
        /// >> Delay
        ///  Number of eras to wait before executing any staking action
        /// </summary>
        [HttpGet("Delay")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "DelayParams")]
        public IActionResult GetDelay()
        {
            return this.Ok(_parachainStakingStorage.GetDelay());
        }
        
        /// <summary>
        /// >> TotalSelected
        ///  The total candidates selected every era
        /// </summary>
        [HttpGet("TotalSelected")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "TotalSelectedParams")]
        public IActionResult GetTotalSelected()
        {
            return this.Ok(_parachainStakingStorage.GetTotalSelected());
        }
        
        /// <summary>
        /// >> Era
        ///  Current era index and next era scheduled transition
        /// </summary>
        [HttpGet("Era")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.EraInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "EraParams")]
        public IActionResult GetEra()
        {
            return this.Ok(_parachainStakingStorage.GetEra());
        }
        
        /// <summary>
        /// >> NominatorState
        ///  Get nominator state associated with an account if account is nominating else None
        /// </summary>
        [HttpGet("NominatorState")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Nominator), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "NominatorStateParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetNominatorState(string key)
        {
            return this.Ok(_parachainStakingStorage.GetNominatorState(key));
        }
        
        /// <summary>
        /// >> CandidateInfo
        ///  Get collator candidate info associated with an account if account is candidate else None
        /// </summary>
        [HttpGet("CandidateInfo")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.CandidateMetadata), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "CandidateInfoParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetCandidateInfo(string key)
        {
            return this.Ok(_parachainStakingStorage.GetCandidateInfo(key));
        }
        
        /// <summary>
        /// >> NominationScheduledRequests
        ///  Stores outstanding nomination requests per collator.
        /// </summary>
        [HttpGet("NominationScheduledRequests")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.nomination_requests.ScheduledRequest>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "NominationScheduledRequestsParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetNominationScheduledRequests(string key)
        {
            return this.Ok(_parachainStakingStorage.GetNominationScheduledRequests(key));
        }
        
        /// <summary>
        /// >> TopNominations
        ///  Top nominations for collator candidate
        /// </summary>
        [HttpGet("TopNominations")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Nominations), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "TopNominationsParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetTopNominations(string key)
        {
            return this.Ok(_parachainStakingStorage.GetTopNominations(key));
        }
        
        /// <summary>
        /// >> BottomNominations
        ///  Bottom nominations for collator candidate
        /// </summary>
        [HttpGet("BottomNominations")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Nominations), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "BottomNominationsParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetBottomNominations(string key)
        {
            return this.Ok(_parachainStakingStorage.GetBottomNominations(key));
        }
        
        /// <summary>
        /// >> SelectedCandidates
        ///  The collator candidates selected for the current era
        /// </summary>
        [HttpGet("SelectedCandidates")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "SelectedCandidatesParams")]
        public IActionResult GetSelectedCandidates()
        {
            return this.Ok(_parachainStakingStorage.GetSelectedCandidates());
        }
        
        /// <summary>
        /// >> Total
        ///  Total capital locked by this staking pallet
        /// </summary>
        [HttpGet("Total")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "TotalParams")]
        public IActionResult GetTotal()
        {
            return this.Ok(_parachainStakingStorage.GetTotal());
        }
        
        /// <summary>
        /// >> CandidatePool
        ///  The pool of collator candidates, each with their total backing stake
        /// </summary>
        [HttpGet("CandidatePool")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.set.OrderedSet), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "CandidatePoolParams")]
        public IActionResult GetCandidatePool()
        {
            return this.Ok(_parachainStakingStorage.GetCandidatePool());
        }
        
        /// <summary>
        /// >> AtStake
        ///  Snapshot of collator nomination stake at the start of the era
        /// </summary>
        [HttpGet("AtStake")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.CollatorSnapshot), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "AtStakeParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetAtStake(string key)
        {
            return this.Ok(_parachainStakingStorage.GetAtStake(key));
        }
        
        /// <summary>
        /// >> DelayedPayouts
        ///  Delayed payouts
        /// </summary>
        [HttpGet("DelayedPayouts")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.DelayedPayout), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "DelayedPayoutsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetDelayedPayouts(string key)
        {
            return this.Ok(_parachainStakingStorage.GetDelayedPayouts(key));
        }
        
        /// <summary>
        /// >> Staked
        ///  Total counted stake for selected candidates in the era
        /// </summary>
        [HttpGet("Staked")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "StakedParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetStaked(string key)
        {
            return this.Ok(_parachainStakingStorage.GetStaked(key));
        }
        
        /// <summary>
        /// >> Points
        ///  Total points awarded to collators for block production in the era
        /// </summary>
        [HttpGet("Points")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "PointsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetPoints(string key)
        {
            return this.Ok(_parachainStakingStorage.GetPoints(key));
        }
        
        /// <summary>
        /// >> AwardedPts
        ///  Points for each collator per era
        /// </summary>
        [HttpGet("AwardedPts")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "AwardedPtsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetAwardedPts(string key)
        {
            return this.Ok(_parachainStakingStorage.GetAwardedPts(key));
        }
        
        /// <summary>
        /// >> LockedEraPayout
        ///  Total amount of payouts we are waiting to take out of this pallet's pot.
        /// </summary>
        [HttpGet("LockedEraPayout")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "LockedEraPayoutParams")]
        public IActionResult GetLockedEraPayout()
        {
            return this.Ok(_parachainStakingStorage.GetLockedEraPayout());
        }
        
        /// <summary>
        /// >> GrowthPeriod
        ///  Tracks the current growth period where collator will get paid for producing blocks
        /// </summary>
        [HttpGet("GrowthPeriod")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.GrowthPeriodInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "GrowthPeriodParams")]
        public IActionResult GetGrowthPeriod()
        {
            return this.Ok(_parachainStakingStorage.GetGrowthPeriod());
        }
        
        /// <summary>
        /// >> Growth
        ///  Data to calculate growth and collator payouts.
        /// </summary>
        [HttpGet("Growth")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.GrowthInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "GrowthParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetGrowth(string key)
        {
            return this.Ok(_parachainStakingStorage.GetGrowth(key));
        }
        
        /// <summary>
        /// >> ProcessedGrowthPeriods
        /// </summary>
        [HttpGet("ProcessedGrowthPeriods")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "ProcessedGrowthPeriodsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetProcessedGrowthPeriods(string key)
        {
            return this.Ok(_parachainStakingStorage.GetProcessedGrowthPeriods(key));
        }
        
        /// <summary>
        /// >> ForceNewEra
        /// </summary>
        [HttpGet("ForceNewEra")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "ForceNewEraParams")]
        public IActionResult GetForceNewEra()
        {
            return this.Ok(_parachainStakingStorage.GetForceNewEra());
        }
        
        /// <summary>
        /// >> MinCollatorStake
        ///  Minimum stake required for any candidate to be a collator
        /// </summary>
        [HttpGet("MinCollatorStake")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "MinCollatorStakeParams")]
        public IActionResult GetMinCollatorStake()
        {
            return this.Ok(_parachainStakingStorage.GetMinCollatorStake());
        }
        
        /// <summary>
        /// >> MinTotalNominatorStake
        ///  Minimum total stake that must be maintained for any registered on-chain account to be a
        ///  nominator
        /// </summary>
        [HttpGet("MinTotalNominatorStake")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "MinTotalNominatorStakeParams")]
        public IActionResult GetMinTotalNominatorStake()
        {
            return this.Ok(_parachainStakingStorage.GetMinTotalNominatorStake());
        }
        
        /// <summary>
        /// >> ProxyNonces
        ///  An account nonce that represents the number of proxy transactions from this account
        /// </summary>
        [HttpGet("ProxyNonces")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.ParachainStakingStorage), "ProxyNoncesParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetProxyNonces(string key)
        {
            return this.Ok(_parachainStakingStorage.GetProxyNonces(key));
        }
    }
}
