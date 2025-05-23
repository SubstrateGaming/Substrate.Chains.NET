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


namespace Substrate.Collectives.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IFellowshipTreasuryStorage interface definition.
    /// </summary>
    public interface IFellowshipTreasuryStorage : IStorage
    {
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount();
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal GetProposals(string key);
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetDeactivated();
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 GetApprovals();
        
        /// <summary>
        /// >> SpendCount
        ///  The count of spends that have been made.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetSpendCount();
        
        /// <summary>
        /// >> Spends
        ///  Spends that have been approved and being processed.
        /// </summary>
        Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus GetSpends(string key);
    }
    
    /// <summary>
    /// FellowshipTreasuryStorage class definition.
    /// </summary>
    public sealed class FellowshipTreasuryStorage : IFellowshipTreasuryStorage
    {
        
        /// <summary>
        /// _proposalCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _proposalCountTypedStorage;
        
        /// <summary>
        /// _proposalsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal> _proposalsTypedStorage;
        
        /// <summary>
        /// _deactivatedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _deactivatedTypedStorage;
        
        /// <summary>
        /// _approvalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> _approvalsTypedStorage;
        
        /// <summary>
        /// _spendCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _spendCountTypedStorage;
        
        /// <summary>
        /// _spendsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus> _spendsTypedStorage;
        
        /// <summary>
        /// FellowshipTreasuryStorage constructor.
        /// </summary>
        public FellowshipTreasuryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ProposalCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FellowshipTreasury.ProposalCount", storageDataProvider, storageChangeDelegates);
            this.ProposalsTypedStorage = new TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal>("FellowshipTreasury.Proposals", storageDataProvider, storageChangeDelegates);
            this.DeactivatedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("FellowshipTreasury.Deactivated", storageDataProvider, storageChangeDelegates);
            this.ApprovalsTypedStorage = new TypedStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35>("FellowshipTreasury.Approvals", storageDataProvider, storageChangeDelegates);
            this.SpendCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FellowshipTreasury.SpendCount", storageDataProvider, storageChangeDelegates);
            this.SpendsTypedStorage = new TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus>("FellowshipTreasury.Spends", storageDataProvider, storageChangeDelegates);
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
        /// _proposalsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal> ProposalsTypedStorage
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
        /// _deactivatedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> DeactivatedTypedStorage
        {
            get
            {
                return _deactivatedTypedStorage;
            }
            set
            {
                _deactivatedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _approvalsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> ApprovalsTypedStorage
        {
            get
            {
                return _approvalsTypedStorage;
            }
            set
            {
                _approvalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _spendCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> SpendCountTypedStorage
        {
            get
            {
                return _spendCountTypedStorage;
            }
            set
            {
                _spendCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _spendsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus> SpendsTypedStorage
        {
            get
            {
                return _spendsTypedStorage;
            }
            set
            {
                _spendsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ProposalCountTypedStorage.InitializeAsync("FellowshipTreasury", "ProposalCount");
            await ProposalsTypedStorage.InitializeAsync("FellowshipTreasury", "Proposals");
            await DeactivatedTypedStorage.InitializeAsync("FellowshipTreasury", "Deactivated");
            await ApprovalsTypedStorage.InitializeAsync("FellowshipTreasury", "Approvals");
            await SpendCountTypedStorage.InitializeAsync("FellowshipTreasury", "SpendCount");
            await SpendsTypedStorage.InitializeAsync("FellowshipTreasury", "Spends");
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.ProposalCount
        /// </summary>
        [StorageChange("FellowshipTreasury", "ProposalCount")]
        public void OnUpdateProposalCount(string data)
        {
            ProposalCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount()
        {
            return ProposalCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.Proposals
        /// </summary>
        [StorageChange("FellowshipTreasury", "Proposals")]
        public void OnUpdateProposals(string key, string data)
        {
            ProposalsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal GetProposals(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProposalsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.Deactivated
        /// </summary>
        [StorageChange("FellowshipTreasury", "Deactivated")]
        public void OnUpdateDeactivated(string data)
        {
            DeactivatedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetDeactivated()
        {
            return DeactivatedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.Approvals
        /// </summary>
        [StorageChange("FellowshipTreasury", "Approvals")]
        public void OnUpdateApprovals(string data)
        {
            ApprovalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 GetApprovals()
        {
            return ApprovalsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.SpendCount
        /// </summary>
        [StorageChange("FellowshipTreasury", "SpendCount")]
        public void OnUpdateSpendCount(string data)
        {
            SpendCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SpendCount
        ///  The count of spends that have been made.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetSpendCount()
        {
            return SpendCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipTreasury.Spends
        /// </summary>
        [StorageChange("FellowshipTreasury", "Spends")]
        public void OnUpdateSpends(string key, string data)
        {
            SpendsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Spends
        ///  Spends that have been approved and being processed.
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus GetSpends(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SpendsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
