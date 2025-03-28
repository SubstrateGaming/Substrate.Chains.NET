//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> TournamentAAAStorage
    /// </summary>
    public sealed class TournamentAAAStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> TournamentAAAStorage Constructor
        /// </summary>
        public TournamentAAAStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "TournamentSchedules"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentScheduledAction)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "TreasuryAccountsCache"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "NextTournamentIds"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "Tournaments"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.TournamentConfig)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "ActiveTournaments"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "TournamentRankings"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT52)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "TournamentRewardClaims"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "GoldenDucks"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumGoldenDuckState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TournamentAAA", "GoldenDuckRewardClaims"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState)));
        }
        
        /// <summary>
        /// >> TournamentSchedulesParams
        /// </summary>
        public static string TournamentSchedulesParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "TournamentSchedules", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TournamentSchedulesDefault
        /// Default value as hex string
        /// </summary>
        public static string TournamentSchedulesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TournamentSchedules
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentScheduledAction> TournamentSchedules(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.TournamentSchedulesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentScheduledAction>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TreasuryAccountsCacheParams
        /// </summary>
        public static string TreasuryAccountsCacheParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "TreasuryAccountsCache", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TreasuryAccountsCacheDefault
        /// Default value as hex string
        /// </summary>
        public static string TreasuryAccountsCacheDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TreasuryAccountsCache
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> TreasuryAccountsCache(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.TreasuryAccountsCacheParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NextTournamentIdsParams
        /// </summary>
        public static string NextTournamentIdsParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "NextTournamentIds", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NextTournamentIdsDefault
        /// Default value as hex string
        /// </summary>
        public static string NextTournamentIdsDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> NextTournamentIds
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> NextTournamentIds(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.NextTournamentIdsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TournamentsParams
        /// </summary>
        public static string TournamentsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "Tournaments", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> TournamentsDefault
        /// Default value as hex string
        /// </summary>
        public static string TournamentsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Tournaments
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.TournamentConfig> Tournaments(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.TournamentsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.TournamentConfig>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ActiveTournamentsParams
        /// </summary>
        public static string ActiveTournamentsParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "ActiveTournaments", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ActiveTournamentsDefault
        /// Default value as hex string
        /// </summary>
        public static string ActiveTournamentsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ActiveTournaments
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentState> ActiveTournaments(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.ActiveTournamentsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumTournamentState>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TournamentRankingsParams
        /// </summary>
        public static string TournamentRankingsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "TournamentRankings", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> TournamentRankingsDefault
        /// Default value as hex string
        /// </summary>
        public static string TournamentRankingsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TournamentRankings
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT52> TournamentRankings(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.TournamentRankingsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT52>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TournamentRewardClaimsParams
        /// </summary>
        public static string TournamentRewardClaimsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "TournamentRewardClaims", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> TournamentRewardClaimsDefault
        /// Default value as hex string
        /// </summary>
        public static string TournamentRewardClaimsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TournamentRewardClaims
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState> TournamentRewardClaims(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.TournamentRewardClaimsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> GoldenDucksParams
        /// </summary>
        public static string GoldenDucksParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "GoldenDucks", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> GoldenDucksDefault
        /// Default value as hex string
        /// </summary>
        public static string GoldenDucksDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> GoldenDucks
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumGoldenDuckState> GoldenDucks(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.GoldenDucksParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumGoldenDuckState>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> GoldenDuckRewardClaimsParams
        /// </summary>
        public static string GoldenDuckRewardClaimsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("TournamentAAA", "GoldenDuckRewardClaims", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> GoldenDuckRewardClaimsDefault
        /// Default value as hex string
        /// </summary>
        public static string GoldenDuckRewardClaimsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> GoldenDuckRewardClaims
        /// </summary>
        public async Task<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState> GoldenDuckRewardClaims(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = TournamentAAAStorage.GoldenDuckRewardClaimsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_tournament.config.EnumRewardClaimState>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> TournamentAAACalls
    /// </summary>
    public sealed class TournamentAAACalls
    {
    }
    
    /// <summary>
    /// >> TournamentAAAConstants
    /// </summary>
    public sealed class TournamentAAAConstants
    {
        
        /// <summary>
        /// >> PalletId
        /// </summary>
        public Substrate.Ajuna.NET.NetApiExt.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Substrate.Ajuna.NET.NetApiExt.Generated.Model.frame_support.PalletId();
            result.Create("0x616A2F74726D7431");
            return result;
        }
        
        /// <summary>
        /// >> MinimumTournamentPhaseDuration
        ///  Minimum duration of the tournament active and claim periods in blocks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MinimumTournamentPhaseDuration()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> TournamentAAAErrors
    /// </summary>
    public enum TournamentAAAErrors
    {
        
        /// <summary>
        /// >> NoActiveTournamentForSeason
        /// There's no active tournament for the selected season.
        /// </summary>
        NoActiveTournamentForSeason,
        
        /// <summary>
        /// >> TournamentNotInClaimPeriod
        /// The current tournament is not in its reward claim period.
        /// </summary>
        TournamentNotInClaimPeriod,
        
        /// <summary>
        /// >> LatestTournamentAlreadyStarted
        /// The latest tournament for the selected season identifier already started,
        /// so it cannot be removed anymore.
        /// </summary>
        LatestTournamentAlreadyStarted,
        
        /// <summary>
        /// >> AnotherTournamentAlreadyActiveForSeason
        /// There's already an active tournament for the selected season.
        /// </summary>
        AnotherTournamentAlreadyActiveForSeason,
        
        /// <summary>
        /// >> TournamentNotFound
        /// Cannot find tournament data for the selected season id and tournament id combination.
        /// </summary>
        TournamentNotFound,
        
        /// <summary>
        /// >> TournamentActivationTooEarly
        /// Cannot activate a tournament before its configured block start,
        /// </summary>
        TournamentActivationTooEarly,
        
        /// <summary>
        /// >> TournamentEndingTooEarly
        /// Cannot deactivate a tournament before its configured block end,
        /// </summary>
        TournamentEndingTooEarly,
        
        /// <summary>
        /// >> FailedToRankEntity
        /// An error occurred trying to rank an entity,
        /// </summary>
        FailedToRankEntity,
        
        /// <summary>
        /// >> InvalidTournamentConfig
        /// Tournament configuration is invalid.
        /// </summary>
        InvalidTournamentConfig,
        
        /// <summary>
        /// >> CannotScheduleTournament
        /// Tournament schedule already in use by another tournament.
        /// </summary>
        CannotScheduleTournament,
        
        /// <summary>
        /// >> RankingCandidateNotInWinnerTable
        /// A ranking duck candidate proposed by an account is not in the winner's table.
        /// </summary>
        RankingCandidateNotInWinnerTable,
        
        /// <summary>
        /// >> GoldenDuckCandidateNotWinner
        /// A golden duck candidate proposed by an account is not the actual golden duck winner.
        /// </summary>
        GoldenDuckCandidateNotWinner,
        
        /// <summary>
        /// >> TournamentRewardAlreadyClaimed
        /// The reward for this tournament has already been claimed
        /// </summary>
        TournamentRewardAlreadyClaimed,
    }
}
