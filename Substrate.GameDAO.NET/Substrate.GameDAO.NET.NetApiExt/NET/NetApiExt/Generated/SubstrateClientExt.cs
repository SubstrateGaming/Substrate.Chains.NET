//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.GameDAO.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.GameDAO.NET.NetApiExt.Generated
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
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// CouncilStorage storage calls.
        /// </summary>
        public CouncilStorage CouncilStorage;
        
        /// <summary>
        /// TechnicalCommitteeStorage storage calls.
        /// </summary>
        public TechnicalCommitteeStorage TechnicalCommitteeStorage;
        
        /// <summary>
        /// IdentityStorage storage calls.
        /// </summary>
        public IdentityStorage IdentityStorage;
        
        /// <summary>
        /// BountiesStorage storage calls.
        /// </summary>
        public BountiesStorage BountiesStorage;
        
        /// <summary>
        /// ChildBountiesStorage storage calls.
        /// </summary>
        public ChildBountiesStorage ChildBountiesStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// DemocracyStorage storage calls.
        /// </summary>
        public DemocracyStorage DemocracyStorage;
        
        /// <summary>
        /// ElectionsStorage storage calls.
        /// </summary>
        public ElectionsStorage ElectionsStorage;
        
        /// <summary>
        /// TechnicalMembershipStorage storage calls.
        /// </summary>
        public TechnicalMembershipStorage TechnicalMembershipStorage;
        
        /// <summary>
        /// RandomnessCollectiveFlipStorage storage calls.
        /// </summary>
        public RandomnessCollectiveFlipStorage RandomnessCollectiveFlipStorage;
        
        /// <summary>
        /// ContractsStorage storage calls.
        /// </summary>
        public ContractsStorage ContractsStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// TipsStorage storage calls.
        /// </summary>
        public TipsStorage TipsStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// NftsStorage storage calls.
        /// </summary>
        public NftsStorage NftsStorage;
        
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
        /// DmpQueueStorage storage calls.
        /// </summary>
        public DmpQueueStorage DmpQueueStorage;
        
        /// <summary>
        /// AssetRegistryStorage storage calls.
        /// </summary>
        public AssetRegistryStorage AssetRegistryStorage;
        
        /// <summary>
        /// CurrenciesStorage storage calls.
        /// </summary>
        public CurrenciesStorage CurrenciesStorage;
        
        /// <summary>
        /// OrmlXcmStorage storage calls.
        /// </summary>
        public OrmlXcmStorage OrmlXcmStorage;
        
        /// <summary>
        /// TokensStorage storage calls.
        /// </summary>
        public TokensStorage TokensStorage;
        
        /// <summary>
        /// UnknownTokensStorage storage calls.
        /// </summary>
        public UnknownTokensStorage UnknownTokensStorage;
        
        /// <summary>
        /// XTokensStorage storage calls.
        /// </summary>
        public XTokensStorage XTokensStorage;
        
        /// <summary>
        /// FlowStorage storage calls.
        /// </summary>
        public FlowStorage FlowStorage;
        
        /// <summary>
        /// SenseStorage storage calls.
        /// </summary>
        public SenseStorage SenseStorage;
        
        /// <summary>
        /// ControlStorage storage calls.
        /// </summary>
        public ControlStorage ControlStorage;
        
        /// <summary>
        /// SignalStorage storage calls.
        /// </summary>
        public SignalStorage SignalStorage;
        
        /// <summary>
        /// BattlepassStorage storage calls.
        /// </summary>
        public BattlepassStorage BattlepassStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.CouncilStorage = new CouncilStorage(this);
            this.TechnicalCommitteeStorage = new TechnicalCommitteeStorage(this);
            this.IdentityStorage = new IdentityStorage(this);
            this.BountiesStorage = new BountiesStorage(this);
            this.ChildBountiesStorage = new ChildBountiesStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.DemocracyStorage = new DemocracyStorage(this);
            this.ElectionsStorage = new ElectionsStorage(this);
            this.TechnicalMembershipStorage = new TechnicalMembershipStorage(this);
            this.RandomnessCollectiveFlipStorage = new RandomnessCollectiveFlipStorage(this);
            this.ContractsStorage = new ContractsStorage(this);
            this.TreasuryStorage = new TreasuryStorage(this);
            this.TipsStorage = new TipsStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.NftsStorage = new NftsStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.CollatorSelectionStorage = new CollatorSelectionStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.AssetRegistryStorage = new AssetRegistryStorage(this);
            this.CurrenciesStorage = new CurrenciesStorage(this);
            this.OrmlXcmStorage = new OrmlXcmStorage(this);
            this.TokensStorage = new TokensStorage(this);
            this.UnknownTokensStorage = new UnknownTokensStorage(this);
            this.XTokensStorage = new XTokensStorage(this);
            this.FlowStorage = new FlowStorage(this);
            this.SenseStorage = new SenseStorage(this);
            this.ControlStorage = new ControlStorage(this);
            this.SignalStorage = new SignalStorage(this);
            this.BattlepassStorage = new BattlepassStorage(this);
        }
    }
}
