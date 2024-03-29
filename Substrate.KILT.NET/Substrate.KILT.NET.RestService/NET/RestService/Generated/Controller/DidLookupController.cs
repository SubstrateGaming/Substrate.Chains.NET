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
    /// DidLookupController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class DidLookupController : ControllerBase
    {
        
        private IDidLookupStorage _didLookupStorage;
        
        /// <summary>
        /// DidLookupController constructor.
        /// </summary>
        public DidLookupController(IDidLookupStorage didLookupStorage)
        {
            _didLookupStorage = didLookupStorage;
        }
        
        /// <summary>
        /// >> ConnectedDids
        ///  Mapping from account identifiers to DIDs.
        /// </summary>
        [HttpGet("ConnectedDids")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_did_lookup.connection_record.ConnectionRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.DidLookupStorage), "ConnectedDidsParams", typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_did_lookup.linkable_account.EnumLinkableAccountId))]
        public IActionResult GetConnectedDids(string key)
        {
            return this.Ok(_didLookupStorage.GetConnectedDids(key));
        }
        
        /// <summary>
        /// >> ConnectedAccounts
        ///  Mapping from (DID + account identifier) -> ().
        ///  The empty tuple is used as a sentinel value to simply indicate the
        ///  presence of a given tuple in the map.
        /// </summary>
        [HttpGet("ConnectedAccounts")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.DidLookupStorage), "ConnectedAccountsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_did_lookup.linkable_account.EnumLinkableAccountId>))]
        public IActionResult GetConnectedAccounts(string key)
        {
            return this.Ok(_didLookupStorage.GetConnectedAccounts(key));
        }
    }
}
