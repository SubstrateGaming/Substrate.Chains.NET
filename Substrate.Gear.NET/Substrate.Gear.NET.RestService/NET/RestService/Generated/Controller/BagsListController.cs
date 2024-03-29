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
    /// BagsListController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BagsListController : ControllerBase
    {
        
        private IBagsListStorage _bagsListStorage;
        
        /// <summary>
        /// BagsListController constructor.
        /// </summary>
        public BagsListController(IBagsListStorage bagsListStorage)
        {
            _bagsListStorage = bagsListStorage;
        }
        
        /// <summary>
        /// >> ListNodes
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        [HttpGet("ListNodes")]
        [ProducesResponseType(typeof(Substrate.Gear.NET.NetApiExt.Generated.Model.pallet_bags_list.list.Node), 200)]
        [StorageKeyBuilder(typeof(Substrate.Gear.NET.NetApiExt.Generated.Storage.BagsListStorage), "ListNodesParams", typeof(Substrate.Gear.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetListNodes(string key)
        {
            return this.Ok(_bagsListStorage.GetListNodes(key));
        }
        
        /// <summary>
        /// >> CounterForListNodes
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForListNodes")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Gear.NET.NetApiExt.Generated.Storage.BagsListStorage), "CounterForListNodesParams")]
        public IActionResult GetCounterForListNodes()
        {
            return this.Ok(_bagsListStorage.GetCounterForListNodes());
        }
        
        /// <summary>
        /// >> ListBags
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        [HttpGet("ListBags")]
        [ProducesResponseType(typeof(Substrate.Gear.NET.NetApiExt.Generated.Model.pallet_bags_list.list.Bag), 200)]
        [StorageKeyBuilder(typeof(Substrate.Gear.NET.NetApiExt.Generated.Storage.BagsListStorage), "ListBagsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U64))]
        public IActionResult GetListBags(string key)
        {
            return this.Ok(_bagsListStorage.GetListBags(key));
        }
    }
}
