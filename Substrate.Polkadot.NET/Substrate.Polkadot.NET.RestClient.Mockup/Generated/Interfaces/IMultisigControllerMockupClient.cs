//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_multisig;
   
   public interface IMultisigControllerMockupClient
   {
      Task<bool> SetMultisigs(Multisig value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base.Arr32U8> key);
   }
}
