//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet;
   using Substrate.NetApi.Model.Types.Base;
   
   public interface IStateTrieMigrationControllerClient
   {
      Task<MigrationTask> GetMigrationProcess();
      Task<bool> SubscribeMigrationProcess();
      Task<BaseOpt<MigrationLimits>> GetAutoLimits();
      Task<bool> SubscribeAutoLimits();
      Task<MigrationLimits> GetSignedMigrationMaxLimits();
      Task<bool> SubscribeSignedMigrationMaxLimits();
   }
}
