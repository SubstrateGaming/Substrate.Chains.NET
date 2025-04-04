//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Purchased
        /// A Region of Bulk Coretime has been purchased.
        /// </summary>
        Purchased = 0,
        
        /// <summary>
        /// >> Renewable
        /// The workload of a core has become renewable.
        /// </summary>
        Renewable = 1,
        
        /// <summary>
        /// >> Renewed
        /// A workload has been renewed.
        /// </summary>
        Renewed = 2,
        
        /// <summary>
        /// >> Transferred
        /// Ownership of a Region has been transferred.
        /// </summary>
        Transferred = 3,
        
        /// <summary>
        /// >> Partitioned
        /// A Region has been split into two non-overlapping Regions.
        /// </summary>
        Partitioned = 4,
        
        /// <summary>
        /// >> Interlaced
        /// A Region has been converted into two overlapping Regions each of lesser regularity.
        /// </summary>
        Interlaced = 5,
        
        /// <summary>
        /// >> Assigned
        /// A Region has been assigned to a particular task.
        /// </summary>
        Assigned = 6,
        
        /// <summary>
        /// >> Pooled
        /// A Region has been added to the Instantaneous Coretime Pool.
        /// </summary>
        Pooled = 7,
        
        /// <summary>
        /// >> CoreCountRequested
        /// A new number of cores has been requested.
        /// </summary>
        CoreCountRequested = 8,
        
        /// <summary>
        /// >> CoreCountChanged
        /// The number of cores available for scheduling has changed.
        /// </summary>
        CoreCountChanged = 9,
        
        /// <summary>
        /// >> ReservationMade
        /// There is a new reservation for a workload.
        /// </summary>
        ReservationMade = 10,
        
        /// <summary>
        /// >> ReservationCancelled
        /// A reservation for a workload has been cancelled.
        /// </summary>
        ReservationCancelled = 11,
        
        /// <summary>
        /// >> SaleInitialized
        /// A new sale has been initialized.
        /// </summary>
        SaleInitialized = 12,
        
        /// <summary>
        /// >> Leased
        /// A new lease has been created.
        /// </summary>
        Leased = 13,
        
        /// <summary>
        /// >> LeaseEnding
        /// A lease is about to end.
        /// </summary>
        LeaseEnding = 14,
        
        /// <summary>
        /// >> SalesStarted
        /// The sale rotation has been started and a new sale is imminent.
        /// </summary>
        SalesStarted = 15,
        
        /// <summary>
        /// >> RevenueClaimBegun
        /// The act of claiming revenue has begun.
        /// </summary>
        RevenueClaimBegun = 16,
        
        /// <summary>
        /// >> RevenueClaimItem
        /// A particular timeslice has a non-zero claim.
        /// </summary>
        RevenueClaimItem = 17,
        
        /// <summary>
        /// >> RevenueClaimPaid
        /// A revenue claim has (possibly only in part) been paid.
        /// </summary>
        RevenueClaimPaid = 18,
        
        /// <summary>
        /// >> CreditPurchased
        /// Some Instantaneous Coretime Pool credit has been purchased.
        /// </summary>
        CreditPurchased = 19,
        
        /// <summary>
        /// >> RegionDropped
        /// A Region has been dropped due to being out of date.
        /// </summary>
        RegionDropped = 20,
        
        /// <summary>
        /// >> ContributionDropped
        /// Some historical Instantaneous Core Pool contribution record has been dropped.
        /// </summary>
        ContributionDropped = 21,
        
        /// <summary>
        /// >> HistoryInitialized
        /// Some historical Instantaneous Core Pool payment record has been initialized.
        /// </summary>
        HistoryInitialized = 22,
        
        /// <summary>
        /// >> HistoryDropped
        /// Some historical Instantaneous Core Pool payment record has been dropped.
        /// </summary>
        HistoryDropped = 23,
        
        /// <summary>
        /// >> HistoryIgnored
        /// Some historical Instantaneous Core Pool payment record has been ignored because the
        /// timeslice was already known. Governance may need to intervene.
        /// </summary>
        HistoryIgnored = 24,
        
        /// <summary>
        /// >> ClaimsReady
        /// Some historical Instantaneous Core Pool Revenue is ready for payout claims.
        /// </summary>
        ClaimsReady = 25,
        
        /// <summary>
        /// >> CoreAssigned
        /// A Core has been assigned to one or more tasks and/or the Pool on the Relay-chain.
        /// </summary>
        CoreAssigned = 26,
        
        /// <summary>
        /// >> PotentialRenewalDropped
        /// Some historical Instantaneous Core Pool payment record has been dropped.
        /// </summary>
        PotentialRenewalDropped = 27,
    }
    
    /// <summary>
    /// >> 128 - Variant[pallet_broker.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.Purchased);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Event.Renewable);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Event.Renewed);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Event.Transferred);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId>>>(Event.Partitioned);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId>>>(Event.Interlaced);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.Assigned);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.Pooled);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U16>(Event.CoreCountRequested);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U16>(Event.CoreCountChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Event.ReservationMade);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Event.ReservationCancelled);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U16>>(Event.SaleInitialized);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.Leased);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.LeaseEnding);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U16>>(Event.SalesStarted);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.RevenueClaimBegun);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.RevenueClaimItem);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId>>>(Event.RevenueClaimPaid);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.CreditPurchased);
				AddTypeDecoder<BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.RegionDropped);
				AddTypeDecoder<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types.RegionId>(Event.ContributionDropped);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.HistoryInitialized);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.HistoryDropped);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.HistoryIgnored);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.ClaimsReady);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.coretime_interface.EnumCoreAssignment, Substrate.NetApi.Model.Types.Primitive.U16>>>>(Event.CoreAssigned);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>>(Event.PotentialRenewalDropped);
        }
    }
}
