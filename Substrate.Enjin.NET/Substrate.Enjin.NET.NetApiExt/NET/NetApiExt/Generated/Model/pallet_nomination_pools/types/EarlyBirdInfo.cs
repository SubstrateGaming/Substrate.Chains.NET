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
    /// >> 773 - Composite[pallet_nomination_pools.types.EarlyBirdInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EarlyBirdInfo : BaseType
    {
        
        /// <summary>
        /// >> bonus_calculated
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool BonusCalculated { get; set; }
        /// <summary>
        /// >> current_payment_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> CurrentPaymentId { get; set; }
        /// <summary>
        /// >> next_payment_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> NextPaymentBlock { get; set; }
        /// <summary>
        /// >> total_paid
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalPaid { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "EarlyBirdInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BonusCalculated.Encode());
            result.AddRange(CurrentPaymentId.Encode());
            result.AddRange(NextPaymentBlock.Encode());
            result.AddRange(TotalPaid.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BonusCalculated = new Substrate.NetApi.Model.Types.Primitive.Bool();
            BonusCalculated.Decode(byteArray, ref p);
            CurrentPaymentId = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            CurrentPaymentId.Decode(byteArray, ref p);
            NextPaymentBlock = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            NextPaymentBlock.Decode(byteArray, ref p);
            TotalPaid = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalPaid.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}