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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types
{
    
    
    /// <summary>
    /// >> 228 - Composite[pallet_parachain_staking.types.Nominations]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Nominations : BaseType
    {
        
        /// <summary>
        /// >> nominations
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Bond> _nominations;
        
        /// <summary>
        /// >> total
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _total;
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Bond> NominationsVal
        {
            get
            {
                return this._nominations;
            }
            set
            {
                this._nominations = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public override string TypeName()
        {
            return "Nominations";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(NominationsVal.Encode());
            result.AddRange(Total.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            NominationsVal = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types.Bond>();
            NominationsVal.Decode(byteArray, ref p);
            Total = new Substrate.NetApi.Model.Types.Primitive.U128();
            Total.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
