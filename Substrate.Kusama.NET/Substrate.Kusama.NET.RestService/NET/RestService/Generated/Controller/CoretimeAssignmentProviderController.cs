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
    /// CoretimeAssignmentProviderController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CoretimeAssignmentProviderController : ControllerBase
    {
        
        private ICoretimeAssignmentProviderStorage _coretimeAssignmentProviderStorage;
        
        /// <summary>
        /// CoretimeAssignmentProviderController constructor.
        /// </summary>
        public CoretimeAssignmentProviderController(ICoretimeAssignmentProviderStorage coretimeAssignmentProviderStorage)
        {
            _coretimeAssignmentProviderStorage = coretimeAssignmentProviderStorage;
        }
        
        /// <summary>
        /// >> CoreSchedules
        ///  Scheduled assignment sets.
        /// 
        ///  Assignments as of the given block number. They will go into state once the block number is
        ///  reached (and replace whatever was in there before).
        /// </summary>
        [HttpGet("CoreSchedules")]
        [ProducesResponseType(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_coretime.Schedule), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CoretimeAssignmentProviderStorage), "CoreSchedulesParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.CoreIndex>))]
        public IActionResult GetCoreSchedules(string key)
        {
            return this.Ok(_coretimeAssignmentProviderStorage.GetCoreSchedules(key));
        }
        
        /// <summary>
        /// >> CoreDescriptors
        ///  Assignments which are currently active.
        /// 
        ///  They will be picked from `PendingAssignments` once we reach the scheduled block number in
        ///  `PendingAssignments`.
        /// </summary>
        [HttpGet("CoreDescriptors")]
        [ProducesResponseType(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_coretime.CoreDescriptor), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CoretimeAssignmentProviderStorage), "CoreDescriptorsParams", typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.CoreIndex))]
        public IActionResult GetCoreDescriptors(string key)
        {
            return this.Ok(_coretimeAssignmentProviderStorage.GetCoreDescriptors(key));
        }
    }
}