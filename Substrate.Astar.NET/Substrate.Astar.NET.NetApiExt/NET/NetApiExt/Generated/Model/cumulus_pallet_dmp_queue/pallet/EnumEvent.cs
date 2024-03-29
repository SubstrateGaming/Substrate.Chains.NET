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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet
{
    
    
    public enum Event
    {
        
        InvalidFormat = 0,
        
        UnsupportedVersion = 1,
        
        ExecutedDownward = 2,
        
        WeightExhausted = 3,
        
        OverweightEnqueued = 4,
        
        OverweightServiced = 5,
        
        MaxMessagesExhausted = 6,
    }
    
    /// <summary>
    /// >> 116 - Variant[cumulus_pallet_dmp_queue.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8, BaseTuple<Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.Astar.NET.NetApiExt.Generated.Model.xcm.v3.traits.EnumOutcome>, BaseTuple<Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.Astar.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.Astar.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, BaseTuple<Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Astar.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Astar.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, Substrate.Astar.NET.NetApiExt.Generated.Types.Base.Arr32U8>
    {
    }
}
