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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_transaction_payment.fee_adjustment_config
{
    
    
    /// <summary>
    /// >> 124 - Composite[pallet_avn_transaction_payment.fee_adjustment_config.FixedFeeConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FixedFeeConfig : BaseType
    {
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _fee;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public override string TypeName()
        {
            return "FixedFeeConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Fee.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Fee = new Substrate.NetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
