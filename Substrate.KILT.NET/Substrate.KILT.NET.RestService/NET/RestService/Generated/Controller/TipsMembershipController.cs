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
    /// TipsMembershipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TipsMembershipController : ControllerBase
    {
        
        private ITipsMembershipStorage _tipsMembershipStorage;
        
        /// <summary>
        /// TipsMembershipController constructor.
        /// </summary>
        public TipsMembershipController(ITipsMembershipStorage tipsMembershipStorage)
        {
            _tipsMembershipStorage = tipsMembershipStorage;
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT32), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.TipsMembershipStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_tipsMembershipStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.TipsMembershipStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_tipsMembershipStorage.GetPrime());
        }
    }
}