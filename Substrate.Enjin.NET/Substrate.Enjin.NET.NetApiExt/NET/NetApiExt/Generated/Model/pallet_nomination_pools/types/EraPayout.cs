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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_nomination_pools.types
{
    
    
    /// <summary>
    /// >> 774 - Composite[pallet_nomination_pools.types.EraPayout]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EraPayout : BaseType
    {
        
        /// <summary>
        /// >> era
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Era { get; set; }
        /// <summary>
        /// >> payout_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> PayoutCount { get; set; }
        /// <summary>
        /// >> payouts_processed
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool PayoutsProcessed { get; set; }
        /// <summary>
        /// >> required_payments_percent
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill RequiredPaymentsPercent { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "EraPayout";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Era.Encode());
            result.AddRange(PayoutCount.Encode());
            result.AddRange(PayoutsProcessed.Encode());
            result.AddRange(RequiredPaymentsPercent.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Era = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Era.Decode(byteArray, ref p);
            PayoutCount = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            PayoutCount.Decode(byteArray, ref p);
            PayoutsProcessed = new Substrate.NetApi.Model.Types.Primitive.Bool();
            PayoutsProcessed.Decode(byteArray, ref p);
            RequiredPaymentsPercent = new Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            RequiredPaymentsPercent.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}