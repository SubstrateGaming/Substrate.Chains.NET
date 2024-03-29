//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Moonbeam.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Moonbeam.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// XcmTransactorController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class XcmTransactorController : ControllerBase
    {
        
        private IXcmTransactorStorage _xcmTransactorStorage;
        
        /// <summary>
        /// XcmTransactorController constructor.
        /// </summary>
        public XcmTransactorController(IXcmTransactorStorage xcmTransactorStorage)
        {
            _xcmTransactorStorage = xcmTransactorStorage;
        }
        
        /// <summary>
        /// >> IndexToAccount
        ///  Since we are using pallet-utility for account derivation (through AsDerivative),
        ///  we need to provide an index for the account derivation. This storage item stores the index
        ///  assigned for a given local account. These indices are usable as derivative in the relay chain
        /// </summary>
        [HttpGet("IndexToAccount")]
        [ProducesResponseType(typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Storage.XcmTransactorStorage), "IndexToAccountParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetIndexToAccount(string key)
        {
            return this.Ok(_xcmTransactorStorage.GetIndexToAccount(key));
        }
        
        /// <summary>
        /// >> TransactInfoWithWeightLimit
        ///  Stores the transact info of a MultiLocation. This defines how much extra weight we need to
        ///  add when we want to transact in the destination chain and maximum amount of weight allowed
        ///  by the destination chain
        /// </summary>
        [HttpGet("TransactInfoWithWeightLimit")]
        [ProducesResponseType(typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_xcm_transactor.pallet.RemoteTransactInfoWithMaxWeight), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Storage.XcmTransactorStorage), "TransactInfoWithWeightLimitParams", typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation))]
        public IActionResult GetTransactInfoWithWeightLimit(string key)
        {
            return this.Ok(_xcmTransactorStorage.GetTransactInfoWithWeightLimit(key));
        }
        
        /// <summary>
        /// >> DestinationAssetFeePerSecond
        ///  Stores the fee per second for an asset in its reserve chain. This allows us to convert
        ///  from weight to fee
        /// </summary>
        [HttpGet("DestinationAssetFeePerSecond")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Storage.XcmTransactorStorage), "DestinationAssetFeePerSecondParams", typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation))]
        public IActionResult GetDestinationAssetFeePerSecond(string key)
        {
            return this.Ok(_xcmTransactorStorage.GetDestinationAssetFeePerSecond(key));
        }
    }
}
