//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Gear.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Gear.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// GearBankController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class GearBankController : ControllerBase
    {
        
        private IGearBankStorage _gearBankStorage;
        
        /// <summary>
        /// GearBankController constructor.
        /// </summary>
        public GearBankController(IGearBankStorage gearBankStorage)
        {
            _gearBankStorage = gearBankStorage;
        }
        
        /// <summary>
        /// >> Bank
        /// </summary>
        [HttpGet("Bank")]
        [ProducesResponseType(typeof(Substrate.Gear.NET.NetApiExt.Generated.Model.pallet_gear_bank.pallet.BankAccount), 200)]
        [StorageKeyBuilder(typeof(Substrate.Gear.NET.NetApiExt.Generated.Storage.GearBankStorage), "BankParams", typeof(Substrate.Gear.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetBank(string key)
        {
            return this.Ok(_gearBankStorage.GetBank(key));
        }
        
        /// <summary>
        /// >> UnusedValue
        /// </summary>
        [HttpGet("UnusedValue")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Gear.NET.NetApiExt.Generated.Storage.GearBankStorage), "UnusedValueParams")]
        public IActionResult GetUnusedValue()
        {
            return this.Ok(_gearBankStorage.GetUnusedValue());
        }
    }
}
