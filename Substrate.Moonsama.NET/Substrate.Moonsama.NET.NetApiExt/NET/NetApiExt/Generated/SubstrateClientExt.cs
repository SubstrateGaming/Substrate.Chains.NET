//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.Moonsama.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Moonsama.NET.NetApiExt.Generated
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
        /// EvmChainIdStorage storage calls.
        /// </summary>
        public EvmChainIdStorage EvmChainIdStorage;
        
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
        /// ParachainStakingStorage storage calls.
        /// </summary>
        public ParachainStakingStorage ParachainStakingStorage;
        
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
        /// AssetsStorage storage calls.
        /// </summary>
        public AssetsStorage AssetsStorage;
        
        /// <summary>
        /// AssetManagerStorage storage calls.
        /// </summary>
        public AssetManagerStorage AssetManagerStorage;
        
        /// <summary>
        /// XTokensStorage storage calls.
        /// </summary>
        public XTokensStorage XTokensStorage;
        
        /// <summary>
        /// LocalAssetsStorage storage calls.
        /// </summary>
        public LocalAssetsStorage LocalAssetsStorage;
        
        /// <summary>
        /// EVMStorage storage calls.
        /// </summary>
        public EVMStorage EVMStorage;
        
        /// <summary>
        /// EthereumStorage storage calls.
        /// </summary>
        public EthereumStorage EthereumStorage;
        
        /// <summary>
        /// FreeCallsRegistryStorage storage calls.
        /// </summary>
        public FreeCallsRegistryStorage FreeCallsRegistryStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// MaintenanceModeStorage storage calls.
        /// </summary>
        public MaintenanceModeStorage MaintenanceModeStorage;
        
        /// <summary>
        /// IdentityStorage storage calls.
        /// </summary>
        public IdentityStorage IdentityStorage;
        
        /// <summary>
        /// MintingStorage storage calls.
        /// </summary>
        public MintingStorage MintingStorage;
        
        /// <summary>
        /// RandomnessStorage storage calls.
        /// </summary>
        public RandomnessStorage RandomnessStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// RolesManagementStorage storage calls.
        /// </summary>
        public RolesManagementStorage RolesManagementStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// CrowdloanRewardsStorage storage calls.
        /// </summary>
        public CrowdloanRewardsStorage CrowdloanRewardsStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// ContractsStorage storage calls.
        /// </summary>
        public ContractsStorage ContractsStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// MultiTokenStorage storage calls.
        /// </summary>
        public MultiTokenStorage MultiTokenStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.EvmChainIdStorage = new EvmChainIdStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.ParachainStakingStorage = new ParachainStakingStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.AssetsStorage = new AssetsStorage(this);
            this.AssetManagerStorage = new AssetManagerStorage(this);
            this.XTokensStorage = new XTokensStorage(this);
            this.LocalAssetsStorage = new LocalAssetsStorage(this);
            this.EVMStorage = new EVMStorage(this);
            this.EthereumStorage = new EthereumStorage(this);
            this.FreeCallsRegistryStorage = new FreeCallsRegistryStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.MaintenanceModeStorage = new MaintenanceModeStorage(this);
            this.IdentityStorage = new IdentityStorage(this);
            this.MintingStorage = new MintingStorage(this);
            this.RandomnessStorage = new RandomnessStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.RolesManagementStorage = new RolesManagementStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.CrowdloanRewardsStorage = new CrowdloanRewardsStorage(this);
            this.TreasuryStorage = new TreasuryStorage(this);
            this.ContractsStorage = new ContractsStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.MultiTokenStorage = new MultiTokenStorage(this);
        }
    }
}
