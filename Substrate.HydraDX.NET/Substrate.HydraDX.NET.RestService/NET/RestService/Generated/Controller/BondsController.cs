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
    /// BondsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BondsController : ControllerBase
    {
        
        private IBondsStorage _bondsStorage;
        
        /// <summary>
        /// BondsController constructor.
        /// </summary>
        public BondsController(IBondsStorage bondsStorage)
        {
            _bondsStorage = bondsStorage;
        }
        
        /// <summary>
        /// >> BondIds
        ///  Registered bond ids.
        ///  Maps (underlying asset ID, maturity) -> bond ID
        /// </summary>
        [HttpGet("BondIds")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.BondsStorage), "BondIdsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U64>))]
        public IActionResult GetBondIds(string key)
        {
            return this.Ok(_bondsStorage.GetBondIds(key));
        }
        
        /// <summary>
        /// >> Bonds
        ///  Registered bonds.
        ///  Maps bond ID -> (underlying asset ID, maturity)
        /// </summary>
        [HttpGet("Bonds")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U64>), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.BondsStorage), "BondsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetBonds(string key)
        {
            return this.Ok(_bondsStorage.GetBonds(key));
        }
    }
}