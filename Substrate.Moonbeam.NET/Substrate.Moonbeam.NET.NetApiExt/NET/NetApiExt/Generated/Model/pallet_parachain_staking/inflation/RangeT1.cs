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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_parachain_staking.inflation
{
    
    
    /// <summary>
    /// >> 237 - Composite[pallet_parachain_staking.inflation.RangeT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RangeT1 : BaseType
    {
        
        /// <summary>
        /// >> min
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _min;
        
        /// <summary>
        /// >> ideal
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _ideal;
        
        /// <summary>
        /// >> max
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _max;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Ideal
        {
            get
            {
                return this._ideal;
            }
            set
            {
                this._ideal = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }
        
        public override string TypeName()
        {
            return "RangeT1";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Min.Encode());
            result.AddRange(Ideal.Encode());
            result.AddRange(Max.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Min = new Substrate.NetApi.Model.Types.Primitive.U128();
            Min.Decode(byteArray, ref p);
            Ideal = new Substrate.NetApi.Model.Types.Primitive.U128();
            Ideal.Decode(byteArray, ref p);
            Max = new Substrate.NetApi.Model.Types.Primitive.U128();
            Max.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
