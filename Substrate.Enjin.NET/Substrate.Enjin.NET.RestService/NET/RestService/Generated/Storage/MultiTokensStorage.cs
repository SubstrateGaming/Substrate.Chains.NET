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


namespace Substrate.Enjin.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IMultiTokensStorage interface definition.
    /// </summary>
    public interface IMultiTokensStorage : IStorage
    {
        
        /// <summary>
        /// >> TokenAccounts
        ///  Accounts per token
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount GetTokenAccounts(string key);
        
        /// <summary>
        /// >> Collections
        ///  The collections in existence and their ownership details.
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection GetCollections(string key);
        
        /// <summary>
        /// >> Tokens
        ///  Tokens storage
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token GetTokens(string key);
        
        /// <summary>
        /// >> NextCollectionId
        ///  Sequencer for collectionID generators.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetNextCollectionId();
        
        /// <summary>
        /// >> CollectionAccounts
        ///  Stores information for an account per collection
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount GetCollectionAccounts(string key);
        
        /// <summary>
        /// >> Attributes
        ///  Metadata of collections and tokens.
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute GetAttributes(string key);
        
        /// <summary>
        /// >> AssetIdsByLocation
        ///  Map of Locations to AssetIds of Foreign Tokens
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId GetAssetIdsByLocation(string key);
        
        /// <summary>
        /// >> Migrations
        ///  Stores last iterated keys for migrations. Used by multi block migrations
        ///  to resume from the last iterated key.
        /// 
        ///  Key is the storage prefix, value is the status of migration and last iterated key, if any.
        ///  i.e `["MultiTokens", "TokenAccounts"] -> (collection_id, token_id, account_id)`
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration GetMigrations(string key);
        
        /// <summary>
        /// >> MigrationStatus
        ///  Status of the current multi-block migration
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.EnumMigrationStage GetMigrationStatus();
        
        /// <summary>
        /// >> ClaimableCollectionIds
        ///  Stores data for an ethereum address
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19 GetClaimableCollectionIds(string key);
        
        /// <summary>
        /// >> UnmintableTokenIds
        ///  These token ids can only be minted by calling `force_mint`. The second key is an ethereum
        ///  base token id, and the value is the highest token index that cannot be minted. All token
        ///  indexes start from 1, so effectively it blocks token indexes from 1 to the value.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetUnmintableTokenIds(string key);
        
        /// <summary>
        /// >> NativeCollectionIds
        ///  Map of ethereum collection id to the native collection id
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetNativeCollectionIds(string key);
    }
    
    /// <summary>
    /// MultiTokensStorage class definition.
    /// </summary>
    public sealed class MultiTokensStorage : IMultiTokensStorage
    {
        
        /// <summary>
        /// _tokenAccountsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount> _tokenAccountsTypedStorage;
        
        /// <summary>
        /// _collectionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection> _collectionsTypedStorage;
        
        /// <summary>
        /// _tokensTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token> _tokensTypedStorage;
        
        /// <summary>
        /// _nextCollectionIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _nextCollectionIdTypedStorage;
        
        /// <summary>
        /// _collectionAccountsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount> _collectionAccountsTypedStorage;
        
        /// <summary>
        /// _attributesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute> _attributesTypedStorage;
        
        /// <summary>
        /// _assetIdsByLocationTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId> _assetIdsByLocationTypedStorage;
        
        /// <summary>
        /// _migrationsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration> _migrationsTypedStorage;
        
        /// <summary>
        /// _migrationStatusTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.EnumMigrationStage> _migrationStatusTypedStorage;
        
        /// <summary>
        /// _claimableCollectionIdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> _claimableCollectionIdsTypedStorage;
        
        /// <summary>
        /// _unmintableTokenIdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> _unmintableTokenIdsTypedStorage;
        
        /// <summary>
        /// _nativeCollectionIdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _nativeCollectionIdsTypedStorage;
        
        /// <summary>
        /// MultiTokensStorage constructor.
        /// </summary>
        public MultiTokensStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TokenAccountsTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount>("MultiTokens.TokenAccounts", storageDataProvider, storageChangeDelegates);
            this.CollectionsTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection>("MultiTokens.Collections", storageDataProvider, storageChangeDelegates);
            this.TokensTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token>("MultiTokens.Tokens", storageDataProvider, storageChangeDelegates);
            this.NextCollectionIdTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("MultiTokens.NextCollectionId", storageDataProvider, storageChangeDelegates);
            this.CollectionAccountsTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount>("MultiTokens.CollectionAccounts", storageDataProvider, storageChangeDelegates);
            this.AttributesTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute>("MultiTokens.Attributes", storageDataProvider, storageChangeDelegates);
            this.AssetIdsByLocationTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId>("MultiTokens.AssetIdsByLocation", storageDataProvider, storageChangeDelegates);
            this.MigrationsTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration>("MultiTokens.Migrations", storageDataProvider, storageChangeDelegates);
            this.MigrationStatusTypedStorage = new TypedStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.EnumMigrationStage>("MultiTokens.MigrationStatus", storageDataProvider, storageChangeDelegates);
            this.ClaimableCollectionIdsTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19>("MultiTokens.ClaimableCollectionIds", storageDataProvider, storageChangeDelegates);
            this.UnmintableTokenIdsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64>("MultiTokens.UnmintableTokenIds", storageDataProvider, storageChangeDelegates);
            this.NativeCollectionIdsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("MultiTokens.NativeCollectionIds", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _tokenAccountsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount> TokenAccountsTypedStorage
        {
            get
            {
                return _tokenAccountsTypedStorage;
            }
            set
            {
                _tokenAccountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection> CollectionsTypedStorage
        {
            get
            {
                return _collectionsTypedStorage;
            }
            set
            {
                _collectionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokensTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token> TokensTypedStorage
        {
            get
            {
                return _tokensTypedStorage;
            }
            set
            {
                _tokensTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextCollectionIdTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> NextCollectionIdTypedStorage
        {
            get
            {
                return _nextCollectionIdTypedStorage;
            }
            set
            {
                _nextCollectionIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionAccountsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount> CollectionAccountsTypedStorage
        {
            get
            {
                return _collectionAccountsTypedStorage;
            }
            set
            {
                _collectionAccountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _attributesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute> AttributesTypedStorage
        {
            get
            {
                return _attributesTypedStorage;
            }
            set
            {
                _attributesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _assetIdsByLocationTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId> AssetIdsByLocationTypedStorage
        {
            get
            {
                return _assetIdsByLocationTypedStorage;
            }
            set
            {
                _assetIdsByLocationTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _migrationsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration> MigrationsTypedStorage
        {
            get
            {
                return _migrationsTypedStorage;
            }
            set
            {
                _migrationsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _migrationStatusTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.EnumMigrationStage> MigrationStatusTypedStorage
        {
            get
            {
                return _migrationStatusTypedStorage;
            }
            set
            {
                _migrationStatusTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _claimableCollectionIdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> ClaimableCollectionIdsTypedStorage
        {
            get
            {
                return _claimableCollectionIdsTypedStorage;
            }
            set
            {
                _claimableCollectionIdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unmintableTokenIdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> UnmintableTokenIdsTypedStorage
        {
            get
            {
                return _unmintableTokenIdsTypedStorage;
            }
            set
            {
                _unmintableTokenIdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nativeCollectionIdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> NativeCollectionIdsTypedStorage
        {
            get
            {
                return _nativeCollectionIdsTypedStorage;
            }
            set
            {
                _nativeCollectionIdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TokenAccountsTypedStorage.InitializeAsync("MultiTokens", "TokenAccounts");
            await CollectionsTypedStorage.InitializeAsync("MultiTokens", "Collections");
            await TokensTypedStorage.InitializeAsync("MultiTokens", "Tokens");
            await NextCollectionIdTypedStorage.InitializeAsync("MultiTokens", "NextCollectionId");
            await CollectionAccountsTypedStorage.InitializeAsync("MultiTokens", "CollectionAccounts");
            await AttributesTypedStorage.InitializeAsync("MultiTokens", "Attributes");
            await AssetIdsByLocationTypedStorage.InitializeAsync("MultiTokens", "AssetIdsByLocation");
            await MigrationsTypedStorage.InitializeAsync("MultiTokens", "Migrations");
            await MigrationStatusTypedStorage.InitializeAsync("MultiTokens", "MigrationStatus");
            await ClaimableCollectionIdsTypedStorage.InitializeAsync("MultiTokens", "ClaimableCollectionIds");
            await UnmintableTokenIdsTypedStorage.InitializeAsync("MultiTokens", "UnmintableTokenIds");
            await NativeCollectionIdsTypedStorage.InitializeAsync("MultiTokens", "NativeCollectionIds");
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.TokenAccounts
        /// </summary>
        [StorageChange("MultiTokens", "TokenAccounts")]
        public void OnUpdateTokenAccounts(string key, string data)
        {
            TokenAccountsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenAccounts
        ///  Accounts per token
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount GetTokenAccounts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenAccountsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.token.types.TokenAccount result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.Collections
        /// </summary>
        [StorageChange("MultiTokens", "Collections")]
        public void OnUpdateCollections(string key, string data)
        {
            CollectionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Collections
        ///  The collections in existence and their ownership details.
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection GetCollections(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.collection.Collection result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.Tokens
        /// </summary>
        [StorageChange("MultiTokens", "Tokens")]
        public void OnUpdateTokens(string key, string data)
        {
            TokensTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Tokens
        ///  Tokens storage
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token GetTokens(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokensTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.Token result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.NextCollectionId
        /// </summary>
        [StorageChange("MultiTokens", "NextCollectionId")]
        public void OnUpdateNextCollectionId(string data)
        {
            NextCollectionIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextCollectionId
        ///  Sequencer for collectionID generators.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetNextCollectionId()
        {
            return NextCollectionIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.CollectionAccounts
        /// </summary>
        [StorageChange("MultiTokens", "CollectionAccounts")]
        public void OnUpdateCollectionAccounts(string key, string data)
        {
            CollectionAccountsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionAccounts
        ///  Stores information for an account per collection
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount GetCollectionAccounts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionAccountsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_multi_tokens.features.collection.types.CollectionAccount result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.Attributes
        /// </summary>
        [StorageChange("MultiTokens", "Attributes")]
        public void OnUpdateAttributes(string key, string data)
        {
            AttributesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Attributes
        ///  Metadata of collections and tokens.
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute GetAttributes(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AttributesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.attribute.Attribute result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.AssetIdsByLocation
        /// </summary>
        [StorageChange("MultiTokens", "AssetIdsByLocation")]
        public void OnUpdateAssetIdsByLocation(string key, string data)
        {
            AssetIdsByLocationTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AssetIdsByLocation
        ///  Map of Locations to AssetIds of Foreign Tokens
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId GetAssetIdsByLocation(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetIdsByLocationTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.token.AssetId result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.Migrations
        /// </summary>
        [StorageChange("MultiTokens", "Migrations")]
        public void OnUpdateMigrations(string key, string data)
        {
            MigrationsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Migrations
        ///  Stores last iterated keys for migrations. Used by multi block migrations
        ///  to resume from the last iterated key.
        /// 
        ///  Key is the storage prefix, value is the status of migration and last iterated key, if any.
        ///  i.e `["MultiTokens", "TokenAccounts"] -> (collection_id, token_id, account_id)`
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration GetMigrations(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MigrationsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.Migration result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.MigrationStatus
        /// </summary>
        [StorageChange("MultiTokens", "MigrationStatus")]
        public void OnUpdateMigrationStatus(string data)
        {
            MigrationStatusTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> MigrationStatus
        ///  Status of the current multi-block migration
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.migrations.EnumMigrationStage GetMigrationStatus()
        {
            return MigrationStatusTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.ClaimableCollectionIds
        /// </summary>
        [StorageChange("MultiTokens", "ClaimableCollectionIds")]
        public void OnUpdateClaimableCollectionIds(string key, string data)
        {
            ClaimableCollectionIdsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ClaimableCollectionIds
        ///  Stores data for an ethereum address
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19 GetClaimableCollectionIds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ClaimableCollectionIdsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.UnmintableTokenIds
        /// </summary>
        [StorageChange("MultiTokens", "UnmintableTokenIds")]
        public void OnUpdateUnmintableTokenIds(string key, string data)
        {
            UnmintableTokenIdsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> UnmintableTokenIds
        ///  These token ids can only be minted by calling `force_mint`. The second key is an ethereum
        ///  base token id, and the value is the highest token index that cannot be minted. All token
        ///  indexes start from 1, so effectively it blocks token indexes from 1 to the value.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetUnmintableTokenIds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (UnmintableTokenIdsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for MultiTokens.NativeCollectionIds
        /// </summary>
        [StorageChange("MultiTokens", "NativeCollectionIds")]
        public void OnUpdateNativeCollectionIds(string key, string data)
        {
            NativeCollectionIdsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NativeCollectionIds
        ///  Map of ethereum collection id to the native collection id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetNativeCollectionIds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NativeCollectionIdsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
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