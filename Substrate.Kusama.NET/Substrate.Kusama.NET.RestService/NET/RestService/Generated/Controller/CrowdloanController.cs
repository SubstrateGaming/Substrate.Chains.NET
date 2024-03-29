//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Kusama.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Kusama.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// CrowdloanController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CrowdloanController : ControllerBase
    {
        
        private ICrowdloanStorage _crowdloanStorage;
        
        /// <summary>
        /// CrowdloanController constructor.
        /// </summary>
        public CrowdloanController(ICrowdloanStorage crowdloanStorage)
        {
            _crowdloanStorage = crowdloanStorage;
        }
        
        /// <summary>
        /// >> Funds
        ///  Info on all of the funds.
        /// </summary>
        [HttpGet("Funds")]
        [ProducesResponseType(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.FundInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CrowdloanStorage), "FundsParams", typeof(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id))]
        public IActionResult GetFunds(string key)
        {
            return this.Ok(_crowdloanStorage.GetFunds(key));
        }
        
        /// <summary>
        /// >> NewRaise
        ///  The funds that have had additional contributions during the last block. This is used
        ///  in order to determine which funds should submit new or updated bids.
        /// </summary>
        [HttpGet("NewRaise")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CrowdloanStorage), "NewRaiseParams")]
        public IActionResult GetNewRaise()
        {
            return this.Ok(_crowdloanStorage.GetNewRaise());
        }
        
        /// <summary>
        /// >> EndingsCount
        ///  The number of auctions that have entered into their ending period so far.
        /// </summary>
        [HttpGet("EndingsCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CrowdloanStorage), "EndingsCountParams")]
        public IActionResult GetEndingsCount()
        {
            return this.Ok(_crowdloanStorage.GetEndingsCount());
        }
        
        /// <summary>
        /// >> NextFundIndex
        ///  Tracker for the next available fund index
        /// </summary>
        [HttpGet("NextFundIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Kusama.NET.NetApiExt.Generated.Storage.CrowdloanStorage), "NextFundIndexParams")]
        public IActionResult GetNextFundIndex()
        {
            return this.Ok(_crowdloanStorage.GetNextFundIndex());
        }
    }
}
