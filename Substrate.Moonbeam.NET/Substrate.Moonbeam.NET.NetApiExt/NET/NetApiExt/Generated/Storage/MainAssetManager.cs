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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class AssetManagerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public AssetManagerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "AssetIdType"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "AssetTypeId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "AssetTypeUnitsPerSecond"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "LocalAssetCounter"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "LocalAssetDeposit"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetManager", "SupportedFeePaymentAssets"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType>)));
        }
        
        /// <summary>
        /// >> AssetIdTypeParams
        ///  Mapping from an asset id to asset type.
        ///  This is mostly used when receiving transaction specifying an asset directly,
        ///  like transferring an asset from this chain to another.
        /// </summary>
        public static string AssetIdTypeParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("AssetManager", "AssetIdType", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetIdTypeDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetIdTypeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssetIdType
        ///  Mapping from an asset id to asset type.
        ///  This is mostly used when receiving transaction specifying an asset directly,
        ///  like transferring an asset from this chain to another.
        /// </summary>
        public async Task<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType> AssetIdType(Substrate.NetApi.Model.Types.Primitive.U128 key, CancellationToken token)
        {
            string parameters = AssetManagerStorage.AssetIdTypeParams(key);
            var result = await _client.GetStorageAsync<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> AssetTypeIdParams
        ///  Reverse mapping of AssetIdType. Mapping from an asset type to an asset id.
        ///  This is mostly used when receiving a multilocation XCM message to retrieve
        ///  the corresponding asset in which tokens should me minted.
        /// </summary>
        public static string AssetTypeIdParams(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType key)
        {
            return RequestGenerator.GetStorage("AssetManager", "AssetTypeId", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetTypeIdDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetTypeIdDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssetTypeId
        ///  Reverse mapping of AssetIdType. Mapping from an asset type to an asset id.
        ///  This is mostly used when receiving a multilocation XCM message to retrieve
        ///  the corresponding asset in which tokens should me minted.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> AssetTypeId(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType key, CancellationToken token)
        {
            string parameters = AssetManagerStorage.AssetTypeIdParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> AssetTypeUnitsPerSecondParams
        ///  Stores the units per second for local execution for a AssetType.
        ///  This is used to know how to charge for XCM execution in a particular
        ///  asset
        ///  Not all assets might contain units per second, hence the different storage
        /// </summary>
        public static string AssetTypeUnitsPerSecondParams(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType key)
        {
            return RequestGenerator.GetStorage("AssetManager", "AssetTypeUnitsPerSecond", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetTypeUnitsPerSecondDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetTypeUnitsPerSecondDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssetTypeUnitsPerSecond
        ///  Stores the units per second for local execution for a AssetType.
        ///  This is used to know how to charge for XCM execution in a particular
        ///  asset
        ///  Not all assets might contain units per second, hence the different storage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> AssetTypeUnitsPerSecond(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType key, CancellationToken token)
        {
            string parameters = AssetManagerStorage.AssetTypeUnitsPerSecondParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LocalAssetCounterParams
        ///  Stores the counter of the number of local assets that have been
        ///  created so far
        ///  This value can be used to salt the creation of an assetId, e.g.,
        ///  by hashing it. This is particularly useful for cases like moonbeam
        ///  where letting users choose their assetId would result in collision
        ///  in the evm side.
        /// </summary>
        public static string LocalAssetCounterParams()
        {
            return RequestGenerator.GetStorage("AssetManager", "LocalAssetCounter", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> LocalAssetCounterDefault
        /// Default value as hex string
        /// </summary>
        public static string LocalAssetCounterDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> LocalAssetCounter
        ///  Stores the counter of the number of local assets that have been
        ///  created so far
        ///  This value can be used to salt the creation of an assetId, e.g.,
        ///  by hashing it. This is particularly useful for cases like moonbeam
        ///  where letting users choose their assetId would result in collision
        ///  in the evm side.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> LocalAssetCounter(CancellationToken token)
        {
            string parameters = AssetManagerStorage.LocalAssetCounterParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> LocalAssetDepositParams
        ///  Local asset deposits, a mapping from assetId to a struct
        ///  holding the creator (from which the deposit was reserved) and
        ///  the deposit amount
        /// </summary>
        public static string LocalAssetDepositParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("AssetManager", "LocalAssetDeposit", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LocalAssetDepositDefault
        /// Default value as hex string
        /// </summary>
        public static string LocalAssetDepositDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> LocalAssetDeposit
        ///  Local asset deposits, a mapping from assetId to a struct
        ///  holding the creator (from which the deposit was reserved) and
        ///  the deposit amount
        /// </summary>
        public async Task<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo> LocalAssetDeposit(Substrate.NetApi.Model.Types.Primitive.U128 key, CancellationToken token)
        {
            string parameters = AssetManagerStorage.LocalAssetDepositParams(key);
            var result = await _client.GetStorageAsync<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet.AssetInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> SupportedFeePaymentAssetsParams
        /// </summary>
        public static string SupportedFeePaymentAssetsParams()
        {
            return RequestGenerator.GetStorage("AssetManager", "SupportedFeePaymentAssets", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SupportedFeePaymentAssetsDefault
        /// Default value as hex string
        /// </summary>
        public static string SupportedFeePaymentAssetsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SupportedFeePaymentAssets
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType>> SupportedFeePaymentAssets(CancellationToken token)
        {
            string parameters = AssetManagerStorage.SupportedFeePaymentAssetsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType>>(parameters, token);
            return result;
        }
    }
    
    public sealed class AssetManagerCalls
    {
        
        /// <summary>
        /// >> register_foreign_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterForeignAsset(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType asset, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.asset_config.AssetRegistrarMetadata metadata, Substrate.NetApi.Model.Types.Primitive.U128 min_amount, Substrate.NetApi.Model.Types.Primitive.Bool is_sufficient)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(metadata.Encode());
            byteArray.AddRange(min_amount.Encode());
            byteArray.AddRange(is_sufficient.Encode());
            return new Method(105, "AssetManager", 0, "register_foreign_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_asset_units_per_second
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetAssetUnitsPerSecond(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType asset_type, Substrate.NetApi.Model.Types.Primitive.U128 units_per_second, Substrate.NetApi.Model.Types.Primitive.U32 num_assets_weight_hint)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_type.Encode());
            byteArray.AddRange(units_per_second.Encode());
            byteArray.AddRange(num_assets_weight_hint.Encode());
            return new Method(105, "AssetManager", 1, "set_asset_units_per_second", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_existing_asset_type
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ChangeExistingAssetType(Substrate.NetApi.Model.Types.Primitive.U128 asset_id, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType new_asset_type, Substrate.NetApi.Model.Types.Primitive.U32 num_assets_weight_hint)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(new_asset_type.Encode());
            byteArray.AddRange(num_assets_weight_hint.Encode());
            return new Method(105, "AssetManager", 2, "change_existing_asset_type", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_supported_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveSupportedAsset(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.moonbeam_runtime.xcm_config.EnumAssetType asset_type, Substrate.NetApi.Model.Types.Primitive.U32 num_assets_weight_hint)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_type.Encode());
            byteArray.AddRange(num_assets_weight_hint.Encode());
            return new Method(105, "AssetManager", 3, "remove_supported_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_existing_asset_type
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveExistingAssetType(Substrate.NetApi.Model.Types.Primitive.U128 asset_id, Substrate.NetApi.Model.Types.Primitive.U32 num_assets_weight_hint)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(num_assets_weight_hint.Encode());
            return new Method(105, "AssetManager", 4, "remove_existing_asset_type", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> register_local_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RegisterLocalAsset(Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 creator, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20 owner, Substrate.NetApi.Model.Types.Primitive.Bool is_sufficient, Substrate.NetApi.Model.Types.Primitive.U128 min_balance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(creator.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(is_sufficient.Encode());
            byteArray.AddRange(min_balance.Encode());
            return new Method(105, "AssetManager", 5, "register_local_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> destroy_foreign_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DestroyForeignAsset(Substrate.NetApi.Model.Types.Primitive.U128 asset_id, Substrate.NetApi.Model.Types.Primitive.U32 num_assets_weight_hint)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(num_assets_weight_hint.Encode());
            return new Method(105, "AssetManager", 6, "destroy_foreign_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> destroy_local_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DestroyLocalAsset(Substrate.NetApi.Model.Types.Primitive.U128 asset_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            return new Method(105, "AssetManager", 7, "destroy_local_asset", byteArray.ToArray());
        }
    }
    
    public sealed class AssetManagerConstants
    {
        
        /// <summary>
        /// >> LocalAssetDeposit
        ///  The basic amount of funds that must be reserved for a local asset.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 LocalAssetDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x000040B2BAC9E0191E02000000000000");
            return result;
        }
    }
    
    public enum AssetManagerErrors
    {
        
        /// <summary>
        /// >> ErrorCreatingAsset
        /// </summary>
        ErrorCreatingAsset,
        
        /// <summary>
        /// >> AssetAlreadyExists
        /// </summary>
        AssetAlreadyExists,
        
        /// <summary>
        /// >> AssetDoesNotExist
        /// </summary>
        AssetDoesNotExist,
        
        /// <summary>
        /// >> TooLowNumAssetsWeightHint
        /// </summary>
        TooLowNumAssetsWeightHint,
        
        /// <summary>
        /// >> LocalAssetLimitReached
        /// </summary>
        LocalAssetLimitReached,
        
        /// <summary>
        /// >> ErrorDestroyingAsset
        /// </summary>
        ErrorDestroyingAsset,
        
        /// <summary>
        /// >> NotSufficientDeposit
        /// </summary>
        NotSufficientDeposit,
        
        /// <summary>
        /// >> NonExistentLocalAsset
        /// </summary>
        NonExistentLocalAsset,
    }
}