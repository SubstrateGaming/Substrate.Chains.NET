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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_balances.pallet
{
    
    
    public enum Call
    {
        
        transfer_allow_death = 0,
        
        set_balance_deprecated = 1,
        
        force_transfer = 2,
        
        transfer_keep_alive = 3,
        
        transfer_all = 4,
        
        force_unreserve = 5,
        
        upgrade_accounts = 6,
        
        transfer = 7,
        
        force_set_balance = 8,
    }
    
    /// <summary>
    /// >> 217 - Variant[pallet_balances.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>
    {
    }
}