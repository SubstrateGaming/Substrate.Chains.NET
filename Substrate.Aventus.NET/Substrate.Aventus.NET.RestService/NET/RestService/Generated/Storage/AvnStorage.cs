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
    /// IAvnStorage interface definition.
    /// </summary>
    public interface IAvnStorage : IStorage
    {
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators (address and key) that may issue a transaction from the
        ///  offchain worker.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.Validator> GetValidators();
    }
    
    /// <summary>
    /// AvnStorage class definition.
    /// </summary>
    public sealed class AvnStorage : IAvnStorage
    {
        
        /// <summary>
        /// _validatorsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.Validator>> _validatorsTypedStorage;
        
        /// <summary>
        /// AvnStorage constructor.
        /// </summary>
        public AvnStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ValidatorsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.Validator>>("Avn.Validators", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _validatorsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.Validator>> ValidatorsTypedStorage
        {
            get
            {
                return _validatorsTypedStorage;
            }
            set
            {
                _validatorsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ValidatorsTypedStorage.InitializeAsync("Avn", "Validators");
        }
        
        /// <summary>
        /// Implements any storage change for Avn.Validators
        /// </summary>
        [StorageChange("Avn", "Validators")]
        public void OnUpdateValidators(string data)
        {
            ValidatorsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators (address and key) that may issue a transaction from the
        ///  offchain worker.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.Validator> GetValidators()
        {
            return ValidatorsTypedStorage.Get();
        }
    }
}