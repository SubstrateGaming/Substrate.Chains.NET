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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> UnlockTarget
    /// </summary>
    public enum UnlockTarget
    {
        
        /// <summary>
        /// >> OneselfFree
        /// </summary>
        OneselfFree = 0,
        
        /// <summary>
        /// >> OneselfPaying
        /// </summary>
        OneselfPaying = 1,
        
        /// <summary>
        /// >> OtherPaying
        /// </summary>
        OtherPaying = 2,
    }
    
    /// <summary>
    /// >> 409 - Variant[pallet_ajuna_awesome_avatars.types.config.UnlockTarget]
    /// </summary>
    public sealed class EnumUnlockTarget : BaseEnumRust<UnlockTarget>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumUnlockTarget()
        {
				AddTypeDecoder<BaseVoid>(UnlockTarget.OneselfFree);
				AddTypeDecoder<BaseVoid>(UnlockTarget.OneselfPaying);
				AddTypeDecoder<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(UnlockTarget.OtherPaying);
        }
    }
}