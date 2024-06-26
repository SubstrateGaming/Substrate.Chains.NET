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


namespace Substrate.HydraDX.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IXcmpQueueStorage interface definition.
    /// </summary>
    public interface IXcmpQueueStorage : IStorage
    {
        
        /// <summary>
        /// >> InboundXcmpStatus
        ///  Status of the inbound XCMP channels.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> GetInboundXcmpStatus();
        
        /// <summary>
        /// >> InboundXcmpMessages
        ///  Inbound aggregate XCMP messages. It can only be one per ParaId/block.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetInboundXcmpMessages(string key);
        
        /// <summary>
        /// >> OutboundXcmpStatus
        ///  The non-empty XCMP channels in order of becoming non-empty, and the index of the first
        ///  and last outbound message. If the two indices are equal, then it indicates an empty
        ///  queue and there must be a non-`Ok` `OutboundStatus`. We assume queues grow no greater
        ///  than 65535 items. Queue indices for normal messages begin at one; zero is reserved in
        ///  case of the need to send a high-priority signal message this block.
        ///  The bool is true if there is a signal message waiting to be sent.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> GetOutboundXcmpStatus();
        
        /// <summary>
        /// >> OutboundXcmpMessages
        ///  The messages outbound in a given XCMP channel.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetOutboundXcmpMessages(string key);
        
        /// <summary>
        /// >> SignalMessages
        ///  Any signal messages waiting to be sent.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetSignalMessages(string key);
        
        /// <summary>
        /// >> QueueConfig
        ///  The configuration which controls the dynamics of the outbound queue.
        /// </summary>
        Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData GetQueueConfig();
        
        /// <summary>
        /// >> Overweight
        ///  The messages that exceeded max individual message weight budget.
        /// 
        ///  These message stay in this storage map until they are manually dispatched via
        ///  `service_overweight`.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetOverweight(string key);
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForOverweight();
        
        /// <summary>
        /// >> OverweightCount
        ///  The number of overweight messages ever recorded in `Overweight`. Also doubles as the next
        ///  available free overweight index.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetOverweightCount();
        
        /// <summary>
        /// >> DeferredIndices
        ///  Index of deferred message buckets to process.
        /// </summary>
        Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 GetDeferredIndices(string key);
        
        /// <summary>
        /// >> DeferredMessageBuckets
        ///  Storage for deferred messages, indexed by para id, block and counter.
        /// </summary>
        Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 GetDeferredMessageBuckets(string key);
        
        /// <summary>
        /// >> QueueSuspended
        ///  Whether or not the XCMP queue is suspended from executing incoming XCMs or not.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetQueueSuspended();
        
        /// <summary>
        /// >> DeferredQueueSuspended
        ///  Whether or not the Deferred queue is suspended from executing XCMs or not.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetDeferredQueueSuspended();
        
        /// <summary>
        /// >> DeferAllBy
        ///  Whether or not and if so by how much to defer all incoming XCMs.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetDeferAllBy();
    }
    
    /// <summary>
    /// XcmpQueueStorage class definition.
    /// </summary>
    public sealed class XcmpQueueStorage : IXcmpQueueStorage
    {
        
        /// <summary>
        /// _inboundXcmpStatusTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails>> _inboundXcmpStatusTypedStorage;
        
        /// <summary>
        /// _inboundXcmpMessagesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> _inboundXcmpMessagesTypedStorage;
        
        /// <summary>
        /// _outboundXcmpStatusTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails>> _outboundXcmpStatusTypedStorage;
        
        /// <summary>
        /// _outboundXcmpMessagesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> _outboundXcmpMessagesTypedStorage;
        
        /// <summary>
        /// _signalMessagesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> _signalMessagesTypedStorage;
        
        /// <summary>
        /// _queueConfigTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData> _queueConfigTypedStorage;
        
        /// <summary>
        /// _overweightTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> _overweightTypedStorage;
        
        /// <summary>
        /// _counterForOverweightTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _counterForOverweightTypedStorage;
        
        /// <summary>
        /// _overweightCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> _overweightCountTypedStorage;
        
        /// <summary>
        /// _deferredIndicesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1> _deferredIndicesTypedStorage;
        
        /// <summary>
        /// _deferredMessageBucketsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43> _deferredMessageBucketsTypedStorage;
        
        /// <summary>
        /// _queueSuspendedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _queueSuspendedTypedStorage;
        
        /// <summary>
        /// _deferredQueueSuspendedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _deferredQueueSuspendedTypedStorage;
        
        /// <summary>
        /// _deferAllByTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _deferAllByTypedStorage;
        
        /// <summary>
        /// XcmpQueueStorage constructor.
        /// </summary>
        public XcmpQueueStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.InboundXcmpStatusTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails>>("XcmpQueue.InboundXcmpStatus", storageDataProvider, storageChangeDelegates);
            this.InboundXcmpMessagesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>("XcmpQueue.InboundXcmpMessages", storageDataProvider, storageChangeDelegates);
            this.OutboundXcmpStatusTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails>>("XcmpQueue.OutboundXcmpStatus", storageDataProvider, storageChangeDelegates);
            this.OutboundXcmpMessagesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>("XcmpQueue.OutboundXcmpMessages", storageDataProvider, storageChangeDelegates);
            this.SignalMessagesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>("XcmpQueue.SignalMessages", storageDataProvider, storageChangeDelegates);
            this.QueueConfigTypedStorage = new TypedStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData>("XcmpQueue.QueueConfig", storageDataProvider, storageChangeDelegates);
            this.OverweightTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>("XcmpQueue.Overweight", storageDataProvider, storageChangeDelegates);
            this.CounterForOverweightTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("XcmpQueue.CounterForOverweight", storageDataProvider, storageChangeDelegates);
            this.OverweightCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64>("XcmpQueue.OverweightCount", storageDataProvider, storageChangeDelegates);
            this.DeferredIndicesTypedStorage = new TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1>("XcmpQueue.DeferredIndices", storageDataProvider, storageChangeDelegates);
            this.DeferredMessageBucketsTypedStorage = new TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43>("XcmpQueue.DeferredMessageBuckets", storageDataProvider, storageChangeDelegates);
            this.QueueSuspendedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("XcmpQueue.QueueSuspended", storageDataProvider, storageChangeDelegates);
            this.DeferredQueueSuspendedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("XcmpQueue.DeferredQueueSuspended", storageDataProvider, storageChangeDelegates);
            this.DeferAllByTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("XcmpQueue.DeferAllBy", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _inboundXcmpStatusTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails>> InboundXcmpStatusTypedStorage
        {
            get
            {
                return _inboundXcmpStatusTypedStorage;
            }
            set
            {
                _inboundXcmpStatusTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _inboundXcmpMessagesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> InboundXcmpMessagesTypedStorage
        {
            get
            {
                return _inboundXcmpMessagesTypedStorage;
            }
            set
            {
                _inboundXcmpMessagesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _outboundXcmpStatusTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails>> OutboundXcmpStatusTypedStorage
        {
            get
            {
                return _outboundXcmpStatusTypedStorage;
            }
            set
            {
                _outboundXcmpStatusTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _outboundXcmpMessagesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> OutboundXcmpMessagesTypedStorage
        {
            get
            {
                return _outboundXcmpMessagesTypedStorage;
            }
            set
            {
                _outboundXcmpMessagesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _signalMessagesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> SignalMessagesTypedStorage
        {
            get
            {
                return _signalMessagesTypedStorage;
            }
            set
            {
                _signalMessagesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queueConfigTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData> QueueConfigTypedStorage
        {
            get
            {
                return _queueConfigTypedStorage;
            }
            set
            {
                _queueConfigTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _overweightTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> OverweightTypedStorage
        {
            get
            {
                return _overweightTypedStorage;
            }
            set
            {
                _overweightTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _counterForOverweightTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> CounterForOverweightTypedStorage
        {
            get
            {
                return _counterForOverweightTypedStorage;
            }
            set
            {
                _counterForOverweightTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _overweightCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> OverweightCountTypedStorage
        {
            get
            {
                return _overweightCountTypedStorage;
            }
            set
            {
                _overweightCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deferredIndicesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1> DeferredIndicesTypedStorage
        {
            get
            {
                return _deferredIndicesTypedStorage;
            }
            set
            {
                _deferredIndicesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deferredMessageBucketsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43> DeferredMessageBucketsTypedStorage
        {
            get
            {
                return _deferredMessageBucketsTypedStorage;
            }
            set
            {
                _deferredMessageBucketsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queueSuspendedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> QueueSuspendedTypedStorage
        {
            get
            {
                return _queueSuspendedTypedStorage;
            }
            set
            {
                _queueSuspendedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deferredQueueSuspendedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> DeferredQueueSuspendedTypedStorage
        {
            get
            {
                return _deferredQueueSuspendedTypedStorage;
            }
            set
            {
                _deferredQueueSuspendedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deferAllByTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> DeferAllByTypedStorage
        {
            get
            {
                return _deferAllByTypedStorage;
            }
            set
            {
                _deferAllByTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await InboundXcmpStatusTypedStorage.InitializeAsync("XcmpQueue", "InboundXcmpStatus");
            await InboundXcmpMessagesTypedStorage.InitializeAsync("XcmpQueue", "InboundXcmpMessages");
            await OutboundXcmpStatusTypedStorage.InitializeAsync("XcmpQueue", "OutboundXcmpStatus");
            await OutboundXcmpMessagesTypedStorage.InitializeAsync("XcmpQueue", "OutboundXcmpMessages");
            await SignalMessagesTypedStorage.InitializeAsync("XcmpQueue", "SignalMessages");
            await QueueConfigTypedStorage.InitializeAsync("XcmpQueue", "QueueConfig");
            await OverweightTypedStorage.InitializeAsync("XcmpQueue", "Overweight");
            await CounterForOverweightTypedStorage.InitializeAsync("XcmpQueue", "CounterForOverweight");
            await OverweightCountTypedStorage.InitializeAsync("XcmpQueue", "OverweightCount");
            await DeferredIndicesTypedStorage.InitializeAsync("XcmpQueue", "DeferredIndices");
            await DeferredMessageBucketsTypedStorage.InitializeAsync("XcmpQueue", "DeferredMessageBuckets");
            await QueueSuspendedTypedStorage.InitializeAsync("XcmpQueue", "QueueSuspended");
            await DeferredQueueSuspendedTypedStorage.InitializeAsync("XcmpQueue", "DeferredQueueSuspended");
            await DeferAllByTypedStorage.InitializeAsync("XcmpQueue", "DeferAllBy");
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.InboundXcmpStatus
        /// </summary>
        [StorageChange("XcmpQueue", "InboundXcmpStatus")]
        public void OnUpdateInboundXcmpStatus(string data)
        {
            InboundXcmpStatusTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InboundXcmpStatus
        ///  Status of the inbound XCMP channels.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> GetInboundXcmpStatus()
        {
            return InboundXcmpStatusTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.InboundXcmpMessages
        /// </summary>
        [StorageChange("XcmpQueue", "InboundXcmpMessages")]
        public void OnUpdateInboundXcmpMessages(string key, string data)
        {
            InboundXcmpMessagesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> InboundXcmpMessages
        ///  Inbound aggregate XCMP messages. It can only be one per ParaId/block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetInboundXcmpMessages(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (InboundXcmpMessagesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.OutboundXcmpStatus
        /// </summary>
        [StorageChange("XcmpQueue", "OutboundXcmpStatus")]
        public void OnUpdateOutboundXcmpStatus(string data)
        {
            OutboundXcmpStatusTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> OutboundXcmpStatus
        ///  The non-empty XCMP channels in order of becoming non-empty, and the index of the first
        ///  and last outbound message. If the two indices are equal, then it indicates an empty
        ///  queue and there must be a non-`Ok` `OutboundStatus`. We assume queues grow no greater
        ///  than 65535 items. Queue indices for normal messages begin at one; zero is reserved in
        ///  case of the need to send a high-priority signal message this block.
        ///  The bool is true if there is a signal message waiting to be sent.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> GetOutboundXcmpStatus()
        {
            return OutboundXcmpStatusTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.OutboundXcmpMessages
        /// </summary>
        [StorageChange("XcmpQueue", "OutboundXcmpMessages")]
        public void OnUpdateOutboundXcmpMessages(string key, string data)
        {
            OutboundXcmpMessagesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> OutboundXcmpMessages
        ///  The messages outbound in a given XCMP channel.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetOutboundXcmpMessages(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OutboundXcmpMessagesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.SignalMessages
        /// </summary>
        [StorageChange("XcmpQueue", "SignalMessages")]
        public void OnUpdateSignalMessages(string key, string data)
        {
            SignalMessagesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SignalMessages
        ///  Any signal messages waiting to be sent.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetSignalMessages(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SignalMessagesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.QueueConfig
        /// </summary>
        [StorageChange("XcmpQueue", "QueueConfig")]
        public void OnUpdateQueueConfig(string data)
        {
            QueueConfigTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueueConfig
        ///  The configuration which controls the dynamics of the outbound queue.
        /// </summary>
        public Substrate.HydraDX.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData GetQueueConfig()
        {
            return QueueConfigTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.Overweight
        /// </summary>
        [StorageChange("XcmpQueue", "Overweight")]
        public void OnUpdateOverweight(string key, string data)
        {
            OverweightTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Overweight
        ///  The messages that exceeded max individual message weight budget.
        /// 
        ///  These message stay in this storage map until they are manually dispatched via
        ///  `service_overweight`.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetOverweight(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OverweightTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.CounterForOverweight
        /// </summary>
        [StorageChange("XcmpQueue", "CounterForOverweight")]
        public void OnUpdateCounterForOverweight(string data)
        {
            CounterForOverweightTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForOverweight()
        {
            return CounterForOverweightTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.OverweightCount
        /// </summary>
        [StorageChange("XcmpQueue", "OverweightCount")]
        public void OnUpdateOverweightCount(string data)
        {
            OverweightCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> OverweightCount
        ///  The number of overweight messages ever recorded in `Overweight`. Also doubles as the next
        ///  available free overweight index.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetOverweightCount()
        {
            return OverweightCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.DeferredIndices
        /// </summary>
        [StorageChange("XcmpQueue", "DeferredIndices")]
        public void OnUpdateDeferredIndices(string key, string data)
        {
            DeferredIndicesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DeferredIndices
        ///  Index of deferred message buckets to process.
        /// </summary>
        public Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 GetDeferredIndices(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DeferredIndicesTypedStorage.Dictionary.TryGetValue(key, out Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.DeferredMessageBuckets
        /// </summary>
        [StorageChange("XcmpQueue", "DeferredMessageBuckets")]
        public void OnUpdateDeferredMessageBuckets(string key, string data)
        {
            DeferredMessageBucketsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DeferredMessageBuckets
        ///  Storage for deferred messages, indexed by para id, block and counter.
        /// </summary>
        public Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 GetDeferredMessageBuckets(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DeferredMessageBucketsTypedStorage.Dictionary.TryGetValue(key, out Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.QueueSuspended
        /// </summary>
        [StorageChange("XcmpQueue", "QueueSuspended")]
        public void OnUpdateQueueSuspended(string data)
        {
            QueueSuspendedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueueSuspended
        ///  Whether or not the XCMP queue is suspended from executing incoming XCMs or not.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetQueueSuspended()
        {
            return QueueSuspendedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.DeferredQueueSuspended
        /// </summary>
        [StorageChange("XcmpQueue", "DeferredQueueSuspended")]
        public void OnUpdateDeferredQueueSuspended(string data)
        {
            DeferredQueueSuspendedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DeferredQueueSuspended
        ///  Whether or not the Deferred queue is suspended from executing XCMs or not.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetDeferredQueueSuspended()
        {
            return DeferredQueueSuspendedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmpQueue.DeferAllBy
        /// </summary>
        [StorageChange("XcmpQueue", "DeferAllBy")]
        public void OnUpdateDeferAllBy(string data)
        {
            DeferAllByTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DeferAllBy
        ///  Whether or not and if so by how much to defer all incoming XCMs.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetDeferAllBy()
        {
            return DeferAllByTypedStorage.Get();
        }
    }
}
