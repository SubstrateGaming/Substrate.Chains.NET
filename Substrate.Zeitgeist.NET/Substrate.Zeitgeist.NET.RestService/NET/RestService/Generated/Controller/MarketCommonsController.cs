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
    /// MarketCommonsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class MarketCommonsController : ControllerBase
    {
        
        private IMarketCommonsStorage _marketCommonsStorage;
        
        /// <summary>
        /// MarketCommonsController constructor.
        /// </summary>
        public MarketCommonsController(IMarketCommonsStorage marketCommonsStorage)
        {
            _marketCommonsStorage = marketCommonsStorage;
        }
        
        /// <summary>
        /// >> Markets
        ///  Holds all markets
        /// </summary>
        [HttpGet("Markets")]
        [ProducesResponseType(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.Market), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.MarketCommonsStorage), "MarketsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U128))]
        public IActionResult GetMarkets(string key)
        {
            return this.Ok(_marketCommonsStorage.GetMarkets(key));
        }
        
        /// <summary>
        /// >> MarketCounter
        ///  The number of markets that have been created (including removed markets) and the next
        ///  identifier for a created market.
        /// </summary>
        [HttpGet("MarketCounter")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.MarketCommonsStorage), "MarketCounterParams")]
        public IActionResult GetMarketCounter()
        {
            return this.Ok(_marketCommonsStorage.GetMarketCounter());
        }
        
        /// <summary>
        /// >> MarketPool
        ///  Maps a market ID to a related pool ID. It is up to the caller to keep and sync valid
        ///  existent markets with valid existent pools.
        /// 
        ///  Beware! DEPRECATED as of v0.5.0.
        /// </summary>
        [HttpGet("MarketPool")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage.MarketCommonsStorage), "MarketPoolParams", typeof(Substrate.NetApi.Model.Types.Primitive.U128))]
        public IActionResult GetMarketPool(string key)
        {
            return this.Ok(_marketCommonsStorage.GetMarketPool(key));
        }
    }
}