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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.pallet
{
    
    
    public enum Call
    {
        
        add = 0,
        
        revoke = 1,
        
        unrevoke = 2,
        
        remove = 3,
        
        reclaim_deposit = 4,
        
        change_deposit_owner = 5,
        
        update_deposit = 6,
    }
    
    /// <summary>
    /// >> 310 - Variant[public_credentials.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.Credential, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.authorization.EnumPalletAuthorize>>, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.authorization.EnumPalletAuthorize>>, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.authorization.EnumPalletAuthorize>>, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>
    {
    }
}
