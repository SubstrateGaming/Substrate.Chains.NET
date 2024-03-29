//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.rikiddo_sigmoid_mv
{
    
    
    /// <summary>
    /// >> 506 - Composite[zrml_rikiddo.types.rikiddo_sigmoid_mv.RikiddoSigmoidMV]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RikiddoSigmoidMV : BaseType
    {
        
        /// <summary>
        /// >> config
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.rikiddo_sigmoid_mv.RikiddoConfig Config { get; set; }
        /// <summary>
        /// >> fees
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.sigmoid_fee.FeeSigmoid Fees { get; set; }
        /// <summary>
        /// >> ma_short
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.ema_market_volume.EmaMarketVolume MaShort { get; set; }
        /// <summary>
        /// >> ma_long
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.ema_market_volume.EmaMarketVolume MaLong { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RikiddoSigmoidMV";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Config.Encode());
            result.AddRange(Fees.Encode());
            result.AddRange(MaShort.Encode());
            result.AddRange(MaLong.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Config = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.rikiddo_sigmoid_mv.RikiddoConfig();
            Config.Decode(byteArray, ref p);
            Fees = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.sigmoid_fee.FeeSigmoid();
            Fees.Decode(byteArray, ref p);
            MaShort = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.ema_market_volume.EmaMarketVolume();
            MaShort.Decode(byteArray, ref p);
            MaLong = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_rikiddo.types.ema_market_volume.EmaMarketVolume();
            MaLong.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
