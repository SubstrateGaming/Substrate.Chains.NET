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
    /// Web3NamesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class Web3NamesController : ControllerBase
    {
        
        private IWeb3NamesStorage _web3NamesStorage;
        
        /// <summary>
        /// Web3NamesController constructor.
        /// </summary>
        public Web3NamesController(IWeb3NamesStorage web3NamesStorage)
        {
            _web3NamesStorage = web3NamesStorage;
        }
        
        /// <summary>
        /// >> Owner
        ///  Map of name -> ownership details.
        /// </summary>
        [HttpGet("Owner")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_web3_names.web3_name.Web3NameOwnership), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.Web3NamesStorage), "OwnerParams", typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_web3_names.web3_name.AsciiWeb3Name))]
        public IActionResult GetOwner(string key)
        {
            return this.Ok(_web3NamesStorage.GetOwner(key));
        }
        
        /// <summary>
        /// >> Names
        ///  Map of owner -> name.
        /// </summary>
        [HttpGet("Names")]
        [ProducesResponseType(typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_web3_names.web3_name.AsciiWeb3Name), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.Web3NamesStorage), "NamesParams", typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetNames(string key)
        {
            return this.Ok(_web3NamesStorage.GetNames(key));
        }
        
        /// <summary>
        /// >> Banned
        ///  Map of name -> ().
        /// 
        ///  If a name key is present, the name is currently banned.
        /// </summary>
        [HttpGet("Banned")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.KILT.NET.NetApiExt.Generated.Storage.Web3NamesStorage), "BannedParams", typeof(Substrate.KILT.NET.NetApiExt.Generated.Model.pallet_web3_names.web3_name.AsciiWeb3Name))]
        public IActionResult GetBanned(string key)
        {
            return this.Ok(_web3NamesStorage.GetBanned(key));
        }
    }
}