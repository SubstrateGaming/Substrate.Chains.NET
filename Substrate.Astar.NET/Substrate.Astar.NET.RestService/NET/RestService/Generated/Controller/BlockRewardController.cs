//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Astar.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Astar.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BlockRewardController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BlockRewardController : ControllerBase
    {
        
        private IBlockRewardStorage _blockRewardStorage;
        
        /// <summary>
        /// BlockRewardController constructor.
        /// </summary>
        public BlockRewardController(IBlockRewardStorage blockRewardStorage)
        {
            _blockRewardStorage = blockRewardStorage;
        }
        
        /// <summary>
        /// >> RewardDistributionConfigStorage
        /// </summary>
        [HttpGet("RewardDistributionConfigStorage")]
        [ProducesResponseType(typeof(Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig), 200)]
        [StorageKeyBuilder(typeof(Substrate.Astar.NET.NetApiExt.Generated.Storage.BlockRewardStorage), "RewardDistributionConfigStorageParams")]
        public IActionResult GetRewardDistributionConfigStorage()
        {
            return this.Ok(_blockRewardStorage.GetRewardDistributionConfigStorage());
        }
    }
}