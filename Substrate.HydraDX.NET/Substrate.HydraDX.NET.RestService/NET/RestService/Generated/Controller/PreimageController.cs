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
    /// PreimageController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class PreimageController : ControllerBase
    {
        
        private IPreimageStorage _preimageStorage;
        
        /// <summary>
        /// PreimageController constructor.
        /// </summary>
        public PreimageController(IPreimageStorage preimageStorage)
        {
            _preimageStorage = preimageStorage;
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        [HttpGet("StatusFor")]
        [ProducesResponseType(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.PreimageStorage), "StatusForParams", typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetStatusFor(string key)
        {
            return this.Ok(_preimageStorage.GetStatusFor(key));
        }
        
        /// <summary>
        /// >> PreimageFor
        /// </summary>
        [HttpGet("PreimageFor")]
        [ProducesResponseType(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT17), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.PreimageStorage), "PreimageForParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetPreimageFor(string key)
        {
            return this.Ok(_preimageStorage.GetPreimageFor(key));
        }
    }
}
