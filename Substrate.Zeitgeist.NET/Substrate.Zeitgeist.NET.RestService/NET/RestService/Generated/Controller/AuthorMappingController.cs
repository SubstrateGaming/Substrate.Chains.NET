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
using Substrate.Zeitgeist.NET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Zeitgeist.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AuthorMappingController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuthorMappingController : ControllerBase
    {
        
        private IAuthorMappingStorage _authorMappingStorage;
        
        /// <summary>
        /// AuthorMappingController constructor.
        /// </summary>
        public AuthorMappingController(IAuthorMappingStorage authorMappingStorage)
        {
            _authorMappingStorage = authorMappingStorage;
        }
        
        /// <summary>
        /// >> MappingWithDeposit
        ///  We maintain a mapping from the NimbusIds used in the consensus layer
        ///  to the AccountIds runtime.
        /// </summary>
        [HttpGet("MappingWithDeposit")]
        [ProducesResponseType(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.AuthorMappingStorage), "MappingWithDepositParams", typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public))]
        public IActionResult GetMappingWithDeposit(string key)
        {
            return this.Ok(_authorMappingStorage.GetMappingWithDeposit(key));
        }
        
        /// <summary>
        /// >> NimbusLookup
        ///  We maintain a reverse mapping from AccountIds to NimbusIDS
        /// </summary>
        [HttpGet("NimbusLookup")]
        [ProducesResponseType(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.AuthorMappingStorage), "NimbusLookupParams", typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetNimbusLookup(string key)
        {
            return this.Ok(_authorMappingStorage.GetNimbusLookup(key));
        }
    }
}
