//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Moonsama.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Moonsama.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// EVMController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class EVMController : ControllerBase
    {
        
        private IEVMStorage _eVMStorage;
        
        /// <summary>
        /// EVMController constructor.
        /// </summary>
        public EVMController(IEVMStorage eVMStorage)
        {
            _eVMStorage = eVMStorage;
        }
        
        /// <summary>
        /// >> AccountCodes
        /// </summary>
        [HttpGet("AccountCodes")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage), "AccountCodesParams", typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H160))]
        public IActionResult GetAccountCodes(string key)
        {
            return this.Ok(_eVMStorage.GetAccountCodes(key));
        }
        
        /// <summary>
        /// >> AccountCodesMetadata
        /// </summary>
        [HttpGet("AccountCodesMetadata")]
        [ProducesResponseType(typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm.CodeMetadata), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage), "AccountCodesMetadataParams", typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H160))]
        public IActionResult GetAccountCodesMetadata(string key)
        {
            return this.Ok(_eVMStorage.GetAccountCodesMetadata(key));
        }
        
        /// <summary>
        /// >> AccountStorages
        /// </summary>
        [HttpGet("AccountStorages")]
        [ProducesResponseType(typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H256), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage), "AccountStoragesParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H160, Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetAccountStorages(string key)
        {
            return this.Ok(_eVMStorage.GetAccountStorages(key));
        }
    }
}
