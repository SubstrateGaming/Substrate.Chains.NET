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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    public enum Call
    {
        
        control_auto_migration = 0,
        
        continue_migrate = 1,
        
        migrate_custom_top = 2,
        
        migrate_custom_child = 3,
        
        set_signed_max_limits = 4,
        
        force_set_progress = 5,
    }
    
    /// <summary>
    /// >> 285 - Variant[pallet_state_trie_migration.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>, BaseTuple<Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits, BaseTuple<Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress, Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress>>
    {
    }
}
