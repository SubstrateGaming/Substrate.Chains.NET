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


namespace Substrate.Aventus.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// INftManagerStorage interface definition.
    /// </summary>
    public interface INftManagerStorage : IStorage
    {
        
        /// <summary>
        /// >> Nfts
        ///  A mapping between NFT Id and data
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft GetNfts(string key);
        
        /// <summary>
        /// >> NftInfos
        ///  A mapping between NFT info Id and info data
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo GetNftInfos(string key);
        
        /// <summary>
        /// >> NftBatches
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> GetNftBatches(string key);
        
        /// <summary>
        /// >> BatchInfoId
        ///  A mapping between the external batch id and its corresponding NtfInfoId
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetBatchInfoId(string key);
        
        /// <summary>
        /// >> UsedExternalReferences
        ///  A mapping between an ExternalRef and a flag to show that an NFT has used it
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetUsedExternalReferences(string key);
        
        /// <summary>
        /// >> NextInfoId
        ///  The Id that will be used when creating the new NftInfo record
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetNextInfoId();
        
        /// <summary>
        /// >> NextSingleNftUniqueId
        ///  The Id that will be used when creating the new single Nft
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetNextSingleNftUniqueId();
        
        /// <summary>
        /// >> NftOpenForSale
        ///  A mapping that keeps all the nfts that are open to sale in a specific market
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType GetNftOpenForSale(string key);
        
        /// <summary>
        /// >> OwnedNfts
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> GetOwnedNfts(string key);
        
        /// <summary>
        /// >> StorageVersion
        ///  The version of this storage
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases GetStorageVersion();
        
        /// <summary>
        /// >> BatchNonces
        ///  An account nonce that represents the number of proxy transactions from this account
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetBatchNonces(string key);
        
        /// <summary>
        /// >> BatchOpenForSale
        ///  A mapping that keeps all the batches that are open to sale in a specific market
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType GetBatchOpenForSale(string key);
    }
    
    /// <summary>
    /// NftManagerStorage class definition.
    /// </summary>
    public sealed class NftManagerStorage : INftManagerStorage
    {
        
        /// <summary>
        /// _nftsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft> _nftsTypedStorage;
        
        /// <summary>
        /// _nftInfosTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo> _nftInfosTypedStorage;
        
        /// <summary>
        /// _nftBatchesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> _nftBatchesTypedStorage;
        
        /// <summary>
        /// _batchInfoIdTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> _batchInfoIdTypedStorage;
        
        /// <summary>
        /// _usedExternalReferencesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _usedExternalReferencesTypedStorage;
        
        /// <summary>
        /// _nextInfoIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> _nextInfoIdTypedStorage;
        
        /// <summary>
        /// _nextSingleNftUniqueIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> _nextSingleNftUniqueIdTypedStorage;
        
        /// <summary>
        /// _nftOpenForSaleTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> _nftOpenForSaleTypedStorage;
        
        /// <summary>
        /// _ownedNftsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> _ownedNftsTypedStorage;
        
        /// <summary>
        /// _storageVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases> _storageVersionTypedStorage;
        
        /// <summary>
        /// _batchNoncesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> _batchNoncesTypedStorage;
        
        /// <summary>
        /// _batchOpenForSaleTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> _batchOpenForSaleTypedStorage;
        
        /// <summary>
        /// NftManagerStorage constructor.
        /// </summary>
        public NftManagerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.NftsTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft>("NftManager.Nfts", storageDataProvider, storageChangeDelegates);
            this.NftInfosTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo>("NftManager.NftInfos", storageDataProvider, storageChangeDelegates);
            this.NftBatchesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>>("NftManager.NftBatches", storageDataProvider, storageChangeDelegates);
            this.BatchInfoIdTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>("NftManager.BatchInfoId", storageDataProvider, storageChangeDelegates);
            this.UsedExternalReferencesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("NftManager.UsedExternalReferences", storageDataProvider, storageChangeDelegates);
            this.NextInfoIdTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>("NftManager.NextInfoId", storageDataProvider, storageChangeDelegates);
            this.NextSingleNftUniqueIdTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>("NftManager.NextSingleNftUniqueId", storageDataProvider, storageChangeDelegates);
            this.NftOpenForSaleTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType>("NftManager.NftOpenForSale", storageDataProvider, storageChangeDelegates);
            this.OwnedNftsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>>("NftManager.OwnedNfts", storageDataProvider, storageChangeDelegates);
            this.StorageVersionTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases>("NftManager.StorageVersion", storageDataProvider, storageChangeDelegates);
            this.BatchNoncesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64>("NftManager.BatchNonces", storageDataProvider, storageChangeDelegates);
            this.BatchOpenForSaleTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType>("NftManager.BatchOpenForSale", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _nftsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft> NftsTypedStorage
        {
            get
            {
                return _nftsTypedStorage;
            }
            set
            {
                _nftsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nftInfosTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo> NftInfosTypedStorage
        {
            get
            {
                return _nftInfosTypedStorage;
            }
            set
            {
                _nftInfosTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nftBatchesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> NftBatchesTypedStorage
        {
            get
            {
                return _nftBatchesTypedStorage;
            }
            set
            {
                _nftBatchesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _batchInfoIdTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> BatchInfoIdTypedStorage
        {
            get
            {
                return _batchInfoIdTypedStorage;
            }
            set
            {
                _batchInfoIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _usedExternalReferencesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> UsedExternalReferencesTypedStorage
        {
            get
            {
                return _usedExternalReferencesTypedStorage;
            }
            set
            {
                _usedExternalReferencesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextInfoIdTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> NextInfoIdTypedStorage
        {
            get
            {
                return _nextInfoIdTypedStorage;
            }
            set
            {
                _nextInfoIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextSingleNftUniqueIdTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> NextSingleNftUniqueIdTypedStorage
        {
            get
            {
                return _nextSingleNftUniqueIdTypedStorage;
            }
            set
            {
                _nextSingleNftUniqueIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nftOpenForSaleTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> NftOpenForSaleTypedStorage
        {
            get
            {
                return _nftOpenForSaleTypedStorage;
            }
            set
            {
                _nftOpenForSaleTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownedNftsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> OwnedNftsTypedStorage
        {
            get
            {
                return _ownedNftsTypedStorage;
            }
            set
            {
                _ownedNftsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storageVersionTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases> StorageVersionTypedStorage
        {
            get
            {
                return _storageVersionTypedStorage;
            }
            set
            {
                _storageVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _batchNoncesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> BatchNoncesTypedStorage
        {
            get
            {
                return _batchNoncesTypedStorage;
            }
            set
            {
                _batchNoncesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _batchOpenForSaleTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> BatchOpenForSaleTypedStorage
        {
            get
            {
                return _batchOpenForSaleTypedStorage;
            }
            set
            {
                _batchOpenForSaleTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await NftsTypedStorage.InitializeAsync("NftManager", "Nfts");
            await NftInfosTypedStorage.InitializeAsync("NftManager", "NftInfos");
            await NftBatchesTypedStorage.InitializeAsync("NftManager", "NftBatches");
            await BatchInfoIdTypedStorage.InitializeAsync("NftManager", "BatchInfoId");
            await UsedExternalReferencesTypedStorage.InitializeAsync("NftManager", "UsedExternalReferences");
            await NextInfoIdTypedStorage.InitializeAsync("NftManager", "NextInfoId");
            await NextSingleNftUniqueIdTypedStorage.InitializeAsync("NftManager", "NextSingleNftUniqueId");
            await NftOpenForSaleTypedStorage.InitializeAsync("NftManager", "NftOpenForSale");
            await OwnedNftsTypedStorage.InitializeAsync("NftManager", "OwnedNfts");
            await StorageVersionTypedStorage.InitializeAsync("NftManager", "StorageVersion");
            await BatchNoncesTypedStorage.InitializeAsync("NftManager", "BatchNonces");
            await BatchOpenForSaleTypedStorage.InitializeAsync("NftManager", "BatchOpenForSale");
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.Nfts
        /// </summary>
        [StorageChange("NftManager", "Nfts")]
        public void OnUpdateNfts(string key, string data)
        {
            NftsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Nfts
        ///  A mapping between NFT Id and data
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft GetNfts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.NftInfos
        /// </summary>
        [StorageChange("NftManager", "NftInfos")]
        public void OnUpdateNftInfos(string key, string data)
        {
            NftInfosTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NftInfos
        ///  A mapping between NFT info Id and info data
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo GetNftInfos(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftInfosTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.NftBatches
        /// </summary>
        [StorageChange("NftManager", "NftBatches")]
        public void OnUpdateNftBatches(string key, string data)
        {
            NftBatchesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NftBatches
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> GetNftBatches(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftBatchesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.BatchInfoId
        /// </summary>
        [StorageChange("NftManager", "BatchInfoId")]
        public void OnUpdateBatchInfoId(string key, string data)
        {
            BatchInfoIdTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> BatchInfoId
        ///  A mapping between the external batch id and its corresponding NtfInfoId
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetBatchInfoId(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BatchInfoIdTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.UsedExternalReferences
        /// </summary>
        [StorageChange("NftManager", "UsedExternalReferences")]
        public void OnUpdateUsedExternalReferences(string key, string data)
        {
            UsedExternalReferencesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> UsedExternalReferences
        ///  A mapping between an ExternalRef and a flag to show that an NFT has used it
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetUsedExternalReferences(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (UsedExternalReferencesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.NextInfoId
        /// </summary>
        [StorageChange("NftManager", "NextInfoId")]
        public void OnUpdateNextInfoId(string data)
        {
            NextInfoIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextInfoId
        ///  The Id that will be used when creating the new NftInfo record
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetNextInfoId()
        {
            return NextInfoIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.NextSingleNftUniqueId
        /// </summary>
        [StorageChange("NftManager", "NextSingleNftUniqueId")]
        public void OnUpdateNextSingleNftUniqueId(string data)
        {
            NextSingleNftUniqueIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextSingleNftUniqueId
        ///  The Id that will be used when creating the new single Nft
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 GetNextSingleNftUniqueId()
        {
            return NextSingleNftUniqueIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.NftOpenForSale
        /// </summary>
        [StorageChange("NftManager", "NftOpenForSale")]
        public void OnUpdateNftOpenForSale(string key, string data)
        {
            NftOpenForSaleTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NftOpenForSale
        ///  A mapping that keeps all the nfts that are open to sale in a specific market
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType GetNftOpenForSale(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftOpenForSaleTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.OwnedNfts
        /// </summary>
        [StorageChange("NftManager", "OwnedNfts")]
        public void OnUpdateOwnedNfts(string key, string data)
        {
            OwnedNftsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> OwnedNfts
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> GetOwnedNfts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnedNftsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.StorageVersion
        /// </summary>
        [StorageChange("NftManager", "StorageVersion")]
        public void OnUpdateStorageVersion(string data)
        {
            StorageVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  The version of this storage
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases GetStorageVersion()
        {
            return StorageVersionTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.BatchNonces
        /// </summary>
        [StorageChange("NftManager", "BatchNonces")]
        public void OnUpdateBatchNonces(string key, string data)
        {
            BatchNoncesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> BatchNonces
        ///  An account nonce that represents the number of proxy transactions from this account
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetBatchNonces(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BatchNoncesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NftManager.BatchOpenForSale
        /// </summary>
        [StorageChange("NftManager", "BatchOpenForSale")]
        public void OnUpdateBatchOpenForSale(string key, string data)
        {
            BatchOpenForSaleTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> BatchOpenForSale
        ///  A mapping that keeps all the batches that are open to sale in a specific market
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType GetBatchOpenForSale(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BatchOpenForSaleTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType result))
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