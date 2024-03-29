//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.KILT.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.KILT.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// CtypeController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CtypeController : ControllerBase
    {
        
        private ICtypeStorage _ctypeStorage;
        
        /// <summary>
        /// CtypeController constructor.
        /// </summary>
        public CtypeController(ICtypeStorage ctypeStorage)
        {
            _ctypeStorage = ctypeStorage;
        }
        
        /// <summary>
        /// >> Ctypes
        ///  CTypes stored on chain.
        /// 
        ///  It maps from a CType hash to its creator and block number in which it
        ///  was created.
        /// </summary>
        [HttpGet("Ctypes")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.ctype_entry.CtypeEntry), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.CtypeStorage), "CtypesParams", typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCtypes(string key)
        {
            return this.Ok(_ctypeStorage.GetCtypes(key));
        }
    }
}
