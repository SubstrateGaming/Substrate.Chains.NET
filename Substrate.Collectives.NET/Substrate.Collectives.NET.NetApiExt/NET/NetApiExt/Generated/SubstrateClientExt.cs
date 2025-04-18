//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.Collectives.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Collectives.NET.NetApiExt.Generated
{
    
    
    /// <summary>
    /// >> Substrate Client Extension, including all Storage classes direct access.
    /// </summary>
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// ParachainSystemStorage storage calls.
        /// </summary>
        public ParachainSystemStorage ParachainSystemStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// ParachainInfoStorage storage calls.
        /// </summary>
        public ParachainInfoStorage ParachainInfoStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// AuthorshipStorage storage calls.
        /// </summary>
        public AuthorshipStorage AuthorshipStorage;
        
        /// <summary>
        /// CollatorSelectionStorage storage calls.
        /// </summary>
        public CollatorSelectionStorage CollatorSelectionStorage;
        
        /// <summary>
        /// SessionStorage storage calls.
        /// </summary>
        public SessionStorage SessionStorage;
        
        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public AuraStorage AuraStorage;
        
        /// <summary>
        /// AuraExtStorage storage calls.
        /// </summary>
        public AuraExtStorage AuraExtStorage;
        
        /// <summary>
        /// XcmpQueueStorage storage calls.
        /// </summary>
        public XcmpQueueStorage XcmpQueueStorage;
        
        /// <summary>
        /// PolkadotXcmStorage storage calls.
        /// </summary>
        public PolkadotXcmStorage PolkadotXcmStorage;
        
        /// <summary>
        /// CumulusXcmStorage storage calls.
        /// </summary>
        public CumulusXcmStorage CumulusXcmStorage;
        
        /// <summary>
        /// MessageQueueStorage storage calls.
        /// </summary>
        public MessageQueueStorage MessageQueueStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// AssetRateStorage storage calls.
        /// </summary>
        public AssetRateStorage AssetRateStorage;
        
        /// <summary>
        /// AllianceStorage storage calls.
        /// </summary>
        public AllianceStorage AllianceStorage;
        
        /// <summary>
        /// AllianceMotionStorage storage calls.
        /// </summary>
        public AllianceMotionStorage AllianceMotionStorage;
        
        /// <summary>
        /// FellowshipCollectiveStorage storage calls.
        /// </summary>
        public FellowshipCollectiveStorage FellowshipCollectiveStorage;
        
        /// <summary>
        /// FellowshipReferendaStorage storage calls.
        /// </summary>
        public FellowshipReferendaStorage FellowshipReferendaStorage;
        
        /// <summary>
        /// FellowshipOriginsStorage storage calls.
        /// </summary>
        public FellowshipOriginsStorage FellowshipOriginsStorage;
        
        /// <summary>
        /// FellowshipCoreStorage storage calls.
        /// </summary>
        public FellowshipCoreStorage FellowshipCoreStorage;
        
        /// <summary>
        /// FellowshipSalaryStorage storage calls.
        /// </summary>
        public FellowshipSalaryStorage FellowshipSalaryStorage;
        
        /// <summary>
        /// FellowshipTreasuryStorage storage calls.
        /// </summary>
        public FellowshipTreasuryStorage FellowshipTreasuryStorage;
        
        /// <summary>
        /// AmbassadorCollectiveStorage storage calls.
        /// </summary>
        public AmbassadorCollectiveStorage AmbassadorCollectiveStorage;
        
        /// <summary>
        /// AmbassadorReferendaStorage storage calls.
        /// </summary>
        public AmbassadorReferendaStorage AmbassadorReferendaStorage;
        
        /// <summary>
        /// AmbassadorOriginsStorage storage calls.
        /// </summary>
        public AmbassadorOriginsStorage AmbassadorOriginsStorage;
        
        /// <summary>
        /// AmbassadorCoreStorage storage calls.
        /// </summary>
        public AmbassadorCoreStorage AmbassadorCoreStorage;
        
        /// <summary>
        /// AmbassadorSalaryStorage storage calls.
        /// </summary>
        public AmbassadorSalaryStorage AmbassadorSalaryStorage;
        
        /// <summary>
        /// AmbassadorTreasuryStorage storage calls.
        /// </summary>
        public AmbassadorTreasuryStorage AmbassadorTreasuryStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.CollatorSelectionStorage = new CollatorSelectionStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.MessageQueueStorage = new MessageQueueStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.AssetRateStorage = new AssetRateStorage(this);
            this.AllianceStorage = new AllianceStorage(this);
            this.AllianceMotionStorage = new AllianceMotionStorage(this);
            this.FellowshipCollectiveStorage = new FellowshipCollectiveStorage(this);
            this.FellowshipReferendaStorage = new FellowshipReferendaStorage(this);
            this.FellowshipOriginsStorage = new FellowshipOriginsStorage(this);
            this.FellowshipCoreStorage = new FellowshipCoreStorage(this);
            this.FellowshipSalaryStorage = new FellowshipSalaryStorage(this);
            this.FellowshipTreasuryStorage = new FellowshipTreasuryStorage(this);
            this.AmbassadorCollectiveStorage = new AmbassadorCollectiveStorage(this);
            this.AmbassadorReferendaStorage = new AmbassadorReferendaStorage(this);
            this.AmbassadorOriginsStorage = new AmbassadorOriginsStorage(this);
            this.AmbassadorCoreStorage = new AmbassadorCoreStorage(this);
            this.AmbassadorSalaryStorage = new AmbassadorSalaryStorage(this);
            this.AmbassadorTreasuryStorage = new AmbassadorTreasuryStorage(this);
        }
    }
}
