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
    /// AuthorizedController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuthorizedController : ControllerBase
    {
        
        private IAuthorizedStorage _authorizedStorage;
        
        /// <summary>
        /// AuthorizedController constructor.
        /// </summary>
        public AuthorizedController(IAuthorizedStorage authorizedStorage)
        {
            _authorizedStorage = authorizedStorage;
        }
        
        /// <summary>
        /// >> AuthorizedOutcomeReports
        ///  Maps the market id to the outcome reported by the authorized account.    
        /// </summary>
        [HttpGet("AuthorizedOutcomeReports")]
        [ProducesResponseType(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.AuthorityReport), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.AuthorizedStorage), "AuthorizedOutcomeReportsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U128))]
        public IActionResult GetAuthorizedOutcomeReports(string key)
        {
            return this.Ok(_authorizedStorage.GetAuthorizedOutcomeReports(key));
        }
    }
}
