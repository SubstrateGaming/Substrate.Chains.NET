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


namespace Substrate.GameDAO.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ISenseStorage interface definition.
    /// </summary>
    public interface ISenseStorage : IStorage
    {
        
        /// <summary>
        /// >> Entities
        ///  Sense Entity of the account.
        /// 
        ///  Entities: map AccountId => Entity
        /// </summary>
        Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity GetEntities(string key);
        
        /// <summary>
        /// >> EntityCount
        ///  EntityCount. Increase per each entity creation.
        /// 
        ///  EntityCount: u128
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetEntityCount();
        
        /// <summary>
        /// >> Properties
        ///  All properties of the account.
        /// 
        ///  Properties: map (PropertyType, AccountId) => EntityProperty
        /// </summary>
        Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty GetProperties(string key);
    }
    
    /// <summary>
    /// SenseStorage class definition.
    /// </summary>
    public sealed class SenseStorage : ISenseStorage
    {
        
        /// <summary>
        /// _entitiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity> _entitiesTypedStorage;
        
        /// <summary>
        /// _entityCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _entityCountTypedStorage;
        
        /// <summary>
        /// _propertiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty> _propertiesTypedStorage;
        
        /// <summary>
        /// SenseStorage constructor.
        /// </summary>
        public SenseStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.EntitiesTypedStorage = new TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity>("Sense.Entities", storageDataProvider, storageChangeDelegates);
            this.EntityCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Sense.EntityCount", storageDataProvider, storageChangeDelegates);
            this.PropertiesTypedStorage = new TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty>("Sense.Properties", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _entitiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity> EntitiesTypedStorage
        {
            get
            {
                return _entitiesTypedStorage;
            }
            set
            {
                _entitiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _entityCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> EntityCountTypedStorage
        {
            get
            {
                return _entityCountTypedStorage;
            }
            set
            {
                _entityCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _propertiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty> PropertiesTypedStorage
        {
            get
            {
                return _propertiesTypedStorage;
            }
            set
            {
                _propertiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await EntitiesTypedStorage.InitializeAsync("Sense", "Entities");
            await EntityCountTypedStorage.InitializeAsync("Sense", "EntityCount");
            await PropertiesTypedStorage.InitializeAsync("Sense", "Properties");
        }
        
        /// <summary>
        /// Implements any storage change for Sense.Entities
        /// </summary>
        [StorageChange("Sense", "Entities")]
        public void OnUpdateEntities(string key, string data)
        {
            EntitiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Entities
        ///  Sense Entity of the account.
        /// 
        ///  Entities: map AccountId => Entity
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity GetEntities(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (EntitiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.Entity result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Sense.EntityCount
        /// </summary>
        [StorageChange("Sense", "EntityCount")]
        public void OnUpdateEntityCount(string data)
        {
            EntityCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> EntityCount
        ///  EntityCount. Increase per each entity creation.
        /// 
        ///  EntityCount: u128
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetEntityCount()
        {
            return EntityCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Sense.Properties
        /// </summary>
        [StorageChange("Sense", "Properties")]
        public void OnUpdateProperties(string key, string data)
        {
            PropertiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Properties
        ///  All properties of the account.
        /// 
        ///  Properties: map (PropertyType, AccountId) => EntityProperty
        /// </summary>
        public Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty GetProperties(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PropertiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_sense.types.EntityProperty result))
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