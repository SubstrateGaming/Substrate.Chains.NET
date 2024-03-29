//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Enjin.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Enjin.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AssignedSlotsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AssignedSlotsController : ControllerBase
    {
        
        private IAssignedSlotsStorage _assignedSlotsStorage;
        
        /// <summary>
        /// AssignedSlotsController constructor.
        /// </summary>
        public AssignedSlotsController(IAssignedSlotsStorage assignedSlotsStorage)
        {
            _assignedSlotsStorage = assignedSlotsStorage;
        }
        
        /// <summary>
        /// >> PermanentSlots
        ///  Assigned permanent slots, with their start lease period, and duration.
        /// </summary>
        [HttpGet("PermanentSlots")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AssignedSlotsStorage), "PermanentSlotsParams", typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id))]
        public IActionResult GetPermanentSlots(string key)
        {
            return this.Ok(_assignedSlotsStorage.GetPermanentSlots(key));
        }
        
        /// <summary>
        /// >> PermanentSlotCount
        ///  Number of assigned (and active) permanent slots.
        /// </summary>
        [HttpGet("PermanentSlotCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AssignedSlotsStorage), "PermanentSlotCountParams")]
        public IActionResult GetPermanentSlotCount()
        {
            return this.Ok(_assignedSlotsStorage.GetPermanentSlotCount());
        }
        
        /// <summary>
        /// >> TemporarySlots
        ///  Assigned temporary slots.
        /// </summary>
        [HttpGet("TemporarySlots")]
        [ProducesResponseType(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_common.assigned_slots.ParachainTemporarySlot), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AssignedSlotsStorage), "TemporarySlotsParams", typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id))]
        public IActionResult GetTemporarySlots(string key)
        {
            return this.Ok(_assignedSlotsStorage.GetTemporarySlots(key));
        }
        
        /// <summary>
        /// >> TemporarySlotCount
        ///  Number of assigned temporary slots.
        /// </summary>
        [HttpGet("TemporarySlotCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AssignedSlotsStorage), "TemporarySlotCountParams")]
        public IActionResult GetTemporarySlotCount()
        {
            return this.Ok(_assignedSlotsStorage.GetTemporarySlotCount());
        }
        
        /// <summary>
        /// >> ActiveTemporarySlotCount
        ///  Number of active temporary slots in current slot lease period.
        /// </summary>
        [HttpGet("ActiveTemporarySlotCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AssignedSlotsStorage), "ActiveTemporarySlotCountParams")]
        public IActionResult GetActiveTemporarySlotCount()
        {
            return this.Ok(_assignedSlotsStorage.GetActiveTemporarySlotCount());
        }
    }
}
