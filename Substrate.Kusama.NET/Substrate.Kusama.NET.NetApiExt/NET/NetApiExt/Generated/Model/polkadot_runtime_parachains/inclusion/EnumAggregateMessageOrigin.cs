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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion
{
    
    
    /// <summary>
    /// >> AggregateMessageOrigin
    /// </summary>
    public enum AggregateMessageOrigin
    {
        
        /// <summary>
        /// >> Ump
        /// </summary>
        Ump = 0,
    }
    
    /// <summary>
    /// >> 453 - Variant[polkadot_runtime_parachains.inclusion.AggregateMessageOrigin]
    /// </summary>
    public sealed class EnumAggregateMessageOrigin : BaseEnumRust<AggregateMessageOrigin>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumAggregateMessageOrigin()
        {
				AddTypeDecoder<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.EnumUmpQueueId>(AggregateMessageOrigin.Ump);
        }
    }
}
