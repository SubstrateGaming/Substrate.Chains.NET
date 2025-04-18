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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_salary
{
    
    
    /// <summary>
    /// >> ClaimState
    /// </summary>
    public enum ClaimState
    {
        
        /// <summary>
        /// >> Nothing
        /// </summary>
        Nothing = 0,
        
        /// <summary>
        /// >> Registered
        /// </summary>
        Registered = 1,
        
        /// <summary>
        /// >> Attempted
        /// </summary>
        Attempted = 2,
    }
    
    /// <summary>
    /// >> 461 - Variant[pallet_salary.ClaimState]
    /// </summary>
    public sealed class EnumClaimState : BaseEnumRust<ClaimState>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumClaimState()
        {
				AddTypeDecoder<BaseVoid>(ClaimState.Nothing);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(ClaimState.Registered);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128>>(ClaimState.Attempted);
        }
    }
}
