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
using Substrate.ServiceLayer.Attributes;
using Substrate.Unique.NET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Unique.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AuraExtController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuraExtController : ControllerBase
    {
        
        private IAuraExtStorage _auraExtStorage;
        
        /// <summary>
        /// AuraExtController constructor.
        /// </summary>
        public AuraExtController(IAuraExtStorage auraExtStorage)
        {
            _auraExtStorage = auraExtStorage;
        }
        
        /// <summary>
        /// >> Authorities
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will always
        ///  be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        [HttpGet("Authorities")]
        [ProducesResponseType(typeof(Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.AuraExtStorage), "AuthoritiesParams")]
        public IActionResult GetAuthorities()
        {
            return this.Ok(_auraExtStorage.GetAuthorities());
        }
    }
}