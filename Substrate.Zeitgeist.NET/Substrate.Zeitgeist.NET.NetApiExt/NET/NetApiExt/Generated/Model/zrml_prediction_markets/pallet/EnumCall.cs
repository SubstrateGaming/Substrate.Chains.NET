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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_prediction_markets.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> admin_move_market_to_closed
        /// Allows the `CloseOrigin` to immediately move an open market to closed.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n + m)`, where `n` is the number of market ids,
        /// which open at the same time as the specified market,
        /// and `m` is the number of market ids,
        /// which close at the same time as the specified market.
        /// </summary>
        admin_move_market_to_closed = 1,
        
        /// <summary>
        /// >> admin_move_market_to_resolved
        /// Allows the `ResolveOrigin` to immediately move a reported or disputed
        /// market to resolved.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n + m)`, where `n` is the number of market ids
        /// per dispute / report block, m is the number of disputes.
        /// </summary>
        admin_move_market_to_resolved = 2,
        
        /// <summary>
        /// >> approve_market
        /// Approves a market that is waiting for approval from the
        /// advisory committee.
        /// 
        /// NOTE: Returns the proposer's bond since the market has been
        /// deemed valid by an advisory committee.
        /// 
        /// NOTE: Can only be called by the `ApproveOrigin`.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(1)`
        /// </summary>
        approve_market = 3,
        
        /// <summary>
        /// >> request_edit
        /// Request an edit to a proposed market.
        /// 
        /// Can only be called by the `RequestEditOrigin`.
        /// 
        /// # Arguments
        /// 
        /// * `market_id`: The id of the market to edit.
        /// * `edit_reason`: An short record of what needs to be changed.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(edit_reason.len())`
        /// </summary>
        request_edit = 4,
        
        /// <summary>
        /// >> buy_complete_set
        /// Buy a complete set of outcome shares of a market.
        /// 
        /// The cost of a full set is exactly one unit of the market's base asset. For example,
        /// when calling `buy_complete_set(origin, 1, 2)` on a categorical market with five
        /// different outcomes, the caller pays `2` of the base asset and receives `2` of each of
        /// the five outcome tokens.
        /// 
        /// NOTE: This is the only way to create new shares of outcome tokens.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of outcome assets in the market.
        /// </summary>
        buy_complete_set = 5,
        
        /// <summary>
        /// >> dispute
        /// Dispute on a market that has been reported or already disputed.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of outstanding disputes.
        /// </summary>
        dispute = 6,
        
        /// <summary>
        /// >> create_market
        /// Creates a market.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of market ids,
        /// which close at the same time as the specified market.
        /// </summary>
        create_market = 8,
        
        /// <summary>
        /// >> edit_market
        /// Edit a proposed market for which request is made.
        /// 
        /// Edit can only be made by the creator of the market.
        /// 
        /// # Arguments
        /// 
        /// * `market_id`: The id of the market to edit.
        /// * `oracle`: Oracle to edit market.
        /// * `period`: MarketPeriod to edit market.
        /// * `deadlines`: Deadlines to edit market.
        /// * `metadata`: MultiHash metadata to edit market.
        /// * `market_type`: MarketType to edit market.
        /// * `dispute_mechanism`: MarketDisputeMechanism to edit market.
        /// * `scoring_rule`: ScoringRule to edit market.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of markets
        /// which end at the same time as the market before the edit.
        /// </summary>
        edit_market = 9,
        
        /// <summary>
        /// >> redeem_shares
        /// Redeems the winning shares of a prediction market.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(1)`
        /// </summary>
        redeem_shares = 12,
        
        /// <summary>
        /// >> reject_market
        /// Rejects a market that is waiting for approval from the advisory committee.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n + m)`,
        /// where `n` is the number of market ids,
        /// which open at the same time as the specified market,
        /// and `m` is the number of market ids,
        /// which close at the same time as the specified market.
        /// </summary>
        reject_market = 13,
        
        /// <summary>
        /// >> report
        /// Reports the outcome of a market.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of market ids,
        /// which reported at the same time as the specified market.
        /// </summary>
        report = 14,
        
        /// <summary>
        /// >> sell_complete_set
        /// Sells a complete set of outcomes shares for a market.
        /// 
        /// Each complete set is sold for one unit of the market's base asset.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the number of assets for a categorical market.
        /// </summary>
        sell_complete_set = 15,
        
        /// <summary>
        /// >> start_global_dispute
        /// Start a global dispute, if the market dispute mechanism fails.
        /// 
        /// # Arguments
        /// 
        /// * `market_id`: The identifier of the market.
        /// 
        /// NOTE:
        /// The returned outcomes of the market dispute mechanism and the report outcome
        /// are added to the global dispute voting outcomes.
        /// The bond of each dispute is the initial vote amount.
        /// </summary>
        start_global_dispute = 16,
        
        /// <summary>
        /// >> create_market_and_deploy_pool
        /// Create a market, deploy a LMSR pool, and buy outcome tokens and provide liquidity to the
        /// market.
        /// 
        /// # Weight
        /// 
        /// `O(n)` where `n` is the number of markets which close on the same block, plus the
        /// resources consumed by `DeployPool::create_pool`. In the standard implementation using
        /// neo-swaps, this is `O(m)` where `m` is the number of assets in the market.
        /// </summary>
        create_market_and_deploy_pool = 17,
        
        /// <summary>
        /// >> schedule_early_close
        /// Allows the `CloseMarketsEarlyOrigin` or the market creator to schedule an early close.
        /// 
        /// The market creator schedules it `now + EarlyClose...Period` in the future.
        /// This is to allow enough time for a potential dispute.
        /// The market creator reserves a `CloseEarlyDisputeBond`, which is returned,
        /// if the `CloseMarketsEarlyOrigin` decides to accept the early close request
        /// or if it is not disputed.
        /// It is slashed, if the early close request is disputed
        /// and the `CloseMarketsEarlyOrigin` decides to reject the early close.
        /// The `CloseMarketsEarlyOrigin` (or root) can schedule it `now + CloseProtection...Period`
        /// in the future. This is to prevent fat finger mistakes.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the maximum number of market ids
        /// in `MarketIdsPerClose...` either at the old period end or new period end.
        /// </summary>
        schedule_early_close = 18,
        
        /// <summary>
        /// >> dispute_early_close
        /// Allows anyone to dispute a scheduled early close.
        /// 
        /// The market period is reset to the original (old) period.
        /// A `CloseEarlyDisputeBond` is reserved, which is returned,
        /// if the `CloseMarketsEarlyOrigin` decides to reject
        /// the early close request of the market creator or
        /// if the `CloseMarketsEarlyOrigin` is inactive.
        /// It is slashed, if the `CloseMarketsEarlyOrigin` decides to schedule the early close.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the maximum number of market ids
        /// in `MarketIdsPerClose...` either at the old period end or new period end.
        /// </summary>
        dispute_early_close = 19,
        
        /// <summary>
        /// >> reject_early_close
        /// Allows the `CloseMarketsEarlyOrigin` to reject a scheduled early close.
        /// 
        /// The market period is reset to the original (old) period
        /// in case it was scheduled before (fat-finger protection).
        /// 
        /// The disputant gets back the `CloseEarlyDisputeBond`
        /// and receives the market creators `CloseEarlyRequestBond`.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`, where `n` is the maximum number of market ids
        /// in `MarketIdsPerClose...` either at the old period end or new period end.
        /// </summary>
        reject_early_close = 20,
        
        /// <summary>
        /// >> close_trusted_market
        /// Allows the market creator of a trusted market
        /// to immediately move an open market to closed.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n + m)`, where `n` is the number of market ids,
        /// which open at the same time as the specified market,
        /// and `m` is the number of market ids,
        /// which close at the same time as the specified market.
        /// </summary>
        close_trusted_market = 21,
        
        /// <summary>
        /// >> manually_close_market
        /// Allows the manual closing for "broken" markets.
        /// A market is "broken", if an unexpected chain stall happened
        /// and the auto close was scheduled during this time.
        /// 
        /// # Weight
        /// 
        /// Complexity: `O(n)`,
        /// and `n` is the number of market ids,
        /// which close at the same time as the specified market.
        /// </summary>
        manually_close_market = 22,
    }
    
    /// <summary>
    /// >> 320 - Variant[zrml_prediction_markets.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.Deadlines, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.types.EnumMultiHash, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketCreation, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketType, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketDisputeMechanism>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumScoringRule>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.Deadlines, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.types.EnumMultiHash, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketType, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketDisputeMechanism>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumScoringRule>, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.Deadlines, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.types.EnumMultiHash, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketType, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketDisputeMechanism>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}