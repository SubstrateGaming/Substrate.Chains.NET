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


namespace Substrate.Bajun.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ICouncilMembershipStorage interface definition.
    /// </summary>
    public interface ICouncilMembershipStorage : IStorage
    {
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT45 GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime();
    }
    
    /// <summary>
    /// CouncilMembershipStorage class definition.
    /// </summary>
    public sealed class CouncilMembershipStorage : ICouncilMembershipStorage
    {
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT45> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _primeTypedStorage;
        
        /// <summary>
        /// CouncilMembershipStorage constructor.
        /// </summary>
        public CouncilMembershipStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MembersTypedStorage = new TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT45>("CouncilMembership.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("CouncilMembership.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT45> MembersTypedStorage
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
        public TypedStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> PrimeTypedStorage
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
            await MembersTypedStorage.InitializeAsync("CouncilMembership", "Members");
            await PrimeTypedStorage.InitializeAsync("CouncilMembership", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for CouncilMembership.Members
        /// </summary>
        [StorageChange("CouncilMembership", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT45 GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CouncilMembership.Prime
        /// </summary>
        [StorageChange("CouncilMembership", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}
