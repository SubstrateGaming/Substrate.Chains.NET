//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.Polkadot.NET.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Polkadot.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ParaSchedulerController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParaSchedulerController : ControllerBase
    {
        
        private IParaSchedulerStorage _paraSchedulerStorage;
        
        /// <summary>
        /// ParaSchedulerController constructor.
        /// </summary>
        public ParaSchedulerController(IParaSchedulerStorage paraSchedulerStorage)
        {
            _paraSchedulerStorage = paraSchedulerStorage;
        }
        
        /// <summary>
        /// >> ValidatorGroups
        ///  All the validator groups. One for each core. Indices are into `ActiveValidators` - not the
        ///  broader set of Polkadot validators, but instead just the subset used for parachains during
        ///  this session.
        /// 
        ///  Bound: The number of cores is the sum of the numbers of parachains and parathread
        ///  multiplexers. Reasonably, 100-1000. The dominant factor is the number of validators: safe
        ///  upper bound at 10k.
        /// </summary>
        [HttpGet("ValidatorGroups")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSchedulerStorage), "ValidatorGroupsParams")]
        public IActionResult GetValidatorGroups()
        {
            return this.Ok(_paraSchedulerStorage.GetValidatorGroups());
        }
        
        /// <summary>
        /// >> AvailabilityCores
        ///  One entry for each availability core. The i'th parachain belongs to the i'th core, with the
        ///  remaining cores all being on demand parachain multiplexers.
        /// 
        ///  Bounded by the maximum of either of these two values:
        ///    * The number of parachains and parathread multiplexers
        ///    * The number of validators divided by `configuration.max_validators_per_core`.
        /// </summary>
        [HttpGet("AvailabilityCores")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler.pallet.EnumCoreOccupied>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSchedulerStorage), "AvailabilityCoresParams")]
        public IActionResult GetAvailabilityCores()
        {
            return this.Ok(_paraSchedulerStorage.GetAvailabilityCores());
        }
        
        /// <summary>
        /// >> SessionStartBlock
        ///  The block number where the session start occurred. Used to track how many group rotations
        ///  have occurred.
        /// 
        ///  Note that in the context of parachains modules the session change is signaled during
        ///  the block and enacted at the end of the block (at the finalization stage, to be exact).
        ///  Thus for all intents and purposes the effect of the session change is observed at the
        ///  block following the session change, block number of which we save in this storage value.
        /// </summary>
        [HttpGet("SessionStartBlock")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSchedulerStorage), "SessionStartBlockParams")]
        public IActionResult GetSessionStartBlock()
        {
            return this.Ok(_paraSchedulerStorage.GetSessionStartBlock());
        }
        
        /// <summary>
        /// >> ClaimQueue
        ///  One entry for each availability core. The `VecDeque` represents the assignments to be
        ///  scheduled on that core. The value contained here will not be valid after the end of
        ///  a block. Runtime APIs should be used to determine scheduled cores for the upcoming block.
        /// </summary>
        [HttpGet("ClaimQueue")]
        [ProducesResponseType(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base.BTreeMapT4), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSchedulerStorage), "ClaimQueueParams")]
        public IActionResult GetClaimQueue()
        {
            return this.Ok(_paraSchedulerStorage.GetClaimQueue());
        }
    }
}
