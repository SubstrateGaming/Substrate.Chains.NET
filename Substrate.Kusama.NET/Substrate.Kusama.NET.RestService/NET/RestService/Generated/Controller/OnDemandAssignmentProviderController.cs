//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Kusama.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Kusama.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// OnDemandAssignmentProviderController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class OnDemandAssignmentProviderController : ControllerBase
    {
        
        private IOnDemandAssignmentProviderStorage _onDemandAssignmentProviderStorage;
        
        /// <summary>
        /// OnDemandAssignmentProviderController constructor.
        /// </summary>
        public OnDemandAssignmentProviderController(IOnDemandAssignmentProviderStorage onDemandAssignmentProviderStorage)
        {
            _onDemandAssignmentProviderStorage = onDemandAssignmentProviderStorage;
        }
        
        /// <summary>
        /// >> SpotTraffic
        ///  Keeps track of the multiplier used to calculate the current spot price for the on demand
        ///  assigner.
        /// </summary>
        [HttpGet("SpotTraffic")]
        [ProducesResponseType(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage), "SpotTrafficParams")]
        public IActionResult GetSpotTraffic()
        {
            return this.Ok(_onDemandAssignmentProviderStorage.GetSpotTraffic());
        }
        
        /// <summary>
        /// >> OnDemandQueue
        ///  The order storage entry. Uses a VecDeque to be able to push to the front of the
        ///  queue from the scheduler on session boundaries.
        /// </summary>
        [HttpGet("OnDemandQueue")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.EnqueuedOrder>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage), "OnDemandQueueParams")]
        public IActionResult GetOnDemandQueue()
        {
            return this.Ok(_onDemandAssignmentProviderStorage.GetOnDemandQueue());
        }
        
        /// <summary>
        /// >> ParaIdAffinity
        ///  Maps a `ParaId` to `CoreIndex` and keeps track of how many assignments the scheduler has in
        ///  it's lookahead. Keeping track of this affinity prevents parallel execution of the same
        ///  `ParaId` on two or more `CoreIndex`es.
        /// </summary>
        [HttpGet("ParaIdAffinity")]
        [ProducesResponseType(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.CoreAffinityCount), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage), "ParaIdAffinityParams", typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id))]
        public IActionResult GetParaIdAffinity(string key)
        {
            return this.Ok(_onDemandAssignmentProviderStorage.GetParaIdAffinity(key));
        }
    }
}