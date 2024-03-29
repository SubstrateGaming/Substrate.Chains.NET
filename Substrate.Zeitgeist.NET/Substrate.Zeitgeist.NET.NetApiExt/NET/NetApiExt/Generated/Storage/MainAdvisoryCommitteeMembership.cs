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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> AdvisoryCommitteeMembershipStorage
    /// </summary>
    public sealed class AdvisoryCommitteeMembershipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AdvisoryCommitteeMembershipStorage Constructor
        /// </summary>
        public AdvisoryCommitteeMembershipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AdvisoryCommitteeMembership", "Members"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT18)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AdvisoryCommitteeMembership", "Prime"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("AdvisoryCommitteeMembership", "Members", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MembersDefault
        /// Default value as hex string
        /// </summary>
        public static string MembersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT18> Members(string blockhash, CancellationToken token)
        {
            string parameters = AdvisoryCommitteeMembershipStorage.MembersParams();
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT18>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PrimeParams
        ///  The current prime member, if one exists.
        /// </summary>
        public static string PrimeParams()
        {
            return RequestGenerator.GetStorage("AdvisoryCommitteeMembership", "Prime", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PrimeDefault
        /// Default value as hex string
        /// </summary>
        public static string PrimeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Prime(string blockhash, CancellationToken token)
        {
            string parameters = AdvisoryCommitteeMembershipStorage.PrimeParams();
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AdvisoryCommitteeMembershipCalls
    /// </summary>
    public sealed class AdvisoryCommitteeMembershipCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddMember(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveMember(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 1, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> swap_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SwapMember(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress remove, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress add)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remove.Encode());
            byteArray.AddRange(add.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 2, "swap_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reset_members
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ResetMembers(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> members)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(members.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 3, "reset_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ChangeKey(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 4, "change_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetPrime(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "AdvisoryCommitteeMembership", 5, "set_prime", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearPrime()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(22, "AdvisoryCommitteeMembership", 6, "clear_prime", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AdvisoryCommitteeMembershipConstants
    /// </summary>
    public sealed class AdvisoryCommitteeMembershipConstants
    {
    }
    
    /// <summary>
    /// >> AdvisoryCommitteeMembershipErrors
    /// </summary>
    public enum AdvisoryCommitteeMembershipErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> TooManyMembers
        /// Too many members.
        /// </summary>
        TooManyMembers,
    }
}
