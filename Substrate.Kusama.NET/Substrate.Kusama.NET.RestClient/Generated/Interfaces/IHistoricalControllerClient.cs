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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IHistoricalControllerClient
   {
      Task<BaseTuple<H256, U32>> GetHistoricalSessions(U32 key);
      Task<bool> SubscribeHistoricalSessions(U32 key);
      Task<BaseTuple<U32, U32>> GetStoredRange();
      Task<bool> SubscribeStoredRange();
   }
}