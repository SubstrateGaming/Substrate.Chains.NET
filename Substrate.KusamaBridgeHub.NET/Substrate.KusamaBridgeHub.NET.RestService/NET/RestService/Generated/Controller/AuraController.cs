//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.KusamaBridgeHub.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.KusamaBridgeHub.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AuraController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuraController : ControllerBase
    {
        
        private IAuraStorage _auraStorage;
        
        /// <summary>
        /// AuraController constructor.
        /// </summary>
        public AuraController(IAuraStorage auraStorage)
        {
            _auraStorage = auraStorage;
        }
        
        /// <summary>
        /// >> Authorities
        ///  The current authority set.
        /// </summary>
        [HttpGet("Authorities")]
        [ProducesResponseType(typeof(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8), 200)]
        [StorageKeyBuilder(typeof(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Storage.AuraStorage), "AuthoritiesParams")]
        public IActionResult GetAuthorities()
        {
            return this.Ok(_auraStorage.GetAuthorities());
        }
        
        /// <summary>
        /// >> CurrentSlot
        ///  The current slot of this block.
        /// 
        ///  This will be set in `on_initialize`.
        /// </summary>
        [HttpGet("CurrentSlot")]
        [ProducesResponseType(typeof(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot), 200)]
        [StorageKeyBuilder(typeof(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Storage.AuraStorage), "CurrentSlotParams")]
        public IActionResult GetCurrentSlot()
        {
            return this.Ok(_auraStorage.GetCurrentSlot());
        }
    }
}