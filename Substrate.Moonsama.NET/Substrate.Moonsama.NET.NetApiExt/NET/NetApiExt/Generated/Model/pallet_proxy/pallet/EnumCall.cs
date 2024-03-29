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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Call
    {
        
        proxy = 0,
        
        add_proxy = 1,
        
        remove_proxy = 2,
        
        remove_proxies = 3,
        
        create_pure = 4,
        
        kill_pure = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        reject_announcement = 8,
        
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 366 - Variant[pallet_proxy.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType>, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumRuntimeCall>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumProxyType>, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.EnumRuntimeCall>>
    {
    }
}
