//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.Aventus.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Aventus.NET.NetApiExt.Generated
{
    
    
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
        /// ParachainStakingStorage storage calls.
        /// </summary>
        public ParachainStakingStorage ParachainStakingStorage;
        
        /// <summary>
        /// ValidatorsManagerStorage storage calls.
        /// </summary>
        public ValidatorsManagerStorage ValidatorsManagerStorage;
        
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
        /// DmpQueueStorage storage calls.
        /// </summary>
        public DmpQueueStorage DmpQueueStorage;
        
        /// <summary>
        /// AssetsStorage storage calls.
        /// </summary>
        public AssetsStorage AssetsStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// AuthorityDiscoveryStorage storage calls.
        /// </summary>
        public AuthorityDiscoveryStorage AuthorityDiscoveryStorage;
        
        /// <summary>
        /// HistoricalStorage storage calls.
        /// </summary>
        public HistoricalStorage HistoricalStorage;
        
        /// <summary>
        /// OffencesStorage storage calls.
        /// </summary>
        public OffencesStorage OffencesStorage;
        
        /// <summary>
        /// ImOnlineStorage storage calls.
        /// </summary>
        public ImOnlineStorage ImOnlineStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// AvnStorage storage calls.
        /// </summary>
        public AvnStorage AvnStorage;
        
        /// <summary>
        /// AvnFinalityTrackerStorage storage calls.
        /// </summary>
        public AvnFinalityTrackerStorage AvnFinalityTrackerStorage;
        
        /// <summary>
        /// AvnOffenceHandlerStorage storage calls.
        /// </summary>
        public AvnOffenceHandlerStorage AvnOffenceHandlerStorage;
        
        /// <summary>
        /// EthereumEventsStorage storage calls.
        /// </summary>
        public EthereumEventsStorage EthereumEventsStorage;
        
        /// <summary>
        /// EthereumTransactionsStorage storage calls.
        /// </summary>
        public EthereumTransactionsStorage EthereumTransactionsStorage;
        
        /// <summary>
        /// NftManagerStorage storage calls.
        /// </summary>
        public NftManagerStorage NftManagerStorage;
        
        /// <summary>
        /// TokenManagerStorage storage calls.
        /// </summary>
        public TokenManagerStorage TokenManagerStorage;
        
        /// <summary>
        /// SummaryStorage storage calls.
        /// </summary>
        public SummaryStorage SummaryStorage;
        
        /// <summary>
        /// AvnProxyStorage storage calls.
        /// </summary>
        public AvnProxyStorage AvnProxyStorage;
        
        /// <summary>
        /// AvnTransactionPaymentStorage storage calls.
        /// </summary>
        public AvnTransactionPaymentStorage AvnTransactionPaymentStorage;
        
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
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.ParachainStakingStorage = new ParachainStakingStorage(this);
            this.ValidatorsManagerStorage = new ValidatorsManagerStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.AssetsStorage = new AssetsStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.AuthorityDiscoveryStorage = new AuthorityDiscoveryStorage(this);
            this.HistoricalStorage = new HistoricalStorage(this);
            this.OffencesStorage = new OffencesStorage(this);
            this.ImOnlineStorage = new ImOnlineStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.AvnStorage = new AvnStorage(this);
            this.AvnFinalityTrackerStorage = new AvnFinalityTrackerStorage(this);
            this.AvnOffenceHandlerStorage = new AvnOffenceHandlerStorage(this);
            this.EthereumEventsStorage = new EthereumEventsStorage(this);
            this.EthereumTransactionsStorage = new EthereumTransactionsStorage(this);
            this.NftManagerStorage = new NftManagerStorage(this);
            this.TokenManagerStorage = new TokenManagerStorage(this);
            this.SummaryStorage = new SummaryStorage(this);
            this.AvnProxyStorage = new AvnProxyStorage(this);
            this.AvnTransactionPaymentStorage = new AvnTransactionPaymentStorage(this);
        }
    }
}
