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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    public enum Call
    {
        
        set_validation_data = 0,
        
        sudo_send_upward_message = 1,
        
        authorize_upgrade = 2,
        
        enact_authorized_upgrade = 3,
    }
    
    /// <summary>
    /// >> 131 - Variant[cumulus_pallet_parachain_system.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.Collectives.NET.NetApiExt.Generated.Model.cumulus_primitives_parachain_inherent.ParachainInherentData, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>
    {
    }
}