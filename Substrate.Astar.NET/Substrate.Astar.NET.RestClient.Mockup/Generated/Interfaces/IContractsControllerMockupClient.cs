//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Astar.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_contracts.wasm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_contracts.storage;
   
   public interface IContractsControllerMockupClient
   {
      Task<bool> SetPristineCode(BoundedVecT12 value, Substrate.Astar.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetCodeStorage(PrefabWasmModule value, Substrate.Astar.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetOwnerInfoOf(OwnerInfo value, Substrate.Astar.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetNonce(U64 value);
      Task<bool> SetContractInfoOf(ContractInfo value, Substrate.Astar.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetDeletionQueue(BoundedVecT14 value);
   }
}