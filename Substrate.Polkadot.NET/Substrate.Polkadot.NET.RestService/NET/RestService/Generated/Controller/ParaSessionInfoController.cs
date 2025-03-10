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
    /// ParaSessionInfoController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParaSessionInfoController : ControllerBase
    {
        
        private IParaSessionInfoStorage _paraSessionInfoStorage;
        
        /// <summary>
        /// ParaSessionInfoController constructor.
        /// </summary>
        public ParaSessionInfoController(IParaSessionInfoStorage paraSessionInfoStorage)
        {
            _paraSessionInfoStorage = paraSessionInfoStorage;
        }
        
        /// <summary>
        /// >> AssignmentKeysUnsafe
        ///  Assignment keys for the current session.
        ///  Note that this API is private due to it being prone to 'off-by-one' at session boundaries.
        ///  When in doubt, use `Sessions` API instead.
        /// </summary>
        [HttpGet("AssignmentKeysUnsafe")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSessionInfoStorage), "AssignmentKeysUnsafeParams")]
        public IActionResult GetAssignmentKeysUnsafe()
        {
            return this.Ok(_paraSessionInfoStorage.GetAssignmentKeysUnsafe());
        }
        
        /// <summary>
        /// >> EarliestStoredSession
        ///  The earliest session for which previous session info is stored.
        /// </summary>
        [HttpGet("EarliestStoredSession")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSessionInfoStorage), "EarliestStoredSessionParams")]
        public IActionResult GetEarliestStoredSession()
        {
            return this.Ok(_paraSessionInfoStorage.GetEarliestStoredSession());
        }
        
        /// <summary>
        /// >> Sessions
        ///  Session information in a rolling window.
        ///  Should have an entry in range `EarliestStoredSession..=CurrentSessionIndex`.
        ///  Does not have any entries before the session index in the first session change notification.
        /// </summary>
        [HttpGet("Sessions")]
        [ProducesResponseType(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.SessionInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSessionInfoStorage), "SessionsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetSessions(string key)
        {
            return this.Ok(_paraSessionInfoStorage.GetSessions(key));
        }
        
        /// <summary>
        /// >> AccountKeys
        ///  The validator account keys of the validators actively participating in parachain consensus.
        /// </summary>
        [HttpGet("AccountKeys")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSessionInfoStorage), "AccountKeysParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAccountKeys(string key)
        {
            return this.Ok(_paraSessionInfoStorage.GetAccountKeys(key));
        }
        
        /// <summary>
        /// >> SessionExecutorParams
        ///  Executor parameter set for a given session index
        /// </summary>
        [HttpGet("SessionExecutorParams")]
        [ProducesResponseType(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.executor_params.ExecutorParams), 200)]
        [StorageKeyBuilder(typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Storage.ParaSessionInfoStorage), "SessionExecutorParamsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetSessionExecutorParams(string key)
        {
            return this.Ok(_paraSessionInfoStorage.GetSessionExecutorParams(key));
        }
    }
}
