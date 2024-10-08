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
using Substrate.PolkadotBridgeHub.NET.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.PolkadotBridgeHub.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// EthereumOutboundQueueController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class EthereumOutboundQueueController : ControllerBase
    {
        
        private IEthereumOutboundQueueStorage _ethereumOutboundQueueStorage;
        
        /// <summary>
        /// EthereumOutboundQueueController constructor.
        /// </summary>
        public EthereumOutboundQueueController(IEthereumOutboundQueueStorage ethereumOutboundQueueStorage)
        {
            _ethereumOutboundQueueStorage = ethereumOutboundQueueStorage;
        }
        
        /// <summary>
        /// >> Messages
        ///  Messages to be committed in the current block. This storage value is killed in
        ///  `on_initialize`, so should never go into block PoV.
        /// 
        ///  Is never read in the runtime, only by offchain message relayers.
        /// 
        ///  Inspired by the `frame_system::Pallet::Events` storage value
        /// </summary>
        [HttpGet("Messages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_pallet_outbound_queue.types.CommittedMessage>), 200)]
        [StorageKeyBuilder(typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage), "MessagesParams")]
        public IActionResult GetMessages()
        {
            return this.Ok(_ethereumOutboundQueueStorage.GetMessages());
        }
        
        /// <summary>
        /// >> MessageLeaves
        ///  Hashes of the ABI-encoded messages in the [`Messages`] storage value. Used to generate a
        ///  merkle root during `on_finalize`. This storage value is killed in
        ///  `on_initialize`, so should never go into block PoV.
        /// </summary>
        [HttpGet("MessageLeaves")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>), 200)]
        [StorageKeyBuilder(typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage), "MessageLeavesParams")]
        public IActionResult GetMessageLeaves()
        {
            return this.Ok(_ethereumOutboundQueueStorage.GetMessageLeaves());
        }
        
        /// <summary>
        /// >> Nonce
        ///  The current nonce for each message origin
        /// </summary>
        [HttpGet("Nonce")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage), "NonceParams", typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.ChannelId))]
        public IActionResult GetNonce(string key)
        {
            return this.Ok(_ethereumOutboundQueueStorage.GetNonce(key));
        }
        
        /// <summary>
        /// >> OperatingMode
        ///  The current operating mode of the pallet.
        /// </summary>
        [HttpGet("OperatingMode")]
        [ProducesResponseType(typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode), 200)]
        [StorageKeyBuilder(typeof(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage), "OperatingModeParams")]
        public IActionResult GetOperatingMode()
        {
            return this.Ok(_ethereumOutboundQueueStorage.GetOperatingMode());
        }
    }
}
