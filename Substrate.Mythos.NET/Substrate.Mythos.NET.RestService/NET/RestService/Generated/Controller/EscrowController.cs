//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Mythos.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Mythos.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// EscrowController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class EscrowController : ControllerBase
    {
        
        private IEscrowStorage _escrowStorage;
        
        /// <summary>
        /// EscrowController constructor.
        /// </summary>
        public EscrowController(IEscrowStorage escrowStorage)
        {
            _escrowStorage = escrowStorage;
        }
        
        /// <summary>
        /// >> Deposits
        /// </summary>
        [HttpGet("Deposits")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Mythos.NET.NetApiExt.Generated.Storage.EscrowStorage), "DepositsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Mythos.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.Mythos.NET.NetApiExt.Generated.Model.account.AccountId20>))]
        public IActionResult GetDeposits(string key)
        {
            return this.Ok(_escrowStorage.GetDeposits(key));
        }
    }
}
