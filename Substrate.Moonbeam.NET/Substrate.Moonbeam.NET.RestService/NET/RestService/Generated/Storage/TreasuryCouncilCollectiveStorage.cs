//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Moonbeam.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITreasuryCouncilCollectiveStorage interface definition.
    /// </summary>
    public interface ITreasuryCouncilCollectiveStorage : IStorage
    {
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT14 GetProposals();
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall GetProposalOf(string key);
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes GetVoting(string key);
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount();
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20> GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 GetPrime();
    }
    
    /// <summary>
    /// TreasuryCouncilCollectiveStorage class definition.
    /// </summary>
    public sealed class TreasuryCouncilCollectiveStorage : ITreasuryCouncilCollectiveStorage
    {
        
        /// <summary>
        /// _proposalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT14> _proposalsTypedStorage;
        
        /// <summary>
        /// _proposalOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall> _proposalOfTypedStorage;
        
        /// <summary>
        /// _votingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes> _votingTypedStorage;
        
        /// <summary>
        /// _proposalCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _proposalCountTypedStorage;
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20> _primeTypedStorage;
        
        /// <summary>
        /// TreasuryCouncilCollectiveStorage constructor.
        /// </summary>
        public TreasuryCouncilCollectiveStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ProposalsTypedStorage = new TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT14>("TreasuryCouncilCollective.Proposals", storageDataProvider, storageChangeDelegates);
            this.ProposalOfTypedStorage = new TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall>("TreasuryCouncilCollective.ProposalOf", storageDataProvider, storageChangeDelegates);
            this.VotingTypedStorage = new TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes>("TreasuryCouncilCollective.Voting", storageDataProvider, storageChangeDelegates);
            this.ProposalCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("TreasuryCouncilCollective.ProposalCount", storageDataProvider, storageChangeDelegates);
            this.MembersTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>>("TreasuryCouncilCollective.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>("TreasuryCouncilCollective.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _proposalsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT14> ProposalsTypedStorage
        {
            get
            {
                return _proposalsTypedStorage;
            }
            set
            {
                _proposalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall> ProposalOfTypedStorage
        {
            get
            {
                return _proposalOfTypedStorage;
            }
            set
            {
                _proposalOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes> VotingTypedStorage
        {
            get
            {
                return _votingTypedStorage;
            }
            set
            {
                _votingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ProposalCountTypedStorage
        {
            get
            {
                return _proposalCountTypedStorage;
            }
            set
            {
                _proposalCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>> MembersTypedStorage
        {
            get
            {
                return _membersTypedStorage;
            }
            set
            {
                _membersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _primeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20> PrimeTypedStorage
        {
            get
            {
                return _primeTypedStorage;
            }
            set
            {
                _primeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ProposalsTypedStorage.InitializeAsync("TreasuryCouncilCollective", "Proposals");
            await ProposalOfTypedStorage.InitializeAsync("TreasuryCouncilCollective", "ProposalOf");
            await VotingTypedStorage.InitializeAsync("TreasuryCouncilCollective", "Voting");
            await ProposalCountTypedStorage.InitializeAsync("TreasuryCouncilCollective", "ProposalCount");
            await MembersTypedStorage.InitializeAsync("TreasuryCouncilCollective", "Members");
            await PrimeTypedStorage.InitializeAsync("TreasuryCouncilCollective", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.Proposals
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "Proposals")]
        public void OnUpdateProposals(string data)
        {
            ProposalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        public Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT14 GetProposals()
        {
            return ProposalsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.ProposalOf
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "ProposalOf")]
        public void OnUpdateProposalOf(string key, string data)
        {
            ProposalOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        public Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall GetProposalOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProposalOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.EnumRuntimeCall result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.Voting
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "Voting")]
        public void OnUpdateVoting(string key, string data)
        {
            VotingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes GetVoting(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingTypedStorage.Dictionary.TryGetValue(key, out Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_collective.Votes result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.ProposalCount
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "ProposalCount")]
        public void OnUpdateProposalCount(string data)
        {
            ProposalCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount()
        {
            return ProposalCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.Members
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20> GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TreasuryCouncilCollective.Prime
        /// </summary>
        [StorageChange("TreasuryCouncilCollective", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        public Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}