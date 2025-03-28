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
using Substrate.Polkadot.NET.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Polkadot.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ParasSharedController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParasSharedController : ControllerBase
    {
        
        private IParasSharedStorage _parasSharedStorage;
        
        /// <summary>
        /// ParasSharedController constructor.
        /// </summary>
        public ParasSharedController(IParasSharedStorage parasSharedStorage)
        {
            _parasSharedStorage = parasSharedStorage;
        }
        
        /// <summary>
        /// >> CurrentSessionIndex
        ///  The current session index.
        /// </summary>
        [HttpGet("CurrentSessionIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParasSharedStorage), "CurrentSessionIndexParams")]
        public IActionResult GetCurrentSessionIndex()
        {
            return this.Ok(_parasSharedStorage.GetCurrentSessionIndex());
        }
        
        /// <summary>
        /// >> ActiveValidatorIndices
        ///  All the validators actively participating in parachain consensus.
        ///  Indices are into the broader validator set.
        /// </summary>
        [HttpGet("ActiveValidatorIndices")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.ValidatorIndex>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParasSharedStorage), "ActiveValidatorIndicesParams")]
        public IActionResult GetActiveValidatorIndices()
        {
            return this.Ok(_parasSharedStorage.GetActiveValidatorIndices());
        }
        
        /// <summary>
        /// >> ActiveValidatorKeys
        ///  The parachain attestation keys of the validators actively participating in parachain
        ///  consensus. This should be the same length as `ActiveValidatorIndices`.
        /// </summary>
        [HttpGet("ActiveValidatorKeys")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParasSharedStorage), "ActiveValidatorKeysParams")]
        public IActionResult GetActiveValidatorKeys()
        {
            return this.Ok(_parasSharedStorage.GetActiveValidatorKeys());
        }
        
        /// <summary>
        /// >> AllowedRelayParents
        ///  All allowed relay-parents.
        /// </summary>
        [HttpGet("AllowedRelayParents")]
        [ProducesResponseType(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared.AllowedRelayParentsTracker), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParasSharedStorage), "AllowedRelayParentsParams")]
        public IActionResult GetAllowedRelayParents()
        {
            return this.Ok(_parasSharedStorage.GetAllowedRelayParents());
        }
    }
}
