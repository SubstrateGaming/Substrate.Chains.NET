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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class NftManagerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public NftManagerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "Nfts"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "NftInfos"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "NftBatches"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "BatchInfoId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "UsedExternalReferences"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "NextInfoId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "NextSingleNftUniqueId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "NftOpenForSale"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "OwnedNfts"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "StorageVersion"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "BatchNonces"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("NftManager", "BatchOpenForSale"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256), typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType)));
        }
        
        /// <summary>
        /// >> NftsParams
        ///  A mapping between NFT Id and data
        /// </summary>
        public static string NftsParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "Nfts", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NftsDefault
        /// Default value as hex string
        /// </summary>
        public static string NftsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Nfts
        ///  A mapping between NFT Id and data
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft> Nfts(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.NftsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Nft>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NftInfosParams
        ///  A mapping between NFT info Id and info data
        /// </summary>
        public static string NftInfosParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "NftInfos", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NftInfosDefault
        /// Default value as hex string
        /// </summary>
        public static string NftInfosDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> NftInfos
        ///  A mapping between NFT info Id and info data
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo> NftInfos(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.NftInfosParams(key);
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.NftInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NftBatchesParams
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public static string NftBatchesParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "NftBatches", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NftBatchesDefault
        /// Default value as hex string
        /// </summary>
        public static string NftBatchesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> NftBatches
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> NftBatches(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.NftBatchesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> BatchInfoIdParams
        ///  A mapping between the external batch id and its corresponding NtfInfoId
        /// </summary>
        public static string BatchInfoIdParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "BatchInfoId", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BatchInfoIdDefault
        /// Default value as hex string
        /// </summary>
        public static string BatchInfoIdDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> BatchInfoId
        ///  A mapping between the external batch id and its corresponding NtfInfoId
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> BatchInfoId(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.BatchInfoIdParams(key);
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> UsedExternalReferencesParams
        ///  A mapping between an ExternalRef and a flag to show that an NFT has used it
        /// </summary>
        public static string UsedExternalReferencesParams(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> key)
        {
            return RequestGenerator.GetStorage("NftManager", "UsedExternalReferences", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> UsedExternalReferencesDefault
        /// Default value as hex string
        /// </summary>
        public static string UsedExternalReferencesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> UsedExternalReferences
        ///  A mapping between an ExternalRef and a flag to show that an NFT has used it
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> UsedExternalReferences(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> key, CancellationToken token)
        {
            string parameters = NftManagerStorage.UsedExternalReferencesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NextInfoIdParams
        ///  The Id that will be used when creating the new NftInfo record
        /// </summary>
        public static string NextInfoIdParams()
        {
            return RequestGenerator.GetStorage("NftManager", "NextInfoId", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextInfoIdDefault
        /// Default value as hex string
        /// </summary>
        public static string NextInfoIdDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> NextInfoId
        ///  The Id that will be used when creating the new NftInfo record
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> NextInfoId(CancellationToken token)
        {
            string parameters = NftManagerStorage.NextInfoIdParams();
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NextSingleNftUniqueIdParams
        ///  The Id that will be used when creating the new single Nft
        /// </summary>
        public static string NextSingleNftUniqueIdParams()
        {
            return RequestGenerator.GetStorage("NftManager", "NextSingleNftUniqueId", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextSingleNftUniqueIdDefault
        /// Default value as hex string
        /// </summary>
        public static string NextSingleNftUniqueIdDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> NextSingleNftUniqueId
        ///  The Id that will be used when creating the new single Nft
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256> NextSingleNftUniqueId(CancellationToken token)
        {
            string parameters = NftManagerStorage.NextSingleNftUniqueIdParams();
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NftOpenForSaleParams
        ///  A mapping that keeps all the nfts that are open to sale in a specific market
        /// </summary>
        public static string NftOpenForSaleParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "NftOpenForSale", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NftOpenForSaleDefault
        /// Default value as hex string
        /// </summary>
        public static string NftOpenForSaleDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> NftOpenForSale
        ///  A mapping that keeps all the nfts that are open to sale in a specific market
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> NftOpenForSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.NftOpenForSaleParams(key);
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> OwnedNftsParams
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public static string OwnedNftsParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("NftManager", "OwnedNfts", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OwnedNftsDefault
        /// Default value as hex string
        /// </summary>
        public static string OwnedNftsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> OwnedNfts
        ///  A mapping between the external batch id and its nft Ids
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>> OwnedNfts(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.OwnedNftsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> StorageVersionParams
        ///  The version of this storage
        /// </summary>
        public static string StorageVersionParams()
        {
            return RequestGenerator.GetStorage("NftManager", "StorageVersion", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StorageVersionDefault
        /// Default value as hex string
        /// </summary>
        public static string StorageVersionDefault()
        {
            return "0x02";
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  The version of this storage
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases> StorageVersion(CancellationToken token)
        {
            string parameters = NftManagerStorage.StorageVersionParams();
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.EnumReleases>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> BatchNoncesParams
        ///  An account nonce that represents the number of proxy transactions from this account
        /// </summary>
        public static string BatchNoncesParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("NftManager", "BatchNonces", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BatchNoncesDefault
        /// Default value as hex string
        /// </summary>
        public static string BatchNoncesDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> BatchNonces
        ///  An account nonce that represents the number of proxy transactions from this account
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> BatchNonces(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.BatchNoncesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> BatchOpenForSaleParams
        ///  A mapping that keeps all the batches that are open to sale in a specific market
        /// </summary>
        public static string BatchOpenForSaleParams(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("NftManager", "BatchOpenForSale", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BatchOpenForSaleDefault
        /// Default value as hex string
        /// </summary>
        public static string BatchOpenForSaleDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> BatchOpenForSale
        ///  A mapping that keeps all the batches that are open to sale in a specific market
        /// </summary>
        public async Task<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType> BatchOpenForSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 key, CancellationToken token)
        {
            string parameters = NftManagerStorage.BatchOpenForSaleParams(key);
            var result = await _client.GetStorageAsync<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType>(parameters, token);
            return result;
        }
    }
    
    public sealed class NftManagerCalls
    {
        
        /// <summary>
        /// >> mint_single_nft
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MintSingleNft(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> unique_external_ref, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Royalty> royalties, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 t1_authority)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(unique_external_ref.Encode());
            byteArray.AddRange(royalties.Encode());
            byteArray.AddRange(t1_authority.Encode());
            return new Method(86, "NftManager", 0, "mint_single_nft", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_mint_single_nft
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedMintSingleNft(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> unique_external_ref, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Royalty> royalties, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 t1_authority)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(unique_external_ref.Encode());
            byteArray.AddRange(royalties.Encode());
            byteArray.AddRange(t1_authority.Encode());
            return new Method(86, "NftManager", 1, "signed_mint_single_nft", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> list_nft_open_for_sale
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ListNftOpenForSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 nft_id, Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType market)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(nft_id.Encode());
            byteArray.AddRange(market.Encode());
            return new Method(86, "NftManager", 2, "list_nft_open_for_sale", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_list_nft_open_for_sale
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedListNftOpenForSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 nft_id, Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType market)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(nft_id.Encode());
            byteArray.AddRange(market.Encode());
            return new Method(86, "NftManager", 3, "signed_list_nft_open_for_sale", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_transfer_fiat_nft
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedTransferFiatNft(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 nft_id, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256 t2_transfer_to_public_key)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(nft_id.Encode());
            byteArray.AddRange(t2_transfer_to_public_key.Encode());
            return new Method(86, "NftManager", 4, "signed_transfer_fiat_nft", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_cancel_list_fiat_nft
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedCancelListFiatNft(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 nft_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(nft_id.Encode());
            return new Method(86, "NftManager", 5, "signed_cancel_list_fiat_nft", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> proxy
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Proxy(Substrate.Aventus.NET.NetApiExt.Generated.Model.avn_parachain_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(86, "NftManager", 6, "proxy", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_create_batch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedCreateBatch(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.NetApi.Model.Types.Primitive.U64 total_supply, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.Royalty> royalties, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 t1_authority)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(total_supply.Encode());
            byteArray.AddRange(royalties.Encode());
            byteArray.AddRange(t1_authority.Encode());
            return new Method(86, "NftManager", 7, "signed_create_batch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_mint_batch_nft
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedMintBatchNft(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 batch_id, Substrate.NetApi.Model.Types.Primitive.U64 index, Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 owner, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> unique_external_ref)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(batch_id.Encode());
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(unique_external_ref.Encode());
            return new Method(86, "NftManager", 8, "signed_mint_batch_nft", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_list_batch_for_sale
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedListBatchForSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 batch_id, Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data.EnumNftSaleType market)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(batch_id.Encode());
            byteArray.AddRange(market.Encode());
            return new Method(86, "NftManager", 9, "signed_list_batch_for_sale", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> signed_end_batch_sale
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SignedEndBatchSale(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.Proof proof, Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 batch_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            byteArray.AddRange(batch_id.Encode());
            return new Method(86, "NftManager", 10, "signed_end_batch_sale", byteArray.ToArray());
        }
    }
    
    public sealed class NftManagerConstants
    {
    }
    
    public enum NftManagerErrors
    {
        
        /// <summary>
        /// >> NftAlreadyExists
        /// </summary>
        NftAlreadyExists,
        
        /// <summary>
        /// >> RoyaltyRateIsNotValid
        /// When specifying rates, parts_per_million must not be greater than 1 million
        /// </summary>
        RoyaltyRateIsNotValid,
        
        /// <summary>
        /// >> TotalRoyaltyRateIsNotValid
        /// When specifying rates, sum of parts_per_millions must not be greater than 1 million
        /// </summary>
        TotalRoyaltyRateIsNotValid,
        
        /// <summary>
        /// >> T1AuthorityIsMandatory
        /// </summary>
        T1AuthorityIsMandatory,
        
        /// <summary>
        /// >> ExternalRefIsMandatory
        /// </summary>
        ExternalRefIsMandatory,
        
        /// <summary>
        /// >> ExternalRefIsAlreadyInUse
        /// The external reference is already used
        /// </summary>
        ExternalRefIsAlreadyInUse,
        
        /// <summary>
        /// >> NftInfoMissing
        /// There is not data associated with an nftInfoId
        /// </summary>
        NftInfoMissing,
        
        /// <summary>
        /// >> NftIdDoesNotExist
        /// </summary>
        NftIdDoesNotExist,
        
        /// <summary>
        /// >> UnsupportedMarket
        /// </summary>
        UnsupportedMarket,
        
        /// <summary>
        /// >> SenderIsNotSigner
        /// Signed extrinsic with a proof must be called by the signer of the proof
        /// </summary>
        SenderIsNotSigner,
        
        /// <summary>
        /// >> SenderIsNotOwner
        /// </summary>
        SenderIsNotOwner,
        
        /// <summary>
        /// >> NftAlreadyListed
        /// </summary>
        NftAlreadyListed,
        
        /// <summary>
        /// >> NftIsLocked
        /// </summary>
        NftIsLocked,
        
        /// <summary>
        /// >> NftNotListedForSale
        /// </summary>
        NftNotListedForSale,
        
        /// <summary>
        /// >> NftNotListedForEthereumSale
        /// </summary>
        NftNotListedForEthereumSale,
        
        /// <summary>
        /// >> NftNotListedForFiatSale
        /// </summary>
        NftNotListedForFiatSale,
        
        /// <summary>
        /// >> NoTier1EventForNftOperation
        /// </summary>
        NoTier1EventForNftOperation,
        
        /// <summary>
        /// >> NftNonceMismatch
        /// The op_id did not match the nft token nonce for the operation
        /// </summary>
        NftNonceMismatch,
        
        /// <summary>
        /// >> UnauthorizedTransaction
        /// </summary>
        UnauthorizedTransaction,
        
        /// <summary>
        /// >> UnauthorizedProxyTransaction
        /// </summary>
        UnauthorizedProxyTransaction,
        
        /// <summary>
        /// >> UnauthorizedSignedLiftNftOpenForSaleTransaction
        /// </summary>
        UnauthorizedSignedLiftNftOpenForSaleTransaction,
        
        /// <summary>
        /// >> UnauthorizedSignedMintSingleNftTransaction
        /// </summary>
        UnauthorizedSignedMintSingleNftTransaction,
        
        /// <summary>
        /// >> UnauthorizedSignedTransferFiatNftTransaction
        /// </summary>
        UnauthorizedSignedTransferFiatNftTransaction,
        
        /// <summary>
        /// >> UnauthorizedSignedCancelListFiatNftTransaction
        /// </summary>
        UnauthorizedSignedCancelListFiatNftTransaction,
        
        /// <summary>
        /// >> TransactionNotSupported
        /// </summary>
        TransactionNotSupported,
        
        /// <summary>
        /// >> TransferToIsMandatory
        /// </summary>
        TransferToIsMandatory,
        
        /// <summary>
        /// >> UnauthorizedSignedCreateBatchTransaction
        /// </summary>
        UnauthorizedSignedCreateBatchTransaction,
        
        /// <summary>
        /// >> BatchAlreadyExists
        /// </summary>
        BatchAlreadyExists,
        
        /// <summary>
        /// >> TotalSupplyZero
        /// </summary>
        TotalSupplyZero,
        
        /// <summary>
        /// >> UnauthorizedSignedMintBatchNftTransaction
        /// </summary>
        UnauthorizedSignedMintBatchNftTransaction,
        
        /// <summary>
        /// >> BatchIdIsMandatory
        /// </summary>
        BatchIdIsMandatory,
        
        /// <summary>
        /// >> BatchDoesNotExist
        /// </summary>
        BatchDoesNotExist,
        
        /// <summary>
        /// >> SenderIsNotBatchCreator
        /// </summary>
        SenderIsNotBatchCreator,
        
        /// <summary>
        /// >> TotalSupplyExceeded
        /// </summary>
        TotalSupplyExceeded,
        
        /// <summary>
        /// >> UnauthorizedSignedListBatchForSaleTransaction
        /// </summary>
        UnauthorizedSignedListBatchForSaleTransaction,
        
        /// <summary>
        /// >> BatchAlreadyListed
        /// </summary>
        BatchAlreadyListed,
        
        /// <summary>
        /// >> NoNftsToSell
        /// </summary>
        NoNftsToSell,
        
        /// <summary>
        /// >> BatchNotListed
        /// </summary>
        BatchNotListed,
        
        /// <summary>
        /// >> UnauthorizedSignedEndBatchSaleTransaction
        /// </summary>
        UnauthorizedSignedEndBatchSaleTransaction,
        
        /// <summary>
        /// >> BatchNotListedForFiatSale
        /// </summary>
        BatchNotListedForFiatSale,
        
        /// <summary>
        /// >> BatchNotListedForEthereumSale
        /// </summary>
        BatchNotListedForEthereumSale,
    }
}