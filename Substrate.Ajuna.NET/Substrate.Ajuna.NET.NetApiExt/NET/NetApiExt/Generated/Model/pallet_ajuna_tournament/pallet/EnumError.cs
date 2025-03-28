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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NoActiveTournamentForSeason
        /// There's no active tournament for the selected season.
        /// </summary>
        NoActiveTournamentForSeason = 0,
        
        /// <summary>
        /// >> TournamentNotInClaimPeriod
        /// The current tournament is not in its reward claim period.
        /// </summary>
        TournamentNotInClaimPeriod = 1,
        
        /// <summary>
        /// >> LatestTournamentAlreadyStarted
        /// The latest tournament for the selected season identifier already started,
        /// so it cannot be removed anymore.
        /// </summary>
        LatestTournamentAlreadyStarted = 2,
        
        /// <summary>
        /// >> AnotherTournamentAlreadyActiveForSeason
        /// There's already an active tournament for the selected season.
        /// </summary>
        AnotherTournamentAlreadyActiveForSeason = 3,
        
        /// <summary>
        /// >> TournamentNotFound
        /// Cannot find tournament data for the selected season id and tournament id combination.
        /// </summary>
        TournamentNotFound = 4,
        
        /// <summary>
        /// >> TournamentActivationTooEarly
        /// Cannot activate a tournament before its configured block start,
        /// </summary>
        TournamentActivationTooEarly = 5,
        
        /// <summary>
        /// >> TournamentEndingTooEarly
        /// Cannot deactivate a tournament before its configured block end,
        /// </summary>
        TournamentEndingTooEarly = 6,
        
        /// <summary>
        /// >> FailedToRankEntity
        /// An error occurred trying to rank an entity,
        /// </summary>
        FailedToRankEntity = 7,
        
        /// <summary>
        /// >> InvalidTournamentConfig
        /// Tournament configuration is invalid.
        /// </summary>
        InvalidTournamentConfig = 8,
        
        /// <summary>
        /// >> CannotScheduleTournament
        /// Tournament schedule already in use by another tournament.
        /// </summary>
        CannotScheduleTournament = 9,
        
        /// <summary>
        /// >> RankingCandidateNotInWinnerTable
        /// A ranking duck candidate proposed by an account is not in the winner's table.
        /// </summary>
        RankingCandidateNotInWinnerTable = 10,
        
        /// <summary>
        /// >> GoldenDuckCandidateNotWinner
        /// A golden duck candidate proposed by an account is not the actual golden duck winner.
        /// </summary>
        GoldenDuckCandidateNotWinner = 11,
        
        /// <summary>
        /// >> TournamentRewardAlreadyClaimed
        /// The reward for this tournament has already been claimed
        /// </summary>
        TournamentRewardAlreadyClaimed = 12,
    }
    
    /// <summary>
    /// >> 650 - Variant[pallet_ajuna_tournament.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
