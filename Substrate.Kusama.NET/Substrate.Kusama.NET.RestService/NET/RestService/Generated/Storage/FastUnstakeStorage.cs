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


namespace Substrate.Kusama.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IFastUnstakeStorage interface definition.
    /// </summary>
    public interface IFastUnstakeStorage : IStorage
    {
        
        /// <summary>
        /// >> Head
        ///  The current "head of the queue" being unstaked.
        /// 
        ///  The head in itself can be a batch of up to [`Config::BatchSize`] stakers.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest GetHead();
        
        /// <summary>
        /// >> Queue
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetQueue(string key);
        
        /// <summary>
        /// >> CounterForQueue
        /// Counter for the related counted storage map
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForQueue();
        
        /// <summary>
        /// >> ErasToCheckPerBlock
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing. Cannot be set to more than
        ///  [`Config::MaxErasToCheckPerBlock`].
        /// 
        ///  Based on the amount of weight available at [`Pallet::on_idle`], up to this many eras are
        ///  checked. The checking is represented by updating [`UnstakeRequest::checked`], which is
        ///  stored in [`Head`].
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetErasToCheckPerBlock();
    }
    
    /// <summary>
    /// FastUnstakeStorage class definition.
    /// </summary>
    public sealed class FastUnstakeStorage : IFastUnstakeStorage
    {
        
        /// <summary>
        /// _headTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest> _headTypedStorage;
        
        /// <summary>
        /// _queueTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _queueTypedStorage;
        
        /// <summary>
        /// _counterForQueueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _counterForQueueTypedStorage;
        
        /// <summary>
        /// _erasToCheckPerBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _erasToCheckPerBlockTypedStorage;
        
        /// <summary>
        /// FastUnstakeStorage constructor.
        /// </summary>
        public FastUnstakeStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.HeadTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest>("FastUnstake.Head", storageDataProvider, storageChangeDelegates);
            this.QueueTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("FastUnstake.Queue", storageDataProvider, storageChangeDelegates);
            this.CounterForQueueTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FastUnstake.CounterForQueue", storageDataProvider, storageChangeDelegates);
            this.ErasToCheckPerBlockTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FastUnstake.ErasToCheckPerBlock", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _headTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest> HeadTypedStorage
        {
            get
            {
                return _headTypedStorage;
            }
            set
            {
                _headTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queueTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> QueueTypedStorage
        {
            get
            {
                return _queueTypedStorage;
            }
            set
            {
                _queueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _counterForQueueTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> CounterForQueueTypedStorage
        {
            get
            {
                return _counterForQueueTypedStorage;
            }
            set
            {
                _counterForQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _erasToCheckPerBlockTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ErasToCheckPerBlockTypedStorage
        {
            get
            {
                return _erasToCheckPerBlockTypedStorage;
            }
            set
            {
                _erasToCheckPerBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await HeadTypedStorage.InitializeAsync("FastUnstake", "Head");
            await QueueTypedStorage.InitializeAsync("FastUnstake", "Queue");
            await CounterForQueueTypedStorage.InitializeAsync("FastUnstake", "CounterForQueue");
            await ErasToCheckPerBlockTypedStorage.InitializeAsync("FastUnstake", "ErasToCheckPerBlock");
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.Head
        /// </summary>
        [StorageChange("FastUnstake", "Head")]
        public void OnUpdateHead(string data)
        {
            HeadTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Head
        ///  The current "head of the queue" being unstaked.
        /// 
        ///  The head in itself can be a batch of up to [`Config::BatchSize`] stakers.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest GetHead()
        {
            return HeadTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.Queue
        /// </summary>
        [StorageChange("FastUnstake", "Queue")]
        public void OnUpdateQueue(string key, string data)
        {
            QueueTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Queue
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetQueue(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (QueueTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.CounterForQueue
        /// </summary>
        [StorageChange("FastUnstake", "CounterForQueue")]
        public void OnUpdateCounterForQueue(string data)
        {
            CounterForQueueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CounterForQueue
        /// Counter for the related counted storage map
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForQueue()
        {
            return CounterForQueueTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.ErasToCheckPerBlock
        /// </summary>
        [StorageChange("FastUnstake", "ErasToCheckPerBlock")]
        public void OnUpdateErasToCheckPerBlock(string data)
        {
            ErasToCheckPerBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ErasToCheckPerBlock
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing. Cannot be set to more than
        ///  [`Config::MaxErasToCheckPerBlock`].
        /// 
        ///  Based on the amount of weight available at [`Pallet::on_idle`], up to this many eras are
        ///  checked. The checking is represented by updating [`UnstakeRequest::checked`], which is
        ///  stored in [`Head`].
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetErasToCheckPerBlock()
        {
            return ErasToCheckPerBlockTypedStorage.Get();
        }
    }
}
