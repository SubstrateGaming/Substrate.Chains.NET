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
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_preimage;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IPreimageControllerMockupClient
   {
      Task<bool> SetStatusFor(EnumOldRequestStatus value, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetRequestStatusFor(EnumRequestStatus value, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetPreimageFor(BoundedVecT15 value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key);
   }
}
