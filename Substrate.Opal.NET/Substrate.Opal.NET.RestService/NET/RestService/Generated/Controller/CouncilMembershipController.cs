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
using Substrate.Opal.NET.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Opal.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// CouncilMembershipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CouncilMembershipController : ControllerBase
    {
        
        private ICouncilMembershipStorage _councilMembershipStorage;
        
        /// <summary>
        /// CouncilMembershipController constructor.
        /// </summary>
        public CouncilMembershipController(ICouncilMembershipStorage councilMembershipStorage)
        {
            _councilMembershipStorage = councilMembershipStorage;
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT33), 200)]
        [StorageKeyBuilder(typeof(Substrate.Opal.NET.NetApiExt.Generated.Storage.CouncilMembershipStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_councilMembershipStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Opal.NET.NetApiExt.Generated.Storage.CouncilMembershipStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_councilMembershipStorage.GetPrime());
        }
    }
}