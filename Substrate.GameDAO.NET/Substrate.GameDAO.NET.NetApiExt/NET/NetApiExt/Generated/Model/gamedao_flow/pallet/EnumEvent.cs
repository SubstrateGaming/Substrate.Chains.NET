//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_flow.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Created
        /// Campaign was successfully created.
        /// </summary>
        Created = 0,
        
        /// <summary>
        /// >> Activated
        /// </summary>
        Activated = 1,
        
        /// <summary>
        /// >> Contributed
        /// Campaign was contributed.
        /// </summary>
        Contributed = 2,
        
        /// <summary>
        /// >> Succeeded
        /// Campaign was finalized.
        /// </summary>
        Succeeded = 3,
        
        /// <summary>
        /// >> Failed
        /// Campaign failed - successfully reverted.
        /// </summary>
        Failed = 4,
    }
    
    /// <summary>
    /// >> 149 - Variant[gamedao_flow.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.GameDAO.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>, Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}