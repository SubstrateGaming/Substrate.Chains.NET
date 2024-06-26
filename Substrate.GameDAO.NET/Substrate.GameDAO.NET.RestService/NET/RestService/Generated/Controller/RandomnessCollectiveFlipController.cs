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
    /// RandomnessCollectiveFlipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class RandomnessCollectiveFlipController : ControllerBase
    {
        
        private IRandomnessCollectiveFlipStorage _randomnessCollectiveFlipStorage;
        
        /// <summary>
        /// RandomnessCollectiveFlipController constructor.
        /// </summary>
        public RandomnessCollectiveFlipController(IRandomnessCollectiveFlipStorage randomnessCollectiveFlipStorage)
        {
            _randomnessCollectiveFlipStorage = randomnessCollectiveFlipStorage;
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        [HttpGet("RandomMaterial")]
        [ProducesResponseType(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT24), 200)]
        [StorageKeyBuilder(typeof(Substrate.GameDAO.NET.NetApiExt.Generated.Storage.RandomnessCollectiveFlipStorage), "RandomMaterialParams")]
        public IActionResult GetRandomMaterial()
        {
            return this.Ok(_randomnessCollectiveFlipStorage.GetRandomMaterial());
        }
    }
}
