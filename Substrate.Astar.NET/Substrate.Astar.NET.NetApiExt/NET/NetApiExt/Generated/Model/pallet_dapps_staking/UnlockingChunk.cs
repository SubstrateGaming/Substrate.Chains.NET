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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_dapps_staking
{
    
    
    /// <summary>
    /// >> 317 - Composite[pallet_dapps_staking.UnlockingChunk]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UnlockingChunk : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> _amount;
        
        /// <summary>
        /// >> unlock_era
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _unlockEra;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> UnlockEra
        {
            get
            {
                return this._unlockEra;
            }
            set
            {
                this._unlockEra = value;
            }
        }
        
        public override string TypeName()
        {
            return "UnlockingChunk";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(UnlockEra.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Amount.Decode(byteArray, ref p);
            UnlockEra = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            UnlockEra.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}