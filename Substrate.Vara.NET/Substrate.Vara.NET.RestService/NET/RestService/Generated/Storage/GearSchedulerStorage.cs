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


namespace Substrate.Vara.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IGearSchedulerStorage interface definition.
    /// </summary>
    public interface IGearSchedulerStorage : IStorage
    {
        
        /// <summary>
        /// >> FirstIncompleteTasksBlock
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetFirstIncompleteTasksBlock();
        
        /// <summary>
        /// >> TaskPool
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetTaskPool(string key);
    }
    
    /// <summary>
    /// GearSchedulerStorage class definition.
    /// </summary>
    public sealed class GearSchedulerStorage : IGearSchedulerStorage
    {
        
        /// <summary>
        /// _firstIncompleteTasksBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _firstIncompleteTasksBlockTypedStorage;
        
        /// <summary>
        /// _taskPoolTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _taskPoolTypedStorage;
        
        /// <summary>
        /// GearSchedulerStorage constructor.
        /// </summary>
        public GearSchedulerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.FirstIncompleteTasksBlockTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("GearScheduler.FirstIncompleteTasksBlock", storageDataProvider, storageChangeDelegates);
            this.TaskPoolTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("GearScheduler.TaskPool", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _firstIncompleteTasksBlockTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> FirstIncompleteTasksBlockTypedStorage
        {
            get
            {
                return _firstIncompleteTasksBlockTypedStorage;
            }
            set
            {
                _firstIncompleteTasksBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _taskPoolTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> TaskPoolTypedStorage
        {
            get
            {
                return _taskPoolTypedStorage;
            }
            set
            {
                _taskPoolTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await FirstIncompleteTasksBlockTypedStorage.InitializeAsync("GearScheduler", "FirstIncompleteTasksBlock");
            await TaskPoolTypedStorage.InitializeAsync("GearScheduler", "TaskPool");
        }
        
        /// <summary>
        /// Implements any storage change for GearScheduler.FirstIncompleteTasksBlock
        /// </summary>
        [StorageChange("GearScheduler", "FirstIncompleteTasksBlock")]
        public void OnUpdateFirstIncompleteTasksBlock(string data)
        {
            FirstIncompleteTasksBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> FirstIncompleteTasksBlock
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetFirstIncompleteTasksBlock()
        {
            return FirstIncompleteTasksBlockTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for GearScheduler.TaskPool
        /// </summary>
        [StorageChange("GearScheduler", "TaskPool")]
        public void OnUpdateTaskPool(string key, string data)
        {
            TaskPoolTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TaskPool
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetTaskPool(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TaskPoolTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
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