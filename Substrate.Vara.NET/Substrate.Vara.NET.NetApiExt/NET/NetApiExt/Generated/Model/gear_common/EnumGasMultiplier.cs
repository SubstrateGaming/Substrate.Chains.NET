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


namespace Substrate.Vara.NET.NetApiExt.Generated.Model.gear_common
{
    
    
    /// <summary>
    /// >> GasMultiplier
    /// </summary>
    public enum GasMultiplier
    {
        
        /// <summary>
        /// >> ValuePerGas
        /// </summary>
        ValuePerGas = 0,
        
        /// <summary>
        /// >> GasPerValue
        /// </summary>
        GasPerValue = 1,
    }
    
    /// <summary>
    /// >> 595 - Variant[gear_common.GasMultiplier]
    /// </summary>
    public sealed class EnumGasMultiplier : BaseEnumExt<GasMultiplier, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U64>
    {
    }
}
