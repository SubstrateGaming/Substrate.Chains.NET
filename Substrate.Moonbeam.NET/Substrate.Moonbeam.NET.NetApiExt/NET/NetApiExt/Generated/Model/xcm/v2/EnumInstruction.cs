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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2
{
    
    
    public enum Instruction
    {
        
        WithdrawAsset = 0,
        
        ReserveAssetDeposited = 1,
        
        ReceiveTeleportedAsset = 2,
        
        QueryResponse = 3,
        
        TransferAsset = 4,
        
        TransferReserveAsset = 5,
        
        Transact = 6,
        
        HrmpNewChannelOpenRequest = 7,
        
        HrmpChannelAccepted = 8,
        
        HrmpChannelClosing = 9,
        
        ClearOrigin = 10,
        
        DescendOrigin = 11,
        
        ReportError = 12,
        
        DepositAsset = 13,
        
        DepositReserveAsset = 14,
        
        ExchangeAsset = 15,
        
        InitiateReserveWithdraw = 16,
        
        InitiateTeleport = 17,
        
        QueryHolding = 18,
        
        BuyExecution = 19,
        
        RefundSurplus = 20,
        
        SetErrorHandler = 21,
        
        SetAppendix = 22,
        
        ClearError = 23,
        
        ClaimAsset = 24,
        
        Trap = 25,
        
        SubscribeVersion = 26,
        
        UnsubscribeVersion = 27,
    }
    
    /// <summary>
    /// >> 357 - Variant[xcm.v2.Instruction]
    /// </summary>
    public sealed class EnumInstruction : BaseEnumExt<Instruction, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.EnumResponse, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.EnumOriginKind, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.double_encoded.DoubleEncodedT2>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseVoid, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.EnumJunctions, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT1>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumMultiAssetFilter, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAsset, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.EnumWeightLimit>, BaseVoid, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT2, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.XcmT2, BaseVoid, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.xcm.v2.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseVoid>
    {
    }
}
