//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> OrderbookStorage
    /// </summary>
    public sealed class OrderbookStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> OrderbookStorage Constructor
        /// </summary>
        public OrderbookStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Orderbook", "NextOrderId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Orderbook", "Orders"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_orderbook.types.Order)));
        }
        
        /// <summary>
        /// >> NextOrderIdParams
        /// </summary>
        public static string NextOrderIdParams()
        {
            return RequestGenerator.GetStorage("Orderbook", "NextOrderId", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextOrderIdDefault
        /// Default value as hex string
        /// </summary>
        public static string NextOrderIdDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> NextOrderId
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> NextOrderId(string blockhash, CancellationToken token)
        {
            string parameters = OrderbookStorage.NextOrderIdParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> OrdersParams
        /// </summary>
        public static string OrdersParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("Orderbook", "Orders", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OrdersDefault
        /// Default value as hex string
        /// </summary>
        public static string OrdersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Orders
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_orderbook.types.Order> Orders(Substrate.NetApi.Model.Types.Primitive.U128 key, string blockhash, CancellationToken token)
        {
            string parameters = OrderbookStorage.OrdersParams(key);
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_orderbook.types.Order>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> OrderbookCalls
    /// </summary>
    public sealed class OrderbookCalls
    {
        
        /// <summary>
        /// >> remove_order
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveOrder(Substrate.NetApi.Model.Types.Primitive.U128 order_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(order_id.Encode());
            return new Method(61, "Orderbook", 0, "remove_order", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> fill_order
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FillOrder(Substrate.NetApi.Model.Types.Primitive.U128 order_id, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> maker_partial_fill)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(order_id.Encode());
            byteArray.AddRange(maker_partial_fill.Encode());
            return new Method(61, "Orderbook", 1, "fill_order", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> place_order
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PlaceOrder(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset maker_asset, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> maker_amount, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset taker_asset, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> taker_amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            byteArray.AddRange(maker_asset.Encode());
            byteArray.AddRange(maker_amount.Encode());
            byteArray.AddRange(taker_asset.Encode());
            byteArray.AddRange(taker_amount.Encode());
            return new Method(61, "Orderbook", 2, "place_order", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> OrderbookConstants
    /// </summary>
    public sealed class OrderbookConstants
    {
        
        /// <summary>
        /// >> PalletId
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.frame_support.PalletId();
            result.Create("0x7A67652F6F726462");
            return result;
        }
    }
    
    /// <summary>
    /// >> OrderbookErrors
    /// </summary>
    public enum OrderbookErrors
    {
        
        /// <summary>
        /// >> NotOrderCreator
        /// The sender is not the order creator.
        /// </summary>
        NotOrderCreator,
        
        /// <summary>
        /// >> OrderDoesNotExist
        /// The order does not exist.
        /// </summary>
        OrderDoesNotExist,
        
        /// <summary>
        /// >> MarketIsNotActive
        /// The market is not active.
        /// </summary>
        MarketIsNotActive,
        
        /// <summary>
        /// >> InvalidScoringRule
        /// The scoring rule is not order book.
        /// </summary>
        InvalidScoringRule,
        
        /// <summary>
        /// >> AmountTooHighForOrder
        /// The specified amount parameter is too high for the order.
        /// </summary>
        AmountTooHighForOrder,
        
        /// <summary>
        /// >> InvalidOutcomeAsset
        /// The specified outcome asset is not part of the market.
        /// </summary>
        InvalidOutcomeAsset,
        
        /// <summary>
        /// >> PartialFillNearFullFillNotAllowed
        /// The maker partial fill leads to a too low quotient for the next order execution.
        /// </summary>
        PartialFillNearFullFillNotAllowed,
        
        /// <summary>
        /// >> MarketBaseAssetNotPresent
        /// The market base asset is not present.
        /// </summary>
        MarketBaseAssetNotPresent,
        
        /// <summary>
        /// >> BelowMinimumBalance
        /// The specified amount is below the minimum balance.
        /// </summary>
        BelowMinimumBalance,
    }
}
