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
    /// >> AssetManagerStorage
    /// </summary>
    public sealed class AssetManagerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AssetManagerStorage Constructor
        /// </summary>
        public AssetManagerStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    /// <summary>
    /// >> AssetManagerCalls
    /// </summary>
    public sealed class AssetManagerCalls
    {
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset currency_id, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(40, "AssetManager", 0, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_native_currency
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferNativeCurrency(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(40, "AssetManager", 1, "transfer_native_currency", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_balance
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UpdateBalance(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset currency_id, Substrate.NetApi.Model.Types.Primitive.I128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(40, "AssetManager", 2, "update_balance", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AssetManagerConstants
    /// </summary>
    public sealed class AssetManagerConstants
    {
        
        /// <summary>
        /// >> GetNativeCurrencyId
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset GetNativeCurrencyId()
        {
            var result = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset();
            result.Create("0x04");
            return result;
        }
    }
    
    /// <summary>
    /// >> AssetManagerErrors
    /// </summary>
    public enum AssetManagerErrors
    {
        
        /// <summary>
        /// >> AmountIntoBalanceFailed
        /// Unable to convert the Amount type into Balance.
        /// </summary>
        AmountIntoBalanceFailed,
        
        /// <summary>
        /// >> BalanceTooLow
        /// Balance is too low.
        /// </summary>
        BalanceTooLow,
        
        /// <summary>
        /// >> DepositFailed
        /// Deposit result is not expected
        /// </summary>
        DepositFailed,
    }
}
