//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Enjin.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Enjin.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AuctionsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AuctionsController : ControllerBase
    {
        
        private IAuctionsStorage _auctionsStorage;
        
        /// <summary>
        /// AuctionsController constructor.
        /// </summary>
        public AuctionsController(IAuctionsStorage auctionsStorage)
        {
            _auctionsStorage = auctionsStorage;
        }
        
        /// <summary>
        /// >> AuctionCounter
        ///  Number of auctions started so far.
        /// </summary>
        [HttpGet("AuctionCounter")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AuctionsStorage), "AuctionCounterParams")]
        public IActionResult GetAuctionCounter()
        {
            return this.Ok(_auctionsStorage.GetAuctionCounter());
        }
        
        /// <summary>
        /// >> AuctionInfo
        ///  Information relating to the current auction, if there is one.
        /// 
        ///  The first item in the tuple is the lease period index that the first of the four
        ///  contiguous lease periods on auction is for. The second is the block number when the
        ///  auction will "begin to end", i.e. the first block of the Ending Period of the auction.
        /// </summary>
        [HttpGet("AuctionInfo")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AuctionsStorage), "AuctionInfoParams")]
        public IActionResult GetAuctionInfo()
        {
            return this.Ok(_auctionsStorage.GetAuctionInfo());
        }
        
        /// <summary>
        /// >> ReservedAmounts
        ///  Amounts currently reserved in the accounts of the bidders currently winning
        ///  (sub-)ranges.
        /// </summary>
        [HttpGet("ReservedAmounts")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AuctionsStorage), "ReservedAmountsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>))]
        public IActionResult GetReservedAmounts(string key)
        {
            return this.Ok(_auctionsStorage.GetReservedAmounts(key));
        }
        
        /// <summary>
        /// >> Winning
        ///  The winning bids for each of the 10 ranges at each sample in the final Ending Period of
        ///  the current auction. The map's key is the 0-based index into the Sample Size. The
        ///  first sample of the ending period is 0; the last is `Sample Size - 1`.
        /// </summary>
        [HttpGet("Winning")]
        [ProducesResponseType(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr36BaseOpt), 200)]
        [StorageKeyBuilder(typeof(Substrate.Enjin.NET.NetApiExt.Generated.Storage.AuctionsStorage), "WinningParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetWinning(string key)
        {
            return this.Ok(_auctionsStorage.GetWinning(key));
        }
    }
}
