//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types;
   
   public interface IFreeCallsRegistryControllerClient
   {
      Task<BaseTuple> GetFreeCallsRegistry(EvmCall key);
      Task<bool> SubscribeFreeCallsRegistry(EvmCall key);
      Task<U32> GetRequestExpiryDate(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeRequestExpiryDate(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<EvmCallCounter> GetFreeCallsAvailable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeFreeCallsAvailable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
   }
}
