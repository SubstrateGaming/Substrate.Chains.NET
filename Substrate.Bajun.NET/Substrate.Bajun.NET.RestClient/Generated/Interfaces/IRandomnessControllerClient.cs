//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Bajun.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IRandomnessControllerClient
   {
      Task<BoundedVecT50> GetRandomMaterial();
      Task<bool> SubscribeRandomMaterial();
   }
}
