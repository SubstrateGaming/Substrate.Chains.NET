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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> AmbassadorCoreStorage
    /// </summary>
    public sealed class AmbassadorCoreStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AmbassadorCoreStorage Constructor
        /// </summary>
        public AmbassadorCoreStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCore", "Params"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.ParamsType)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCore", "Member"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.MemberStatus)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCore", "MemberEvidence"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.EnumWish, Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8>)));
        }
        
        /// <summary>
        /// >> ParamsParams
        ///  The overall status of the system.
        /// </summary>
        public static string ParamsParams()
        {
            return RequestGenerator.GetStorage("AmbassadorCore", "Params", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ParamsDefault
        /// Default value as hex string
        /// </summary>
        public static string ParamsDefault()
        {
            return @"0x00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Params
        ///  The overall status of the system.
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.ParamsType> Params(string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCoreStorage.ParamsParams();
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.ParamsType>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MemberParams
        ///  The status of a claimant.
        /// </summary>
        public static string MemberParams(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("AmbassadorCore", "Member", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MemberDefault
        /// Default value as hex string
        /// </summary>
        public static string MemberDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Member
        ///  The status of a claimant.
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.MemberStatus> Member(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCoreStorage.MemberParams(key);
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.MemberStatus>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MemberEvidenceParams
        ///  Some evidence together with the desired outcome for which it was presented.
        /// </summary>
        public static string MemberEvidenceParams(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("AmbassadorCore", "MemberEvidence", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MemberEvidenceDefault
        /// Default value as hex string
        /// </summary>
        public static string MemberEvidenceDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MemberEvidence
        ///  Some evidence together with the desired outcome for which it was presented.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.EnumWish, Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8>> MemberEvidence(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCoreStorage.MemberEvidenceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.EnumWish, Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8>>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AmbassadorCoreCalls
    /// </summary>
    public sealed class AmbassadorCoreCalls
    {
        
        /// <summary>
        /// >> bump
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Bump(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(73, "AmbassadorCore", 0, "bump", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_params
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetParams(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.ParamsType @params)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@params.Encode());
            return new Method(73, "AmbassadorCore", 1, "set_params", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_active
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetActive(Substrate.NetApi.Model.Types.Primitive.Bool is_active)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(is_active.Encode());
            return new Method(73, "AmbassadorCore", 2, "set_active", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Approve(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who, Substrate.NetApi.Model.Types.Primitive.U16 at_rank)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(at_rank.Encode());
            return new Method(73, "AmbassadorCore", 3, "approve", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> induct
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Induct(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(73, "AmbassadorCore", 4, "induct", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> promote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Promote(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who, Substrate.NetApi.Model.Types.Primitive.U16 to_rank)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(to_rank.Encode());
            return new Method(73, "AmbassadorCore", 5, "promote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> offboard
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Offboard(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(73, "AmbassadorCore", 6, "offboard", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> submit_evidence
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SubmitEvidence(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship.EnumWish wish, Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 evidence)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(wish.Encode());
            byteArray.AddRange(evidence.Encode());
            return new Method(73, "AmbassadorCore", 7, "submit_evidence", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> import
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Import()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(73, "AmbassadorCore", 8, "import", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AmbassadorCoreConstants
    /// </summary>
    public sealed class AmbassadorCoreConstants
    {
        
        /// <summary>
        /// >> EvidenceSize
        ///  The maximum size in bytes submitted evidence is allowed to be.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 EvidenceSize()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000100");
            return result;
        }
    }
    
    /// <summary>
    /// >> AmbassadorCoreErrors
    /// </summary>
    public enum AmbassadorCoreErrors
    {
        
        /// <summary>
        /// >> Unranked
        /// Member's rank is too low.
        /// </summary>
        Unranked,
        
        /// <summary>
        /// >> Ranked
        /// Member's rank is not zero.
        /// </summary>
        Ranked,
        
        /// <summary>
        /// >> UnexpectedRank
        /// Member's rank is not as expected - generally means that the rank provided to the call
        /// does not agree with the state of the system.
        /// </summary>
        UnexpectedRank,
        
        /// <summary>
        /// >> InvalidRank
        /// The given rank is invalid - this generally means it's not between 1 and `RANK_COUNT`.
        /// </summary>
        InvalidRank,
        
        /// <summary>
        /// >> NoPermission
        /// The origin does not have enough permission to do this operation.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NothingDoing
        /// No work needs to be done at present for this member.
        /// </summary>
        NothingDoing,
        
        /// <summary>
        /// >> AlreadyInducted
        /// The candidate has already been inducted. This should never happen since it would
        /// require a candidate (rank 0) to already be tracked in the pallet.
        /// </summary>
        AlreadyInducted,
        
        /// <summary>
        /// >> NotTracked
        /// The candidate has not been inducted, so cannot be offboarded from this pallet.
        /// </summary>
        NotTracked,
        
        /// <summary>
        /// >> TooSoon
        /// Operation cannot be done yet since not enough time has passed.
        /// </summary>
        TooSoon,
    }
}