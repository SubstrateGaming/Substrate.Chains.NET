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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market
{
    
    
    /// <summary>
    /// >> 121 - Composite[zeitgeist_primitives.market.EarlyClose]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EarlyClose : BaseType
    {
        
        /// <summary>
        /// >> old
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod Old { get; set; }
        /// <summary>
        /// >> new
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod New { get; set; }
        /// <summary>
        /// >> state
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumEarlyCloseState State { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "EarlyClose";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Old.Encode());
            result.AddRange(New.Encode());
            result.AddRange(State.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Old = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod();
            Old.Decode(byteArray, ref p);
            New = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumMarketPeriod();
            New.Decode(byteArray, ref p);
            State = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market.EnumEarlyCloseState();
            State.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
