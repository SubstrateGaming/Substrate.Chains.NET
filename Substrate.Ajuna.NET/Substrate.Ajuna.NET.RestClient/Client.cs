//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   using Substrate.Ajuna.NET.RestClient.Generated.Clients;
   
   public sealed class Client
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IAuraControllerClient AuraControllerClient;
      public IAuraExtControllerClient AuraExtControllerClient;
      public IAuthorshipControllerClient AuthorshipControllerClient;
      public IBalancesControllerClient BalancesControllerClient;
      public ICollatorSelectionControllerClient CollatorSelectionControllerClient;
      public ICouncilControllerClient CouncilControllerClient;
      public ICouncilMembershipControllerClient CouncilMembershipControllerClient;
      public IDmpQueueControllerClient DmpQueueControllerClient;
      public IIdentityControllerClient IdentityControllerClient;
      public IMultisigControllerClient MultisigControllerClient;
      public IParachainInfoControllerClient ParachainInfoControllerClient;
      public IParachainSystemControllerClient ParachainSystemControllerClient;
      public IPolkadotXcmControllerClient PolkadotXcmControllerClient;
      public IPreimageControllerClient PreimageControllerClient;
      public IProxyControllerClient ProxyControllerClient;
      public ISchedulerControllerClient SchedulerControllerClient;
      public ISessionControllerClient SessionControllerClient;
      public ISudoControllerClient SudoControllerClient;
      public ISystemControllerClient SystemControllerClient;
      public ITimestampControllerClient TimestampControllerClient;
      public ITransactionPaymentControllerClient TransactionPaymentControllerClient;
      public ITreasuryControllerClient TreasuryControllerClient;
      public IVestingControllerClient VestingControllerClient;
      public IXcmpQueueControllerClient XcmpQueueControllerClient;
      public Client(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
         AuraControllerClient = new AuraControllerClient(_httpClient, _subscriptionClient);
         AuraExtControllerClient = new AuraExtControllerClient(_httpClient, _subscriptionClient);
         AuthorshipControllerClient = new AuthorshipControllerClient(_httpClient, _subscriptionClient);
         BalancesControllerClient = new BalancesControllerClient(_httpClient, _subscriptionClient);
         CollatorSelectionControllerClient = new CollatorSelectionControllerClient(_httpClient, _subscriptionClient);
         CouncilControllerClient = new CouncilControllerClient(_httpClient, _subscriptionClient);
         CouncilMembershipControllerClient = new CouncilMembershipControllerClient(_httpClient, _subscriptionClient);
         DmpQueueControllerClient = new DmpQueueControllerClient(_httpClient, _subscriptionClient);
         IdentityControllerClient = new IdentityControllerClient(_httpClient, _subscriptionClient);
         MultisigControllerClient = new MultisigControllerClient(_httpClient, _subscriptionClient);
         ParachainInfoControllerClient = new ParachainInfoControllerClient(_httpClient, _subscriptionClient);
         ParachainSystemControllerClient = new ParachainSystemControllerClient(_httpClient, _subscriptionClient);
         PolkadotXcmControllerClient = new PolkadotXcmControllerClient(_httpClient, _subscriptionClient);
         PreimageControllerClient = new PreimageControllerClient(_httpClient, _subscriptionClient);
         ProxyControllerClient = new ProxyControllerClient(_httpClient, _subscriptionClient);
         SchedulerControllerClient = new SchedulerControllerClient(_httpClient, _subscriptionClient);
         SessionControllerClient = new SessionControllerClient(_httpClient, _subscriptionClient);
         SudoControllerClient = new SudoControllerClient(_httpClient, _subscriptionClient);
         SystemControllerClient = new SystemControllerClient(_httpClient, _subscriptionClient);
         TimestampControllerClient = new TimestampControllerClient(_httpClient, _subscriptionClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerClient(_httpClient, _subscriptionClient);
         TreasuryControllerClient = new TreasuryControllerClient(_httpClient, _subscriptionClient);
         VestingControllerClient = new VestingControllerClient(_httpClient, _subscriptionClient);
         XcmpQueueControllerClient = new XcmpQueueControllerClient(_httpClient, _subscriptionClient);
      }
   }
}
