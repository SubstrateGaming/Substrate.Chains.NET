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


namespace Substrate.Statemint.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IMultisigStorage interface definition.
    /// </summary>
    public interface IMultisigStorage : IStorage
    {
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig GetMultisigs(string key);
    }
    
    /// <summary>
    /// MultisigStorage class definition.
    /// </summary>
    public sealed class MultisigStorage : IMultisigStorage
    {
        
        /// <summary>
        /// _multisigsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig> _multisigsTypedStorage;
        
        /// <summary>
        /// MultisigStorage constructor.
        /// </summary>
        public MultisigStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MultisigsTypedStorage = new TypedMapStorage<Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig>("Multisig.Multisigs", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _multisigsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig> MultisigsTypedStorage
        {
            get
            {
                return _multisigsTypedStorage;
            }
            set
            {
                _multisigsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MultisigsTypedStorage.InitializeAsync("Multisig", "Multisigs");
        }
        
        /// <summary>
        /// Implements any storage change for Multisig.Multisigs
        /// </summary>
        [StorageChange("Multisig", "Multisigs")]
        public void OnUpdateMultisigs(string key, string data)
        {
            MultisigsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        public Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig GetMultisigs(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MultisigsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_multisig.Multisig result))
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