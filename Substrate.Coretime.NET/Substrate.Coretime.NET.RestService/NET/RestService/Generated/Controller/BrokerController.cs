//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Coretime.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Coretime.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BrokerController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BrokerController : ControllerBase
    {
        
        private IBrokerStorage _brokerStorage;
        
        /// <summary>
        /// BrokerController constructor.
        /// </summary>
        public BrokerController(IBrokerStorage brokerStorage)
        {
            _brokerStorage = brokerStorage;
        }
        
        /// <summary>
        /// >> Configuration
        ///  The current configuration of this pallet.
        /// </summary>
        [HttpGet("Configuration")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.ConfigRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "ConfigurationParams")]
        public IActionResult GetConfiguration()
        {
            return this.Ok(_brokerStorage.GetConfiguration());
        }
        
        /// <summary>
        /// >> Reservations
        ///  The Polkadot Core reservations (generally tasked with the maintenance of System Chains).
        /// </summary>
        [HttpGet("Reservations")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "ReservationsParams")]
        public IActionResult GetReservations()
        {
            return this.Ok(_brokerStorage.GetReservations());
        }
        
        /// <summary>
        /// >> Leases
        ///  The Polkadot Core legacy leases.
        /// </summary>
        [HttpGet("Leases")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "LeasesParams")]
        public IActionResult GetLeases()
        {
            return this.Ok(_brokerStorage.GetLeases());
        }
        
        /// <summary>
        /// >> Status
        ///  The current status of miscellaneous subsystems of this pallet.
        /// </summary>
        [HttpGet("Status")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.StatusRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "StatusParams")]
        public IActionResult GetStatus()
        {
            return this.Ok(_brokerStorage.GetStatus());
        }
        
        /// <summary>
        /// >> SaleInfo
        ///  The details of the current sale, including its properties and status.
        /// </summary>
        [HttpGet("SaleInfo")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.SaleInfoRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "SaleInfoParams")]
        public IActionResult GetSaleInfo()
        {
            return this.Ok(_brokerStorage.GetSaleInfo());
        }
        
        /// <summary>
        /// >> PotentialRenewals
        ///  Records of potential renewals.
        /// 
        ///  Renewals will only actually be allowed if `CompletionStatus` is actually `Complete`.
        /// </summary>
        [HttpGet("PotentialRenewals")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.PotentialRenewalRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "PotentialRenewalsParams", typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.PotentialRenewalId))]
        public IActionResult GetPotentialRenewals(string key)
        {
            return this.Ok(_brokerStorage.GetPotentialRenewals(key));
        }
        
        /// <summary>
        /// >> Regions
        ///  The current (unassigned or provisionally assigend) Regions.
        /// </summary>
        [HttpGet("Regions")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "RegionsParams", typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId))]
        public IActionResult GetRegions(string key)
        {
            return this.Ok(_brokerStorage.GetRegions(key));
        }
        
        /// <summary>
        /// >> Workplan
        ///  The work we plan on having each core do at a particular time in the future.
        /// </summary>
        [HttpGet("Workplan")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "WorkplanParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>))]
        public IActionResult GetWorkplan(string key)
        {
            return this.Ok(_brokerStorage.GetWorkplan(key));
        }
        
        /// <summary>
        /// >> Workload
        ///  The current workload of each core. This gets updated with workplan as timeslices pass.
        /// </summary>
        [HttpGet("Workload")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "WorkloadParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetWorkload(string key)
        {
            return this.Ok(_brokerStorage.GetWorkload(key));
        }
        
        /// <summary>
        /// >> InstaPoolContribution
        ///  Record of a single contribution to the Instantaneous Coretime Pool.
        /// </summary>
        [HttpGet("InstaPoolContribution")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.ContributionRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "InstaPoolContributionParams", typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId))]
        public IActionResult GetInstaPoolContribution(string key)
        {
            return this.Ok(_brokerStorage.GetInstaPoolContribution(key));
        }
        
        /// <summary>
        /// >> InstaPoolIo
        ///  Record of Coretime entering or leaving the Instantaneous Coretime Pool.
        /// </summary>
        [HttpGet("InstaPoolIo")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.PoolIoRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "InstaPoolIoParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetInstaPoolIo(string key)
        {
            return this.Ok(_brokerStorage.GetInstaPoolIo(key));
        }
        
        /// <summary>
        /// >> InstaPoolHistory
        ///  Total InstaPool rewards for each Timeslice and the number of core parts which contributed.
        /// </summary>
        [HttpGet("InstaPoolHistory")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.InstaPoolHistoryRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "InstaPoolHistoryParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetInstaPoolHistory(string key)
        {
            return this.Ok(_brokerStorage.GetInstaPoolHistory(key));
        }
        
        /// <summary>
        /// >> CoreCountInbox
        ///  Received core count change from the relay chain.
        /// </summary>
        [HttpGet("CoreCountInbox")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U16), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "CoreCountInboxParams")]
        public IActionResult GetCoreCountInbox()
        {
            return this.Ok(_brokerStorage.GetCoreCountInbox());
        }
        
        /// <summary>
        /// >> RevenueInbox
        ///  Received revenue info from the relay chain.
        /// </summary>
        [HttpGet("RevenueInbox")]
        [ProducesResponseType(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.OnDemandRevenueRecord), 200)]
        [StorageKeyBuilder(typeof(Substrate.Coretime.NET.NetApiExt.Generated.Storage.BrokerStorage), "RevenueInboxParams")]
        public IActionResult GetRevenueInbox()
        {
            return this.Ok(_brokerStorage.GetRevenueInbox());
        }
    }
}