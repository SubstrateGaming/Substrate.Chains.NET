//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Aventus.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Aventus.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AvnProxyController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AvnProxyController : ControllerBase
    {
        
        private IAvnProxyStorage _avnProxyStorage;
        
        /// <summary>
        /// AvnProxyController constructor.
        /// </summary>
        public AvnProxyController(IAvnProxyStorage avnProxyStorage)
        {
            _avnProxyStorage = avnProxyStorage;
        }
        
        /// <summary>
        /// >> PaymentNonces
        ///  An account nonce that represents the number of payments from this account
        ///  It is shared for all proxy transactions performed by that account
        /// </summary>
        [HttpGet("PaymentNonces")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.AvnProxyStorage), "PaymentNoncesParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetPaymentNonces(string key)
        {
            return this.Ok(_avnProxyStorage.GetPaymentNonces(key));
        }
    }
}