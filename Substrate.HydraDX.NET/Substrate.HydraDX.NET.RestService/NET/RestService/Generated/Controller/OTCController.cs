//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.HydraDX.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.HydraDX.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// OTCController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class OTCController : ControllerBase
    {
        
        private IOTCStorage _oTCStorage;
        
        /// <summary>
        /// OTCController constructor.
        /// </summary>
        public OTCController(IOTCStorage oTCStorage)
        {
            _oTCStorage = oTCStorage;
        }
        
        /// <summary>
        /// >> NextOrderId
        ///  ID sequencer for Orders
        /// </summary>
        [HttpGet("NextOrderId")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.OTCStorage), "NextOrderIdParams")]
        public IActionResult GetNextOrderId()
        {
            return this.Ok(_oTCStorage.GetNextOrderId());
        }
        
        /// <summary>
        /// >> Orders
        /// </summary>
        [HttpGet("Orders")]
        [ProducesResponseType(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_otc.Order), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.OTCStorage), "OrdersParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetOrders(string key)
        {
            return this.Ok(_oTCStorage.GetOrders(key));
        }
    }
}