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


namespace Substrate.Zeitgeist.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAuthorMappingStorage interface definition.
    /// </summary>
    public interface IAuthorMappingStorage : IStorage
    {
        
        /// <summary>
        /// >> MappingWithDeposit
        ///  We maintain a mapping from the NimbusIds used in the consensus layer
        ///  to the AccountIds runtime.
        /// </summary>
        Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo GetMappingWithDeposit(string key);
        
        /// <summary>
        /// >> NimbusLookup
        ///  We maintain a reverse mapping from AccountIds to NimbusIDS
        /// </summary>
        Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public GetNimbusLookup(string key);
    }
    
    /// <summary>
    /// AuthorMappingStorage class definition.
    /// </summary>
    public sealed class AuthorMappingStorage : IAuthorMappingStorage
    {
        
        /// <summary>
        /// _mappingWithDepositTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo> _mappingWithDepositTypedStorage;
        
        /// <summary>
        /// _nimbusLookupTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public> _nimbusLookupTypedStorage;
        
        /// <summary>
        /// AuthorMappingStorage constructor.
        /// </summary>
        public AuthorMappingStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MappingWithDepositTypedStorage = new TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo>("AuthorMapping.MappingWithDeposit", storageDataProvider, storageChangeDelegates);
            this.NimbusLookupTypedStorage = new TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public>("AuthorMapping.NimbusLookup", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _mappingWithDepositTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo> MappingWithDepositTypedStorage
        {
            get
            {
                return _mappingWithDepositTypedStorage;
            }
            set
            {
                _mappingWithDepositTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nimbusLookupTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public> NimbusLookupTypedStorage
        {
            get
            {
                return _nimbusLookupTypedStorage;
            }
            set
            {
                _nimbusLookupTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MappingWithDepositTypedStorage.InitializeAsync("AuthorMapping", "MappingWithDeposit");
            await NimbusLookupTypedStorage.InitializeAsync("AuthorMapping", "NimbusLookup");
        }
        
        /// <summary>
        /// Implements any storage change for AuthorMapping.MappingWithDeposit
        /// </summary>
        [StorageChange("AuthorMapping", "MappingWithDeposit")]
        public void OnUpdateMappingWithDeposit(string key, string data)
        {
            MappingWithDepositTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> MappingWithDeposit
        ///  We maintain a mapping from the NimbusIds used in the consensus layer
        ///  to the AccountIds runtime.
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo GetMappingWithDeposit(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MappingWithDepositTypedStorage.Dictionary.TryGetValue(key, out Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_author_mapping.pallet.RegistrationInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AuthorMapping.NimbusLookup
        /// </summary>
        [StorageChange("AuthorMapping", "NimbusLookup")]
        public void OnUpdateNimbusLookup(string key, string data)
        {
            NimbusLookupTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NimbusLookup
        ///  We maintain a reverse mapping from AccountIds to NimbusIDS
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public GetNimbusLookup(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NimbusLookupTypedStorage.Dictionary.TryGetValue(key, out Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public result))
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
