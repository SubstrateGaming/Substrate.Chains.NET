//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   
   public interface IAssetRateControllerClient
   {
      Task<FixedU128> GetConversionRateToNative(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset key);
      Task<bool> SubscribeConversionRateToNative(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset key);
   }
}
