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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_session.pallet
{
    
    
    public enum Call
    {
        
        set_keys = 0,
        
        purge_keys = 1,
    }
    
    /// <summary>
    /// >> 231 - Variant[pallet_session.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.SessionKeys, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseVoid>
    {
    }
}