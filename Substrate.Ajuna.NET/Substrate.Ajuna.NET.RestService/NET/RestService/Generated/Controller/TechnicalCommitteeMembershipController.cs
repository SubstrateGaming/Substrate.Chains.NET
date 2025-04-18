//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Ajuna.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Ajuna.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// TechnicalCommitteeMembershipController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TechnicalCommitteeMembershipController : ControllerBase
    {
        
        private ITechnicalCommitteeMembershipStorage _technicalCommitteeMembershipStorage;
        
        /// <summary>
        /// TechnicalCommitteeMembershipController constructor.
        /// </summary>
        public TechnicalCommitteeMembershipController(ITechnicalCommitteeMembershipStorage technicalCommitteeMembershipStorage)
        {
            _technicalCommitteeMembershipStorage = technicalCommitteeMembershipStorage;
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeMembershipStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_technicalCommitteeMembershipStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeMembershipStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_technicalCommitteeMembershipStorage.GetPrime());
        }
    }
}
